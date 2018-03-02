namespace SnmpClient
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.OIDTextBox = new System.Windows.Forms.TextBox();
            this.OperationsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MonitorTextBox = new System.Windows.Forms.TextBox();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBoxNotify = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.SourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenericColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startReciverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopReciverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapSenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBoxTSAddress = new System.Windows.Forms.TextBox();
            this.textBoxTSPort = new System.Windows.Forms.TextBox();
            this.textBoxTSCommunity = new System.Windows.Forms.TextBox();
            this.textBoxTSName = new System.Windows.Forms.TextBox();
            this.textBoxTSValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTSGeneric = new System.Windows.Forms.ComboBox();
            this.buttonTSSend = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.23077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.goButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddressTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OIDTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.OperationsComboBox, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 31);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(683, 3);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(41, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(59, 3);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(117, 20);
            this.AddressTextBox.TabIndex = 2;
            // 
            // OIDTextBox
            // 
            this.OIDTextBox.Location = new System.Drawing.Point(261, 3);
            this.OIDTextBox.Name = "OIDTextBox";
            this.OIDTextBox.Size = new System.Drawing.Size(169, 20);
            this.OIDTextBox.TabIndex = 3;
            // 
            // OperationsComboBox
            // 
            this.OperationsComboBox.FormattingEnabled = true;
            this.OperationsComboBox.Location = new System.Drawing.Point(534, 3);
            this.OperationsComboBox.Name = "OperationsComboBox";
            this.OperationsComboBox.Size = new System.Drawing.Size(129, 21);
            this.OperationsComboBox.TabIndex = 4;
            this.OperationsComboBox.SelectedIndexChanged += new System.EventHandler(this.OperationsComboBox_SelectedIndexChanged);
            this.OperationsComboBox.StyleChanged += new System.EventHandler(this.OperationsComboBox_StyleChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "OID:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operation";
            // 
            // treeView
            // 
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(19, 87);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(208, 341);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(233, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(525, 363);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(517, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Result Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 325);
            this.dataGridView1.TabIndex = 0;
            
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name/OID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 120F;
            this.Column2.HeaderText = "Value";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 120F;
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 120F;
            this.Column4.HeaderText = "IP:Port";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(517, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Table View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(508, 325);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MonitorTextBox);
            this.tabPage3.Controls.Add(this.ChooseButton);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(517, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Monitor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MonitorTextBox
            // 
            this.MonitorTextBox.Location = new System.Drawing.Point(103, 9);
            this.MonitorTextBox.Name = "MonitorTextBox";
            this.MonitorTextBox.Size = new System.Drawing.Size(184, 20);
            this.MonitorTextBox.TabIndex = 2;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(7, 7);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseButton.TabIndex = 1;
            this.ChooseButton.Text = "Choose";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(511, 298);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.richTextBoxNotify);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(517, 337);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "AgentNotify";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBoxNotify
            // 
            this.richTextBoxNotify.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxNotify.Name = "richTextBoxNotify";
            this.richTextBoxNotify.Size = new System.Drawing.Size(508, 325);
            this.richTextBoxNotify.TabIndex = 0;
            this.richTextBoxNotify.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(68, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SNMP MIBs";
            // 
            // buttonClear
            // 
            this.buttonClear.Image = global::SnmpClient.Properties.Resources.clear;
            this.buttonClear.Location = new System.Drawing.Point(765, 93);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(32, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SourceColumn,
            this.NameColumn,
            this.ValueColumn,
            this.TimeColumn,
            this.GenericColumn});
            this.dataGridView3.Location = new System.Drawing.Point(5, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(509, 328);
            this.dataGridView3.TabIndex = 1;
            // 
            // SourceColumn
            // 
            this.SourceColumn.HeaderText = "Source";
            this.SourceColumn.Name = "SourceColumn";
            this.SourceColumn.ReadOnly = true;
            this.SourceColumn.Width = 120;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 120;
            // 
            // ValueColumn
            // 
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            this.ValueColumn.Width = 120;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            this.TimeColumn.Width = 120;
            // 
            // GenericColumn
            // 
            this.GenericColumn.HeaderText = "Generic";
            this.GenericColumn.Name = "GenericColumn";
            this.GenericColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startReciverToolStripMenuItem,
            this.stopReciverToolStripMenuItem,
            this.trapSenderToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // startReciverToolStripMenuItem
            // 
            this.startReciverToolStripMenuItem.Name = "startReciverToolStripMenuItem";
            this.startReciverToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startReciverToolStripMenuItem.Text = "StartReciver";
            this.startReciverToolStripMenuItem.Click += new System.EventHandler(this.startReciverToolStripMenuItem_Click);
            // 
            // stopReciverToolStripMenuItem
            // 
            this.stopReciverToolStripMenuItem.Name = "stopReciverToolStripMenuItem";
            this.stopReciverToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopReciverToolStripMenuItem.Text = "StopReciver";
            this.stopReciverToolStripMenuItem.Click += new System.EventHandler(this.stopReciverToolStripMenuItem_Click);
            // 
            // trapSenderToolStripMenuItem
            // 
            this.trapSenderToolStripMenuItem.Name = "trapSenderToolStripMenuItem";
            this.trapSenderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trapSenderToolStripMenuItem.Text = "TrapSender";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonTSSend);
            this.tabPage5.Controls.Add(this.comboBoxTSGeneric);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.textBoxTSValue);
            this.tabPage5.Controls.Add(this.textBoxTSName);
            this.tabPage5.Controls.Add(this.textBoxTSCommunity);
            this.tabPage5.Controls.Add(this.textBoxTSPort);
            this.tabPage5.Controls.Add(this.textBoxTSAddress);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(517, 337);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "TrapSender";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBoxTSAddress
            // 
            this.textBoxTSAddress.Location = new System.Drawing.Point(105, 31);
            this.textBoxTSAddress.Name = "textBoxTSAddress";
            this.textBoxTSAddress.Size = new System.Drawing.Size(121, 20);
            this.textBoxTSAddress.TabIndex = 0;
            // 
            // textBoxTSPort
            // 
            this.textBoxTSPort.Location = new System.Drawing.Point(105, 75);
            this.textBoxTSPort.Name = "textBoxTSPort";
            this.textBoxTSPort.Size = new System.Drawing.Size(121, 20);
            this.textBoxTSPort.TabIndex = 1;
            // 
            // textBoxTSCommunity
            // 
            this.textBoxTSCommunity.Location = new System.Drawing.Point(105, 121);
            this.textBoxTSCommunity.Name = "textBoxTSCommunity";
            this.textBoxTSCommunity.Size = new System.Drawing.Size(121, 20);
            this.textBoxTSCommunity.TabIndex = 2;
            // 
            // textBoxTSName
            // 
            this.textBoxTSName.Location = new System.Drawing.Point(105, 214);
            this.textBoxTSName.Name = "textBoxTSName";
            this.textBoxTSName.Size = new System.Drawing.Size(121, 20);
            this.textBoxTSName.TabIndex = 4;
            // 
            // textBoxTSValue
            // 
            this.textBoxTSValue.Location = new System.Drawing.Point(105, 264);
            this.textBoxTSValue.Name = "textBoxTSValue";
            this.textBoxTSValue.Size = new System.Drawing.Size(121, 20);
            this.textBoxTSValue.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "IPAddress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Community";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Generic";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Value";
            // 
            // comboBoxTSGeneric
            // 
            this.comboBoxTSGeneric.FormattingEnabled = true;
            this.comboBoxTSGeneric.Location = new System.Drawing.Point(105, 167);
            this.comboBoxTSGeneric.Name = "comboBoxTSGeneric";
            this.comboBoxTSGeneric.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTSGeneric.TabIndex = 12;
            // 
            // buttonTSSend
            // 
            this.buttonTSSend.Location = new System.Drawing.Point(362, 264);
            this.buttonTSSend.Name = "buttonTSSend";
            this.buttonTSSend.Size = new System.Drawing.Size(75, 23);
            this.buttonTSSend.TabIndex = 13;
            this.buttonTSSend.Text = "Send";
            this.buttonTSSend.UseVisualStyleBackColor = true;
            this.buttonTSSend.Click += new System.EventHandler(this.buttonTSSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 433);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox OIDTextBox;
        private System.Windows.Forms.ComboBox OperationsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox MonitorTextBox;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox richTextBoxNotify;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenericColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startReciverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopReciverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapSenderToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonTSSend;
        private System.Windows.Forms.ComboBox comboBoxTSGeneric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTSValue;
        private System.Windows.Forms.TextBox textBoxTSName;
        private System.Windows.Forms.TextBox textBoxTSCommunity;
        private System.Windows.Forms.TextBox textBoxTSPort;
        private System.Windows.Forms.TextBox textBoxTSAddress;
    }
}

