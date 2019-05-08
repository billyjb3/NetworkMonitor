namespace CSPacketCaputure
{
    partial class frmCapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtNumPackets = new System.Windows.Forms.TextBox();
            this.txtGUID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SourceIPListView = new System.Windows.Forms.ListView();
            this.SrcIPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPNumCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestIPListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.autoUpdateCB = new System.Windows.Forms.CheckBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cmdResponseBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedIPLabel = new System.Windows.Forms.Label();
            this.PingButton = new System.Windows.Forms.Button();
            this.PacketListView = new System.Windows.Forms.ListView();
            this.PNUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PROTOCOl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SIZE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rawTextBox = new System.Windows.Forms.TextBox();
            this.SPORT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DPORT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.udpNum = new System.Windows.Forms.Label();
            this.udpPerc = new System.Windows.Forms.Label();
            this.tcpPerc = new System.Windows.Forms.Label();
            this.arpPerc = new System.Windows.Forms.Label();
            this.tcpNum = new System.Windows.Forms.Label();
            this.arpNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnStartStop.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnStartStop.Location = new System.Drawing.Point(12, 41);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // cmbDevices
            // 
            this.cmbDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cmbDevices.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDevices.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(93, 41);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(255, 21);
            this.cmbDevices.TabIndex = 1;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.screenToolStripMenuItem,
            this.packetsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1490, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // screenToolStripMenuItem
            // 
            this.screenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.screenToolStripMenuItem.Name = "screenToolStripMenuItem";
            this.screenToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.screenToolStripMenuItem.Text = "Screen";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // packetsToolStripMenuItem
            // 
            this.packetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendWindowToolStripMenuItem});
            this.packetsToolStripMenuItem.Name = "packetsToolStripMenuItem";
            this.packetsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.packetsToolStripMenuItem.Text = "Packets";
            // 
            // sendWindowToolStripMenuItem
            // 
            this.sendWindowToolStripMenuItem.Name = "sendWindowToolStripMenuItem";
            this.sendWindowToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sendWindowToolStripMenuItem.Text = "&Send Window";
            this.sendWindowToolStripMenuItem.Click += new System.EventHandler(this.sendWindowToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtNumPackets
            // 
            this.txtNumPackets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtNumPackets.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPackets.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtNumPackets.Location = new System.Drawing.Point(843, 43);
            this.txtNumPackets.Name = "txtNumPackets";
            this.txtNumPackets.Size = new System.Drawing.Size(117, 21);
            this.txtNumPackets.TabIndex = 4;
            this.txtNumPackets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGUID
            // 
            this.txtGUID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtGUID.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGUID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtGUID.Location = new System.Drawing.Point(1073, 41);
            this.txtGUID.Name = "txtGUID";
            this.txtGUID.Size = new System.Drawing.Size(403, 21);
            this.txtGUID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(372, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "% of Packets";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(123, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Source IP Addresses";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SourceIPListView
            // 
            this.SourceIPListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SourceIPListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SrcIPAddress,
            this.IPNumCol});
            this.SourceIPListView.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceIPListView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SourceIPListView.FullRowSelect = true;
            this.SourceIPListView.Location = new System.Drawing.Point(12, 528);
            this.SourceIPListView.Name = "SourceIPListView";
            this.SourceIPListView.Size = new System.Drawing.Size(445, 212);
            this.SourceIPListView.TabIndex = 21;
            this.SourceIPListView.TileSize = new System.Drawing.Size(10, 10);
            this.SourceIPListView.UseCompatibleStateImageBehavior = false;
            this.SourceIPListView.View = System.Windows.Forms.View.Details;
            this.SourceIPListView.SelectedIndexChanged += new System.EventHandler(this.SourceIPListView_SelectedIndexChanged);
            // 
            // SrcIPAddress
            // 
            this.SrcIPAddress.Text = "IP Address";
            this.SrcIPAddress.Width = 263;
            // 
            // IPNumCol
            // 
            this.IPNumCol.Text = "Number Of Packets";
            this.IPNumCol.Width = 116;
            // 
            // DestIPListView
            // 
            this.DestIPListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.DestIPListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.DestIPListView.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestIPListView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DestIPListView.FullRowSelect = true;
            this.DestIPListView.Location = new System.Drawing.Point(467, 528);
            this.DestIPListView.Name = "DestIPListView";
            this.DestIPListView.Size = new System.Drawing.Size(445, 212);
            this.DestIPListView.TabIndex = 23;
            this.DestIPListView.TileSize = new System.Drawing.Size(10, 10);
            this.DestIPListView.UseCompatibleStateImageBehavior = false;
            this.DestIPListView.View = System.Windows.Forms.View.Details;
            this.DestIPListView.SelectedIndexChanged += new System.EventHandler(this.DestIPListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 290;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number Of Packets";
            this.columnHeader2.Width = 116;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(571, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Destination IP Addresses";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(705, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total Number of Packets";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoUpdateCB
            // 
            this.autoUpdateCB.AutoSize = true;
            this.autoUpdateCB.Checked = true;
            this.autoUpdateCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoUpdateCB.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoUpdateCB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.autoUpdateCB.Location = new System.Drawing.Point(452, 45);
            this.autoUpdateCB.Name = "autoUpdateCB";
            this.autoUpdateCB.Size = new System.Drawing.Size(86, 17);
            this.autoUpdateCB.TabIndex = 25;
            this.autoUpdateCB.Text = "Auto Update";
            this.autoUpdateCB.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.updateButton.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.updateButton.Location = new System.Drawing.Point(544, 41);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 26;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cmdResponseBox
            // 
            this.cmdResponseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cmdResponseBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cmdResponseBox.Location = new System.Drawing.Point(918, 534);
            this.cmdResponseBox.Multiline = true;
            this.cmdResponseBox.Name = "cmdResponseBox";
            this.cmdResponseBox.ReadOnly = true;
            this.cmdResponseBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cmdResponseBox.Size = new System.Drawing.Size(558, 205);
            this.cmdResponseBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(929, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Selected IP Address:";
            // 
            // selectedIPLabel
            // 
            this.selectedIPLabel.AutoSize = true;
            this.selectedIPLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIPLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.selectedIPLabel.Location = new System.Drawing.Point(1093, 504);
            this.selectedIPLabel.Name = "selectedIPLabel";
            this.selectedIPLabel.Size = new System.Drawing.Size(45, 16);
            this.selectedIPLabel.TabIndex = 29;
            this.selectedIPLabel.Text = "0.0.0.0";
            this.selectedIPLabel.Click += new System.EventHandler(this.selectedIPLabel_Click);
            // 
            // PingButton
            // 
            this.PingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.PingButton.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PingButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PingButton.Location = new System.Drawing.Point(1401, 501);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(75, 23);
            this.PingButton.TabIndex = 30;
            this.PingButton.Text = "IP Info";
            this.PingButton.UseVisualStyleBackColor = false;
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // PacketListView
            // 
            this.PacketListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.PacketListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PNUM,
            this.SMAC,
            this.DMAC,
            this.SIP,
            this.DIP,
            this.SPORT,
            this.DPORT,
            this.PROTOCOl,
            this.SIZE});
            this.PacketListView.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacketListView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PacketListView.FullRowSelect = true;
            this.PacketListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PacketListView.HideSelection = false;
            this.PacketListView.Location = new System.Drawing.Point(12, 70);
            this.PacketListView.MultiSelect = false;
            this.PacketListView.Name = "PacketListView";
            this.PacketListView.Size = new System.Drawing.Size(1464, 248);
            this.PacketListView.TabIndex = 31;
            this.PacketListView.UseCompatibleStateImageBehavior = false;
            this.PacketListView.View = System.Windows.Forms.View.Details;
            this.PacketListView.SelectedIndexChanged += new System.EventHandler(this.PacketListView_SelectedIndexChanged);
            // 
            // PNUM
            // 
            this.PNUM.Text = "Packet Number";
            this.PNUM.Width = 100;
            // 
            // SMAC
            // 
            this.SMAC.Text = "Source MAC";
            this.SMAC.Width = 150;
            // 
            // DMAC
            // 
            this.DMAC.Text = "Destination MAC";
            this.DMAC.Width = 150;
            // 
            // SIP
            // 
            this.SIP.Text = "Source IP";
            this.SIP.Width = 150;
            // 
            // DIP
            // 
            this.DIP.Text = "Destination IP";
            this.DIP.Width = 150;
            // 
            // PROTOCOl
            // 
            this.PROTOCOl.Text = "Protocol";
            this.PROTOCOl.Width = 100;
            // 
            // SIZE
            // 
            this.SIZE.Text = "Size";
            this.SIZE.Width = 100;
            // 
            // rawTextBox
            // 
            this.rawTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.rawTextBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rawTextBox.Location = new System.Drawing.Point(12, 324);
            this.rawTextBox.Multiline = true;
            this.rawTextBox.Name = "rawTextBox";
            this.rawTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawTextBox.Size = new System.Drawing.Size(900, 173);
            this.rawTextBox.TabIndex = 32;
            // 
            // SPORT
            // 
            this.SPORT.Text = "Source Port";
            this.SPORT.Width = 100;
            // 
            // DPORT
            // 
            this.DPORT.Text = "Destination Port";
            this.DPORT.Width = 100;
            // 
            // udpNum
            // 
            this.udpNum.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.udpNum.Location = new System.Drawing.Point(185, 108);
            this.udpNum.Name = "udpNum";
            this.udpNum.Size = new System.Drawing.Size(186, 36);
            this.udpNum.TabIndex = 14;
            this.udpNum.Text = "0";
            this.udpNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.udpNum.Click += new System.EventHandler(this.tcpNum_Click);
            // 
            // udpPerc
            // 
            this.udpPerc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpPerc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.udpPerc.Location = new System.Drawing.Point(372, 108);
            this.udpPerc.Name = "udpPerc";
            this.udpPerc.Size = new System.Drawing.Size(186, 36);
            this.udpPerc.TabIndex = 18;
            this.udpPerc.Text = "0";
            this.udpPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcpPerc
            // 
            this.tcpPerc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcpPerc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tcpPerc.Location = new System.Drawing.Point(372, 71);
            this.tcpPerc.Name = "tcpPerc";
            this.tcpPerc.Size = new System.Drawing.Size(186, 36);
            this.tcpPerc.TabIndex = 17;
            this.tcpPerc.Text = "0";
            this.tcpPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arpPerc
            // 
            this.arpPerc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arpPerc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.arpPerc.Location = new System.Drawing.Point(372, 36);
            this.arpPerc.Name = "arpPerc";
            this.arpPerc.Size = new System.Drawing.Size(186, 36);
            this.arpPerc.TabIndex = 16;
            this.arpPerc.Text = "0";
            this.arpPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcpNum
            // 
            this.tcpNum.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcpNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tcpNum.Location = new System.Drawing.Point(185, 71);
            this.tcpNum.Name = "tcpNum";
            this.tcpNum.Size = new System.Drawing.Size(186, 36);
            this.tcpNum.TabIndex = 15;
            this.tcpNum.Text = "0";
            this.tcpNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arpNum
            // 
            this.arpNum.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arpNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.arpNum.Location = new System.Drawing.Point(185, 35);
            this.arpNum.Name = "arpNum";
            this.arpNum.Size = new System.Drawing.Size(186, 36);
            this.arpNum.TabIndex = 13;
            this.arpNum.Text = "0";
            this.arpNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(0, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "UDP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(0, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "TCP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(0, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "ARP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(185, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of Packets";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Protocol";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tcpPerc, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.arpPerc, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tcpNum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.udpNum, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.arpNum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.udpPerc, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(918, 324);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 144);
            this.tableLayoutPanel1.TabIndex = 33;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // frmCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1490, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.rawTextBox);
            this.Controls.Add(this.PacketListView);
            this.Controls.Add(this.PingButton);
            this.Controls.Add(this.selectedIPLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdResponseBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.autoUpdateCB);
            this.Controls.Add(this.DestIPListView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SourceIPListView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumPackets);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGUID);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCapture";
            this.Text = "PacketCapture";
            this.Load += new System.EventHandler(this.frmCapture_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtNumPackets;
        private System.Windows.Forms.ToolStripMenuItem packetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendWindowToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGUID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView SourceIPListView;
        private System.Windows.Forms.ColumnHeader SrcIPAddress;
        private System.Windows.Forms.ColumnHeader IPNumCol;
        private System.Windows.Forms.ListView DestIPListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox autoUpdateCB;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox cmdResponseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedIPLabel;
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.ListView PacketListView;
        private System.Windows.Forms.ColumnHeader PNUM;
        private System.Windows.Forms.ColumnHeader SMAC;
        private System.Windows.Forms.ColumnHeader DMAC;
        private System.Windows.Forms.ColumnHeader SIP;
        private System.Windows.Forms.ColumnHeader DIP;
        private System.Windows.Forms.ColumnHeader PROTOCOl;
        private System.Windows.Forms.ColumnHeader SIZE;
        private System.Windows.Forms.TextBox rawTextBox;
        private System.Windows.Forms.ColumnHeader SPORT;
        private System.Windows.Forms.ColumnHeader DPORT;
        private System.Windows.Forms.Label udpNum;
        private System.Windows.Forms.Label udpPerc;
        private System.Windows.Forms.Label tcpPerc;
        private System.Windows.Forms.Label arpPerc;
        private System.Windows.Forms.Label tcpNum;
        private System.Windows.Forms.Label arpNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

