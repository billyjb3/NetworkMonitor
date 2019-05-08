using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketDotNet;
using SharpPcap;
using System.Net.NetworkInformation;
using System.Net;

namespace CSPacketCaputure
{
    public partial class frmCapture : Form
    {
        CaptureDeviceList devices;
        public static ICaptureDevice device;
        public static String stringPackets = "";
        static int numPackets = 0;
        static int arpcount = 0;
        static int tcpcount = 0; //06
        static int udpcount = 0; //11
        static List<String> sourceIPList;
        static List<String> destIPList;
        static List<int> sourceIPCount;
        static List<int> destIPCount;
        static List<byte[]> packets;
        static List<ListViewItem> packetListViewItems;
        static bool newPacket = false;

        public frmCapture()
        {
            InitializeComponent();
            devices = CaptureDeviceList.Instance;
            sourceIPList = new List<String>();
            destIPList = new List<String>();
            sourceIPCount = new List<int>();
            destIPCount = new List<int>();
            packets = new List<byte[]>();
            packetListViewItems = new List<ListViewItem>();

            if(devices.Count < 1)
            {
                MessageBox.Show("No Capture Devices Found");
                Application.Exit();
            }

            foreach(ICaptureDevice dev in devices)
            {
                cmbDevices.Items.Add(dev.Description);
            }

            device = devices[2];
            cmbDevices.Text = device.Description;

            device.OnPacketArrival += new SharpPcap.PacketArrivalEventHandler(device_OnPacketArrival);

            int readTimeoutMilli = 1000;
            device.Open(DeviceMode.Promiscuous, readTimeoutMilli);

            SourceIPListView.View = View.Details;
            DestIPListView.View = View.Details;
        }

        private static void addPacket(byte[] packet)
        {
            packets.Add(packet);
            newPacket = true;

            String[] row = new String[9];
            row[0] = numPackets.ToString();

            String dmac = "";
            for (int i = 0; i < 6; i++)
                dmac += packet[i].ToString("X2") + " ";
            row[1] = dmac;

            String smac = "";
            for (int i = 6; i < 12; i++)
                smac += packet[i].ToString("X2") + " ";
            row[2] = smac;

            if (packet[12] == 8)
            {
                if (packet[13] == 0)
                {
                    row[7] = "IP4";
                }
                if (packet[13] == 6)
                {
                    row[7] = "ARP";
                    arpcount++;
                }
            }
            else if(packet[12] == 0x86 && packet[13] == 0xdd)
            {
                row[7] = "IP6";
            }

            string sip = "";
            string dip = "";
            if (row[7] == "IP4")
            {
                byte protocol = packet[23];
                if (protocol == 6)
                {
                    tcpcount++;
                    row[7] = "TCP";
                }
                else if (protocol == 0x11)
                {
                    udpcount++;
                    row[7] = "UDP";
                }
                row[5] = ((int)packet[34]*16*16 + (int)packet[35]).ToString();
                row[6] = ((int)packet[36]*16*16 + (int)packet[37]).ToString();
                sip = packet[26].ToString() + "." + packet[27].ToString() + "." + packet[28].ToString() + "." + packet[29].ToString();        
                dip = packet[30].ToString() + "." + packet[31].ToString() + "." + packet[32].ToString() + "." + packet[33].ToString();
            }
            else if(row[7] == "ARP")
            {
                sip = packet[28].ToString() + "." + packet[29].ToString() + "." + packet[30].ToString() + "." + packet[31].ToString();
                dip = packet[38].ToString() + "." + packet[39].ToString() + "." + packet[40].ToString() + "." + packet[41].ToString();
            }
            else if(row[7] == "IP6")
            {
                for(int i = 22; i <= 36; i += 2)
                {
                    sip += packet[i].ToString("X2") + packet[i + 1].ToString("X2");
                    if (i != 36)
                        sip += ":";
                }
                for(int i = 38; i <= 52; i += 2)
                {
                    dip += packet[i].ToString("X2") + packet[i + 1].ToString("X2");
                    if (i != 52)
                        dip += ":";
                }
            }
            row[3] = sip;
            row[4] = dip;
            row[8] = packet.Length.ToString();

            if (sourceIPList.Contains(sip))
            {
                int index = sourceIPList.IndexOf(sip);
                sourceIPCount[index]++;
            }
            else
            {
                sourceIPList.Add(sip);
                sourceIPCount.Add(1);
            }
            if (destIPList.Contains(dip))
            {
                int index = destIPList.IndexOf(dip);
                destIPCount[index]++;
            }
            else
            {
                destIPList.Add(dip);
                destIPCount.Add(1);
            }

            ListViewItem item = new ListViewItem(row);
            packetListViewItems.Add(item);
        }
        private static void device_OnPacketArrival(Object sender, CaptureEventArgs packet)
        {
            numPackets++;

            byte[] data = packet.Packet.Data;
            addPacket(data);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnStartStop.Text == "Start")
                {
                    device.StartCapture();
                    timer1.Enabled = true;
                    btnStartStop.Text = "Stop";
                }
                else
                {
                    device.StopCapture();
                    timer1.Enabled = false;
                    btnStartStop.Text = "Start";
                }
            }
            catch(Exception)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtNumPackets.Text = Convert.ToString(numPackets);
            arpNum.Text = arpcount.ToString();
            udpNum.Text = udpcount.ToString();
            tcpNum.Text = tcpcount.ToString();

            arpPerc.Text = ((float)arpcount*100 / numPackets).ToString();
            tcpPerc.Text = ((float)tcpcount*100 / numPackets).ToString();
            udpPerc.Text = ((float)udpcount*100 / numPackets).ToString();

            if (newPacket && autoUpdateCB.Checked)
            {
                updateTables();
                newPacket = false;
            }
        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            device = devices[cmbDevices.SelectedIndex];
            cmbDevices.Text = device.Description;
            txtGUID.Text = device.Name;

            device.OnPacketArrival += new SharpPcap.PacketArrivalEventHandler(device_OnPacketArrival);

            int readTimeoutMilli = 1000;
            device.Open(DeviceMode.Promiscuous, readTimeoutMilli);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog1.Title = "Save the Captured Packets";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                //System.IO.File.WriteAllText(saveFileDialog1.FileName, txtCaptureData.Text);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            openFileDialog1.Title = "Open Captured Packets";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                //txtCaptureData.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void sendWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmSend.instances == 0)
            {
                var fsend = new frmSend();
                fsend.Show();
            }
        }

        private void frmCapture_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateTables();
        }

        private void updateTables()
        {
            PacketListView.Items.Clear();
            PacketListView.Items.AddRange(packetListViewItems.ToArray());
            SourceIPListView.Items.Clear();
            DestIPListView.Items.Clear();
            List<ListViewItem> sitems = new List<ListViewItem>();
            List<ListViewItem> ditems = new List<ListViewItem>();
            foreach (String ip in sourceIPList)
            {
                String[] row = new String[2];
                row[0] = ip;
                row[1] = sourceIPCount[sourceIPList.IndexOf(ip)].ToString();
                ListViewItem item = new ListViewItem(row);
                sitems.Add(item);
            }
            foreach (String ip in destIPList)
            {
                String[] row = new String[2];
                row[0] = ip;
                row[1] = destIPCount[destIPList.IndexOf(ip)].ToString();
                ListViewItem item = new ListViewItem(row);
                ditems.Add(item);
            }
            SourceIPListView.Items.AddRange(sitems.ToArray());
            DestIPListView.Items.AddRange(ditems.ToArray());
        }

        private void SourceIPListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = SourceIPListView.FocusedItem.Index;
            selectedIPLabel.Text = sourceIPList[index];
        }

        private void DestIPListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = DestIPListView.FocusedItem.Index;
            selectedIPLabel.Text = destIPList[index];
        }

        private void PingButton_Click(object sender, EventArgs e)
        {
            IPAddress address = IPAddress.Parse(selectedIPLabel.Text);
            try
            {
                IPHostEntry host = Dns.GetHostEntry(address);
                cmdResponseBox.AppendText(host.HostName+"\n");
            }
            catch
            {
                cmdResponseBox.AppendText("Could not get DNS\n");
            }
            /*
            Ping ping = new Ping();
            PingReply reply = ping.Send(address);
            if(reply.Status == IPStatus.Success)
            {
                cmdResponseBox.AppendText(reply.Address.ToString()+"\n");
                byte[] data = reply.Buffer;
                cmdResponseBox.AppendText(System.Text.Encoding.UTF8.GetString(data));
            }
            else
            {
                cmdResponseBox.AppendText("Ping Unsucessful");
            }
            */
        }

        private void PacketListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            rawTextBox.Clear();
            if (PacketListView.FocusedItem != null)
            {
                int index = PacketListView.FocusedItem.Index;
                byte[] data = packets[index];
                string output = "";

                int count = 0;
                foreach (byte b in data)
                {
                    count++;
                    output += b.ToString("X2");
                    if (count % 16 == 0)
                        output += Environment.NewLine;
                    else if (count % 8 == 0)
                        output += "\t";
                    else
                        output += " ";
                }
                rawTextBox.Text = output;
            }
        }

        private void tcpNum_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void selectedIPLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
