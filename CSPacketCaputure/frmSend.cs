using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPacketCaputure
{
    public partial class frmSend : Form
    {
        public static int instances = 0;
        public frmSend()
        {
            InitializeComponent();
            instances++;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            openFileDialog1.Title = "Open Captured Packets";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                txtPacket.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog1.Title = "Save the Captured Packets";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, txtPacket.Text);
            }
        }

        private void frmSend_FormClosed(object sender, FormClosedEventArgs e)
        {
            instances--;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string stringBytes = "";

            foreach(string s in txtPacket.Lines)
            {
                string[] noComments = s.Split('#');
                string s1 = noComments[0];
                stringBytes += s1 + Environment.NewLine; 
            }

            string[] sBytes = stringBytes.Split(new string[] { "\n", "\r\r", " ", "\r","\t" }, StringSplitOptions.RemoveEmptyEntries);

            byte[] packet = new byte[sBytes.Length];
            int i = 0;
            foreach(string s in sBytes)
            {
                packet[i] = Convert.ToByte(s, 16);
                i++;
            }

            try
            {
                frmCapture.device.SendPacket(packet);
            }
            catch(Exception)
            {

            }
        }
    }
}
