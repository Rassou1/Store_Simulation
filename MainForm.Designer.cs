namespace Assignment3_Form
{
    partial class MainForm
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
            this.producerGroupBox = new System.Windows.Forms.GroupBox();
            this.electronicsInc = new System.Windows.Forms.GroupBox();
            this.btnStopElectronicsInc = new System.Windows.Forms.Button();
            this.btnStartElectronicsInc = new System.Windows.Forms.Button();
            this.lblStatusElectronicsInc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grandBakery = new System.Windows.Forms.GroupBox();
            this.btnStopGrandBakery = new System.Windows.Forms.Button();
            this.btnStartGrandBakery = new System.Windows.Forms.Button();
            this.lblStatusGrandBakery = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.freshProduce = new System.Windows.Forms.GroupBox();
            this.btnStopFreshProduce = new System.Windows.Forms.Button();
            this.btnStartFreshProduce = new System.Windows.Forms.Button();
            this.lblStatusScan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.consumerGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxWillys = new System.Windows.Forms.GroupBox();
            this.lblItems3 = new System.Windows.Forms.Label();
            this.WillysTextBox = new System.Windows.Forms.ListBox();
            this.btnStopWillys = new System.Windows.Forms.Button();
            this.btnStartWillys = new System.Windows.Forms.Button();
            this.WillysCheckbox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblWillysStatus = new System.Windows.Forms.Label();
            this.groupBoxCarrefour = new System.Windows.Forms.GroupBox();
            this.lblItems2 = new System.Windows.Forms.Label();
            this.CarrefourTextBox = new System.Windows.Forms.ListBox();
            this.btnStopCarrefour = new System.Windows.Forms.Button();
            this.btnStartCarrefour = new System.Windows.Forms.Button();
            this.CarrefourCheckbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCarrefourStatus = new System.Windows.Forms.Label();
            this.groupBoxIca = new System.Windows.Forms.GroupBox();
            this.lblItems1 = new System.Windows.Forms.Label();
            this.IcaTextBox = new System.Windows.Forms.ListBox();
            this.btnStopIca = new System.Windows.Forms.Button();
            this.btnStartIca = new System.Windows.Forms.Button();
            this.IcaCheckbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIcaStatus = new System.Windows.Forms.Label();
            this.groupBoxStorage = new System.Windows.Forms.GroupBox();
            this.lblItemsProduced = new System.Windows.Forms.Label();
            this.progressItems = new System.Windows.Forms.ProgressBar();
            this.lblMax = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.producerGroupBox.SuspendLayout();
            this.electronicsInc.SuspendLayout();
            this.grandBakery.SuspendLayout();
            this.freshProduce.SuspendLayout();
            this.consumerGroupBox.SuspendLayout();
            this.groupBoxWillys.SuspendLayout();
            this.groupBoxCarrefour.SuspendLayout();
            this.groupBoxIca.SuspendLayout();
            this.groupBoxStorage.SuspendLayout();
            this.SuspendLayout();

            // 
            // producerGroupBox
            // 
            this.producerGroupBox.Controls.Add(this.electronicsInc);
            this.producerGroupBox.Controls.Add(this.grandBakery);
            this.producerGroupBox.Controls.Add(this.freshProduce);
            this.producerGroupBox.Location = new System.Drawing.Point(17, 16);
            this.producerGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.producerGroupBox.Name = "producerGroupBox";
            this.producerGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.producerGroupBox.Size = new System.Drawing.Size(305, 465);
            this.producerGroupBox.TabIndex = 0;
            this.producerGroupBox.TabStop = false;
            this.producerGroupBox.Text = "Producers";
            // 
            // electronicsInc
            // 
            this.electronicsInc.Controls.Add(this.btnStopElectronicsInc);
            this.electronicsInc.Controls.Add(this.btnStartElectronicsInc);
            this.electronicsInc.Controls.Add(this.lblStatusElectronicsInc);
            this.electronicsInc.Controls.Add(this.label7);
            this.electronicsInc.Location = new System.Drawing.Point(8, 321);
            this.electronicsInc.Margin = new System.Windows.Forms.Padding(4);
            this.electronicsInc.Name = "electronicsInc";
            this.electronicsInc.Padding = new System.Windows.Forms.Padding(4);
            this.electronicsInc.Size = new System.Drawing.Size(289, 123);
            this.electronicsInc.TabIndex = 2;
            this.electronicsInc.TabStop = false;
            this.electronicsInc.Text = "Electronics Inc.";
            this.electronicsInc.Enter += new System.EventHandler(this.electronicsInc_Enter);
            // 
            // btnStopElectronicsInc
            // 
            this.btnStopElectronicsInc.Enabled = false;
            this.btnStopElectronicsInc.Location = new System.Drawing.Point(199, 71);
            this.btnStopElectronicsInc.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopElectronicsInc.Name = "btnStopElectronicsInc";
            this.btnStopElectronicsInc.Size = new System.Drawing.Size(64, 28);
            this.btnStopElectronicsInc.TabIndex = 3;
            this.btnStopElectronicsInc.Text = "Stop";
            this.btnStopElectronicsInc.UseVisualStyleBackColor = true;
            this.btnStopElectronicsInc.Click += new System.EventHandler(this.btnStopElectronicsInc_Click);
            // 
            // btnStartElectronicsInc
            // 
            this.btnStartElectronicsInc.Location = new System.Drawing.Point(39, 73);
            this.btnStartElectronicsInc.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartElectronicsInc.Name = "btnStartElectronicsInc";
            this.btnStartElectronicsInc.Size = new System.Drawing.Size(132, 28);
            this.btnStartElectronicsInc.TabIndex = 2;
            this.btnStartElectronicsInc.Text = "Start Producing";
            this.btnStartElectronicsInc.UseVisualStyleBackColor = true;
            this.btnStartElectronicsInc.Click += new System.EventHandler(this.btnStartElectronicsInc_Click);
            // 
            // lblStatusElectronicsInc
            // 
            this.lblStatusElectronicsInc.AutoSize = true;
            this.lblStatusElectronicsInc.Location = new System.Drawing.Point(107, 38);
            this.lblStatusElectronicsInc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusElectronicsInc.Name = "lblStatusElectronicsInc";
            this.lblStatusElectronicsInc.Size = new System.Drawing.Size(120, 16);
            this.lblStatusElectronicsInc.TabIndex = 1;
            this.lblStatusElectronicsInc.Text = "NOT PRODUCING";
            this.lblStatusElectronicsInc.Click += new System.EventHandler(this.lblStatusElectronicsInc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // grandBakery
            // 
            this.grandBakery.Controls.Add(this.btnStopGrandBakery);
            this.grandBakery.Controls.Add(this.btnStartGrandBakery);
            this.grandBakery.Controls.Add(this.lblStatusGrandBakery);
            this.grandBakery.Controls.Add(this.label5);
            this.grandBakery.Location = new System.Drawing.Point(8, 171);
            this.grandBakery.Margin = new System.Windows.Forms.Padding(4);
            this.grandBakery.Name = "grandBakery";
            this.grandBakery.Padding = new System.Windows.Forms.Padding(4);
            this.grandBakery.Size = new System.Drawing.Size(289, 123);
            this.grandBakery.TabIndex = 1;
            this.grandBakery.TabStop = false;
            this.grandBakery.Text = "Grand Bakery";
            // 
            // btnStopGrandBakery
            // 
            this.btnStopGrandBakery.Enabled = false;
            this.btnStopGrandBakery.Location = new System.Drawing.Point(199, 71);
            this.btnStopGrandBakery.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopGrandBakery.Name = "btnStopGrandBakery";
            this.btnStopGrandBakery.Size = new System.Drawing.Size(64, 28);
            this.btnStopGrandBakery.TabIndex = 3;
            this.btnStopGrandBakery.Text = "Stop";
            this.btnStopGrandBakery.UseVisualStyleBackColor = true;
            this.btnStopGrandBakery.Click += new System.EventHandler(this.btnStopGrandBakery_Click);
            // 
            // btnStartGrandBakery
            // 
            this.btnStartGrandBakery.Location = new System.Drawing.Point(39, 73);
            this.btnStartGrandBakery.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartGrandBakery.Name = "btnStartGrandBakery";
            this.btnStartGrandBakery.Size = new System.Drawing.Size(132, 28);
            this.btnStartGrandBakery.TabIndex = 2;
            this.btnStartGrandBakery.Text = "Start Producing";
            this.btnStartGrandBakery.UseVisualStyleBackColor = true;
            this.btnStartGrandBakery.Click += new System.EventHandler(this.btnStartGrandBakery_Click);
            // 
            // lblStatusGrandBakery
            // 
            this.lblStatusGrandBakery.AutoSize = true;
            this.lblStatusGrandBakery.Location = new System.Drawing.Point(107, 38);
            this.lblStatusGrandBakery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusGrandBakery.Name = "lblStatusGrandBakery";
            this.lblStatusGrandBakery.Size = new System.Drawing.Size(120, 16);
            this.lblStatusGrandBakery.TabIndex = 1;
            this.lblStatusGrandBakery.Text = "NOT PRODUCING";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // freshProduce
            // 
            this.freshProduce.Controls.Add(this.btnStopFreshProduce);
            this.freshProduce.Controls.Add(this.btnStartFreshProduce);
            this.freshProduce.Controls.Add(this.lblStatusScan);
            this.freshProduce.Controls.Add(this.label2);
            this.freshProduce.Location = new System.Drawing.Point(8, 23);
            this.freshProduce.Margin = new System.Windows.Forms.Padding(4);
            this.freshProduce.Name = "freshProduce";
            this.freshProduce.Padding = new System.Windows.Forms.Padding(4);
            this.freshProduce.Size = new System.Drawing.Size(289, 123);
            this.freshProduce.TabIndex = 0;
            this.freshProduce.TabStop = false;
            this.freshProduce.Text = "Fresh Produce";
            // 
            // btnStopFreshProduce
            // 
            this.btnStopFreshProduce.Enabled = false;
            this.btnStopFreshProduce.Location = new System.Drawing.Point(199, 71);
            this.btnStopFreshProduce.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopFreshProduce.Name = "btnStopFreshProduce";
            this.btnStopFreshProduce.Size = new System.Drawing.Size(64, 28);
            this.btnStopFreshProduce.TabIndex = 3;
            this.btnStopFreshProduce.Text = "Stop";
            this.btnStopFreshProduce.UseVisualStyleBackColor = true;
            this.btnStopFreshProduce.Click += new System.EventHandler(this.btnStopFreshProduce_Click);
            // 
            // btnStartFreshProduce
            // 
            this.btnStartFreshProduce.Location = new System.Drawing.Point(39, 73);
            this.btnStartFreshProduce.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartFreshProduce.Name = "btnStartFreshProduce";
            this.btnStartFreshProduce.Size = new System.Drawing.Size(132, 28);
            this.btnStartFreshProduce.TabIndex = 2;
            this.btnStartFreshProduce.Text = "Start Producing";
            this.btnStartFreshProduce.UseVisualStyleBackColor = true;
            this.btnStartFreshProduce.Click += new System.EventHandler(this.btnStartFreshProduce_Click);
            // 
            // lblStatusScan
            // 
            this.lblStatusScan.AutoSize = true;
            this.lblStatusScan.Location = new System.Drawing.Point(107, 38);
            this.lblStatusScan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusScan.Name = "lblStatusScan";
            this.lblStatusScan.Size = new System.Drawing.Size(120, 16);
            this.lblStatusScan.TabIndex = 1;
            this.lblStatusScan.Text = "NOT PRODUCING";
            this.lblStatusScan.Click += new System.EventHandler(this.lblStatusScan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // consumerGroupBox
            // 
            this.consumerGroupBox.Controls.Add(this.groupBoxWillys);
            this.consumerGroupBox.Controls.Add(this.groupBoxCarrefour);
            this.consumerGroupBox.Controls.Add(this.groupBoxIca);
            this.consumerGroupBox.Location = new System.Drawing.Point(355, 16);
            this.consumerGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.consumerGroupBox.Name = "consumerGroupBox";
            this.consumerGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.consumerGroupBox.Size = new System.Drawing.Size(547, 465);
            this.consumerGroupBox.TabIndex = 1;
            this.consumerGroupBox.TabStop = false;
            this.consumerGroupBox.Text = "Consumers";
            this.consumerGroupBox.Enter += new System.EventHandler(this.consumerGroupBox_Enter);
            // 
            // groupBoxWillys
            // 
            this.groupBoxWillys.Controls.Add(this.lblItems3);
            this.groupBoxWillys.Controls.Add(this.WillysTextBox);
            this.groupBoxWillys.Controls.Add(this.btnStopWillys);
            this.groupBoxWillys.Controls.Add(this.btnStartWillys);
            this.groupBoxWillys.Controls.Add(this.WillysCheckbox);
            this.groupBoxWillys.Controls.Add(this.label16);
            this.groupBoxWillys.Controls.Add(this.lblWillysStatus);
            this.groupBoxWillys.Location = new System.Drawing.Point(25, 321);
            this.groupBoxWillys.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxWillys.Name = "groupBoxWillys";
            this.groupBoxWillys.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxWillys.Size = new System.Drawing.Size(513, 123);
            this.groupBoxWillys.TabIndex = 2;
            this.groupBoxWillys.TabStop = false;
            this.groupBoxWillys.Text = "Willys";
            this.groupBoxWillys.Enter += new System.EventHandler(this.groupBoxWillys_Enter);
            // 
            // lblItems3
            // 
            this.lblItems3.AutoSize = true;
            this.lblItems3.Location = new System.Drawing.Point(161, 57);
            this.lblItems3.Name = "lblItems3";
            this.lblItems3.Size = new System.Drawing.Size(39, 16);
            this.lblItems3.TabIndex = 10;
            this.lblItems3.Text = "items";
            this.lblItems3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WillysTextBox
            // 
            this.WillysTextBox.FormattingEnabled = true;
            this.WillysTextBox.ItemHeight = 16;
            this.WillysTextBox.Location = new System.Drawing.Point(208, 28);
            this.WillysTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WillysTextBox.Name = "WillysTextBox";
            this.WillysTextBox.Size = new System.Drawing.Size(297, 84);
            this.WillysTextBox.TabIndex = 8;
            // 
            // btnStopWillys
            // 
            this.btnStopWillys.Enabled = false;
            this.btnStopWillys.Location = new System.Drawing.Point(148, 87);
            this.btnStopWillys.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopWillys.Name = "btnStopWillys";
            this.btnStopWillys.Size = new System.Drawing.Size(53, 28);
            this.btnStopWillys.TabIndex = 7;
            this.btnStopWillys.Text = "Stop";
            this.btnStopWillys.UseVisualStyleBackColor = true;
            this.btnStopWillys.Click += new System.EventHandler(this.btnStopWillys_Click);
            // 
            // btnStartWillys
            // 
            this.btnStartWillys.Location = new System.Drawing.Point(9, 87);
            this.btnStartWillys.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartWillys.Name = "btnStartWillys";
            this.btnStartWillys.Size = new System.Drawing.Size(108, 28);
            this.btnStartWillys.TabIndex = 6;
            this.btnStartWillys.Text = "Start Loading";
            this.btnStartWillys.UseVisualStyleBackColor = true;
            this.btnStartWillys.Click += new System.EventHandler(this.btnStartWillys_Click);
            // 
            // WillysCheckbox
            // 
            this.WillysCheckbox.AutoSize = true;
            this.WillysCheckbox.Location = new System.Drawing.Point(9, 57);
            this.WillysCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.WillysCheckbox.Name = "WillysCheckbox";
            this.WillysCheckbox.Size = new System.Drawing.Size(111, 20);
            this.WillysCheckbox.TabIndex = 5;
            this.WillysCheckbox.Text = "Continue load";
            this.WillysCheckbox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-1, 28);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Status:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // lblWillysStatus
            // 
            this.lblWillysStatus.AutoSize = true;
            this.lblWillysStatus.Location = new System.Drawing.Point(48, 28);
            this.lblWillysStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWillysStatus.Name = "lblWillysStatus";
            this.lblWillysStatus.Size = new System.Drawing.Size(121, 16);
            this.lblWillysStatus.TabIndex = 3;
            this.lblWillysStatus.Text = "NOT CONSUMING";
            // 
            // groupBoxCarrefour
            // 
            this.groupBoxCarrefour.Controls.Add(this.lblItems2);
            this.groupBoxCarrefour.Controls.Add(this.CarrefourTextBox);
            this.groupBoxCarrefour.Controls.Add(this.btnStopCarrefour);
            this.groupBoxCarrefour.Controls.Add(this.btnStartCarrefour);
            this.groupBoxCarrefour.Controls.Add(this.CarrefourCheckbox);
            this.groupBoxCarrefour.Controls.Add(this.label8);
            this.groupBoxCarrefour.Controls.Add(this.lblCarrefourStatus);
            this.groupBoxCarrefour.Location = new System.Drawing.Point(25, 171);
            this.groupBoxCarrefour.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCarrefour.Name = "groupBoxCarrefour";
            this.groupBoxCarrefour.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCarrefour.Size = new System.Drawing.Size(513, 123);
            this.groupBoxCarrefour.TabIndex = 1;
            this.groupBoxCarrefour.TabStop = false;
            this.groupBoxCarrefour.Text = "Carrefour Market";
            this.groupBoxCarrefour.Enter += new System.EventHandler(this.groupBoxCarrefour_Enter);
            // 
            // lblItems2
            // 
            this.lblItems2.AutoSize = true;
            this.lblItems2.Location = new System.Drawing.Point(161, 57);
            this.lblItems2.Name = "lblItems2";
            this.lblItems2.Size = new System.Drawing.Size(39, 16);
            this.lblItems2.TabIndex = 10;
            this.lblItems2.Text = "items";
            this.lblItems2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarrefourTextBox
            // 
            this.CarrefourTextBox.FormattingEnabled = true;
            this.CarrefourTextBox.ItemHeight = 16;
            this.CarrefourTextBox.Location = new System.Drawing.Point(217, 28);
            this.CarrefourTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CarrefourTextBox.Name = "CarrefourTextBox";
            this.CarrefourTextBox.Size = new System.Drawing.Size(285, 84);
            this.CarrefourTextBox.TabIndex = 8;
            // 
            // btnStopCarrefour
            // 
            this.btnStopCarrefour.Enabled = false;
            this.btnStopCarrefour.Location = new System.Drawing.Point(148, 76);
            this.btnStopCarrefour.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopCarrefour.Name = "btnStopCarrefour";
            this.btnStopCarrefour.Size = new System.Drawing.Size(53, 28);
            this.btnStopCarrefour.TabIndex = 7;
            this.btnStopCarrefour.Text = "Stop";
            this.btnStopCarrefour.UseVisualStyleBackColor = true;
            this.btnStopCarrefour.Click += new System.EventHandler(this.btnStopCarrefour_Click);
            // 
            // btnStartCarrefour
            // 
            this.btnStartCarrefour.Location = new System.Drawing.Point(20, 87);
            this.btnStartCarrefour.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartCarrefour.Name = "btnStartCarrefour";
            this.btnStartCarrefour.Size = new System.Drawing.Size(108, 28);
            this.btnStartCarrefour.TabIndex = 6;
            this.btnStartCarrefour.Text = "Start Loading";
            this.btnStartCarrefour.UseVisualStyleBackColor = true;
            this.btnStartCarrefour.Click += new System.EventHandler(this.btnStartCarrefour_Click);
            // 
            // CarrefourCheckbox
            // 
            this.CarrefourCheckbox.AutoSize = true;
            this.CarrefourCheckbox.Location = new System.Drawing.Point(20, 57);
            this.CarrefourCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.CarrefourCheckbox.Name = "CarrefourCheckbox";
            this.CarrefourCheckbox.Size = new System.Drawing.Size(111, 20);
            this.CarrefourCheckbox.TabIndex = 5;
            this.CarrefourCheckbox.Text = "Continue load";
            this.CarrefourCheckbox.UseVisualStyleBackColor = true;
            this.CarrefourCheckbox.CheckedChanged += new System.EventHandler(this.CarrefourCheckbox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Status:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblCarrefourStatus
            // 
            this.lblCarrefourStatus.AutoSize = true;
            this.lblCarrefourStatus.Location = new System.Drawing.Point(57, 28);
            this.lblCarrefourStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrefourStatus.Name = "lblCarrefourStatus";
            this.lblCarrefourStatus.Size = new System.Drawing.Size(121, 16);
            this.lblCarrefourStatus.TabIndex = 3;
            this.lblCarrefourStatus.Text = "NOT CONSUMING";
            this.lblCarrefourStatus.Click += new System.EventHandler(this.lblCarrefourStatus_Click);
            // 
            // groupBoxIca
            // 
            this.groupBoxIca.Controls.Add(this.lblItems1);
            this.groupBoxIca.Controls.Add(this.IcaTextBox);
            this.groupBoxIca.Controls.Add(this.btnStopIca);
            this.groupBoxIca.Controls.Add(this.btnStartIca);
            this.groupBoxIca.Controls.Add(this.IcaCheckbox);
            this.groupBoxIca.Controls.Add(this.label6);
            this.groupBoxIca.Controls.Add(this.lblIcaStatus);
            this.groupBoxIca.Location = new System.Drawing.Point(25, 23);
            this.groupBoxIca.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIca.Name = "groupBoxIca";
            this.groupBoxIca.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIca.Size = new System.Drawing.Size(513, 123);
            this.groupBoxIca.TabIndex = 0;
            this.groupBoxIca.TabStop = false;
            this.groupBoxIca.Text = "Ica";
            this.groupBoxIca.Enter += new System.EventHandler(this.groupBoxIca_Enter);
            // 
            // lblItems1
            // 
            this.lblItems1.AutoSize = true;
            this.lblItems1.Location = new System.Drawing.Point(161, 47);
            this.lblItems1.Name = "lblItems1";
            this.lblItems1.Size = new System.Drawing.Size(39, 16);
            this.lblItems1.TabIndex = 9;
            this.lblItems1.Text = "items";
            this.lblItems1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IcaTextBox
            // 
            this.IcaTextBox.FormattingEnabled = true;
            this.IcaTextBox.ItemHeight = 16;
            this.IcaTextBox.Location = new System.Drawing.Point(217, 20);
            this.IcaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IcaTextBox.Name = "IcaTextBox";
            this.IcaTextBox.Size = new System.Drawing.Size(285, 84);
            this.IcaTextBox.TabIndex = 8;
            this.IcaTextBox.SelectedIndexChanged += new System.EventHandler(this.IcaTextBox_SelectedIndexChanged);
            // 
            // btnStopIca
            // 
            this.btnStopIca.Enabled = false;
            this.btnStopIca.Location = new System.Drawing.Point(148, 79);
            this.btnStopIca.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopIca.Name = "btnStopIca";
            this.btnStopIca.Size = new System.Drawing.Size(53, 28);
            this.btnStopIca.TabIndex = 7;
            this.btnStopIca.Text = "Stop";
            this.btnStopIca.UseVisualStyleBackColor = true;
            this.btnStopIca.Click += new System.EventHandler(this.btnStopIca_Click);
            // 
            // btnStartIca
            // 
            this.btnStartIca.Location = new System.Drawing.Point(20, 79);
            this.btnStartIca.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartIca.Name = "btnStartIca";
            this.btnStartIca.Size = new System.Drawing.Size(108, 28);
            this.btnStartIca.TabIndex = 6;
            this.btnStartIca.Text = "Start Loading";
            this.btnStartIca.UseVisualStyleBackColor = true;
            this.btnStartIca.Click += new System.EventHandler(this.btnStartIca_Click);
            // 
            // IcaCheckbox
            // 
            this.IcaCheckbox.AutoSize = true;
            this.IcaCheckbox.Location = new System.Drawing.Point(20, 47);
            this.IcaCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.IcaCheckbox.Name = "IcaCheckbox";
            this.IcaCheckbox.Size = new System.Drawing.Size(111, 20);
            this.IcaCheckbox.TabIndex = 5;
            this.IcaCheckbox.Text = "Continue load";
            this.IcaCheckbox.UseVisualStyleBackColor = true;
            this.IcaCheckbox.CheckedChanged += new System.EventHandler(this.IcaCheckbox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblIcaStatus
            // 
            this.lblIcaStatus.AutoSize = true;
            this.lblIcaStatus.Location = new System.Drawing.Point(57, 20);
            this.lblIcaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcaStatus.Name = "lblIcaStatus";
            this.lblIcaStatus.Size = new System.Drawing.Size(121, 16);
            this.lblIcaStatus.TabIndex = 3;
            this.lblIcaStatus.Text = "NOT CONSUMING";
            this.lblIcaStatus.Click += new System.EventHandler(this.lblIcaStatus_Click);
            // 
            // groupBoxStorage
            // 
            this.groupBoxStorage.Controls.Add(this.lblItemsProduced);
            this.groupBoxStorage.Controls.Add(this.progressItems);
            this.groupBoxStorage.Controls.Add(this.lblMax);
            this.groupBoxStorage.Location = new System.Drawing.Point(17, 490);
            this.groupBoxStorage.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStorage.Name = "groupBoxStorage";
            this.groupBoxStorage.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStorage.Size = new System.Drawing.Size(884, 101);
            this.groupBoxStorage.TabIndex = 2;
            this.groupBoxStorage.TabStop = false;
            this.groupBoxStorage.Text = "Storage";
            // 
            // lblItemsProduced
            // 
            this.lblItemsProduced.AutoSize = true;
            this.lblItemsProduced.Location = new System.Drawing.Point(793, 20);
            this.lblItemsProduced.Name = "lblItemsProduced";
            this.lblItemsProduced.Size = new System.Drawing.Size(67, 16);
            this.lblItemsProduced.TabIndex = 9;
            this.lblItemsProduced.Text = "Max items";
            this.lblItemsProduced.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressItems
            // 
            this.progressItems.ForeColor = System.Drawing.Color.Blue;
            this.progressItems.Location = new System.Drawing.Point(207, 47);
            this.progressItems.Margin = new System.Windows.Forms.Padding(4);
            this.progressItems.Maximum = 20;
            this.progressItems.Name = "progressItems";
            this.progressItems.Size = new System.Drawing.Size(653, 28);
            this.progressItems.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressItems.TabIndex = 2;
            this.progressItems.Click += new System.EventHandler(this.progressItems_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(8, 52);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(132, 16);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Max capacity (items):";
            //
            // startBtn
            //
            this.startBtn.Location = new System.Drawing.Point(12, 502);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(117, 74);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 599);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.groupBoxStorage);
            this.Controls.Add(this.consumerGroupBox);
            this.Controls.Add(this.producerGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Supply System";
            this.producerGroupBox.ResumeLayout(false);
            this.electronicsInc.ResumeLayout(false);
            this.electronicsInc.PerformLayout();
            this.grandBakery.ResumeLayout(false);
            this.grandBakery.PerformLayout();
            this.freshProduce.ResumeLayout(false);
            this.freshProduce.PerformLayout();
            this.consumerGroupBox.ResumeLayout(false);
            this.groupBoxWillys.ResumeLayout(false);
            this.groupBoxWillys.PerformLayout();
            this.groupBoxCarrefour.ResumeLayout(false);
            this.groupBoxCarrefour.PerformLayout();
            this.groupBoxIca.ResumeLayout(false);
            this.groupBoxIca.PerformLayout();
            this.groupBoxStorage.ResumeLayout(false);
            this.groupBoxStorage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.GroupBox producerGroupBox;
        private System.Windows.Forms.GroupBox consumerGroupBox;
        private System.Windows.Forms.GroupBox groupBoxStorage;
        private System.Windows.Forms.ProgressBar progressItems;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.GroupBox freshProduce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox electronicsInc;
        private System.Windows.Forms.Button btnStopElectronicsInc;
        private System.Windows.Forms.Button btnStartElectronicsInc;
        private System.Windows.Forms.Label lblStatusElectronicsInc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grandBakery;
        private System.Windows.Forms.Button btnStopGrandBakery;
        private System.Windows.Forms.Button btnStartGrandBakery;
        private System.Windows.Forms.Label lblStatusGrandBakery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStopFreshProduce;
        private System.Windows.Forms.Button btnStartFreshProduce;
        private System.Windows.Forms.Label lblStatusScan;
        private System.Windows.Forms.GroupBox groupBoxIca;
        private System.Windows.Forms.GroupBox groupBoxWillys;
        public System.Windows.Forms.ListBox WillysTextBox;
        private System.Windows.Forms.Button btnStopWillys;
        private System.Windows.Forms.Button btnStartWillys;
        public System.Windows.Forms.CheckBox WillysCheckbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblWillysStatus;
        private System.Windows.Forms.GroupBox groupBoxCarrefour;
        public System.Windows.Forms.ListBox CarrefourTextBox;
        private System.Windows.Forms.Button btnStopCarrefour;
        private System.Windows.Forms.Button btnStartCarrefour;
        public System.Windows.Forms.CheckBox CarrefourCheckbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCarrefourStatus;
        public System.Windows.Forms.ListBox IcaTextBox;
        private System.Windows.Forms.Button btnStopIca;
        private System.Windows.Forms.Button btnStartIca;
        public System.Windows.Forms.CheckBox IcaCheckbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIcaStatus;
        private System.Windows.Forms.Label lblItems1;
        private System.Windows.Forms.Label lblItems3;
        private System.Windows.Forms.Label lblItems2;
        private System.Windows.Forms.Label lblItemsProduced;
        private System.Windows.Forms.Button startBtn;
    }
}

