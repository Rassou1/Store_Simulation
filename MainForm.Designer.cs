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
            this.lstWillys = new System.Windows.Forms.ListBox();
            this.btnStopWillys = new System.Windows.Forms.Button();
            this.btnStartWillys = new System.Windows.Forms.Button();
            this.chkWillysCont = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblWillysStatus = new System.Windows.Forms.Label();
            this.groupBoxCoop = new System.Windows.Forms.GroupBox();
            this.lblItems2 = new System.Windows.Forms.Label();
            this.lstCoop = new System.Windows.Forms.ListBox();
            this.btnStopCoop = new System.Windows.Forms.Button();
            this.btnStartCoop = new System.Windows.Forms.Button();
            this.chkCoopCont = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCoopStatus = new System.Windows.Forms.Label();
            this.groupBoxIca = new System.Windows.Forms.GroupBox();
            this.lblItems1 = new System.Windows.Forms.Label();
            this.lstIca = new System.Windows.Forms.ListBox();
            this.btnStopIca = new System.Windows.Forms.Button();
            this.btnStartIca = new System.Windows.Forms.Button();
            this.chkIcaCont = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIcaStatus = new System.Windows.Forms.Label();
            this.groupBoxStorage = new System.Windows.Forms.GroupBox();
            this.lblItemsProduced = new System.Windows.Forms.Label();
            this.progressItems = new System.Windows.Forms.ProgressBar();
            this.lblMax = new System.Windows.Forms.Label();
            this.producerGroupBox.SuspendLayout();
            this.electronicsInc.SuspendLayout();
            this.grandBakery.SuspendLayout();
            this.freshProduce.SuspendLayout();
            this.consumerGroupBox.SuspendLayout();
            this.groupBoxWillys.SuspendLayout();
            this.groupBoxCoop.SuspendLayout();
            this.groupBoxIca.SuspendLayout();
            this.groupBoxStorage.SuspendLayout();
            this.SuspendLayout();
            // 
            // producerGroupBox
            // 
            this.producerGroupBox.Controls.Add(this.electronicsInc);
            this.producerGroupBox.Controls.Add(this.grandBakery);
            this.producerGroupBox.Controls.Add(this.freshProduce);
            this.producerGroupBox.Location = new System.Drawing.Point(13, 13);
            this.producerGroupBox.Name = "producerGroupBox";
            this.producerGroupBox.Size = new System.Drawing.Size(229, 378);
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
            this.electronicsInc.Location = new System.Drawing.Point(6, 261);
            this.electronicsInc.Name = "electronicsInc";
            this.electronicsInc.Size = new System.Drawing.Size(217, 100);
            this.electronicsInc.TabIndex = 2;
            this.electronicsInc.TabStop = false;
            this.electronicsInc.Text = "Electronics Inc.";
            // 
            // btnStopElectronicsInc
            // 
            this.btnStopElectronicsInc.Enabled = false;
            this.btnStopElectronicsInc.Location = new System.Drawing.Point(149, 58);
            this.btnStopElectronicsInc.Name = "btnStopElectronicsInc";
            this.btnStopElectronicsInc.Size = new System.Drawing.Size(48, 23);
            this.btnStopElectronicsInc.TabIndex = 3;
            this.btnStopElectronicsInc.Text = "Stop";
            this.btnStopElectronicsInc.UseVisualStyleBackColor = true;
            this.btnStopElectronicsInc.Click += new System.EventHandler(this.btnStopElectronicsInc_Click);
            // 
            // btnStartElectronicsInc
            // 
            this.btnStartElectronicsInc.Location = new System.Drawing.Point(29, 59);
            this.btnStartElectronicsInc.Name = "btnStartElectronicsInc";
            this.btnStartElectronicsInc.Size = new System.Drawing.Size(99, 23);
            this.btnStartElectronicsInc.TabIndex = 2;
            this.btnStartElectronicsInc.Text = "Start Producing";
            this.btnStartElectronicsInc.UseVisualStyleBackColor = true;
            this.btnStartElectronicsInc.Click += new System.EventHandler(this.btnStartElectronicsInc_Click);
            // 
            // lblStatusElectronicsInc
            // 
            this.lblStatusElectronicsInc.AutoSize = true;
            this.lblStatusElectronicsInc.Location = new System.Drawing.Point(80, 31);
            this.lblStatusElectronicsInc.Name = "lblStatusElectronicsInc";
            this.lblStatusElectronicsInc.Size = new System.Drawing.Size(98, 13);
            this.lblStatusElectronicsInc.TabIndex = 1;
            this.lblStatusElectronicsInc.Text = "NOT PRODUCING";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
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
            this.grandBakery.Location = new System.Drawing.Point(6, 139);
            this.grandBakery.Name = "grandBakery";
            this.grandBakery.Size = new System.Drawing.Size(217, 100);
            this.grandBakery.TabIndex = 1;
            this.grandBakery.TabStop = false;
            this.grandBakery.Text = "Grand Bakery";
            // 
            // btnStopGrandBakery
            // 
            this.btnStopGrandBakery.Enabled = false;
            this.btnStopGrandBakery.Location = new System.Drawing.Point(149, 58);
            this.btnStopGrandBakery.Name = "btnStopGrandBakery";
            this.btnStopGrandBakery.Size = new System.Drawing.Size(48, 23);
            this.btnStopGrandBakery.TabIndex = 3;
            this.btnStopGrandBakery.Text = "Stop";
            this.btnStopGrandBakery.UseVisualStyleBackColor = true;
            this.btnStopGrandBakery.Click += new System.EventHandler(this.btnStopGrandBakery_Click);
            // 
            // btnStartGrandBakery
            // 
            this.btnStartGrandBakery.Location = new System.Drawing.Point(29, 59);
            this.btnStartGrandBakery.Name = "btnStartGrandBakery";
            this.btnStartGrandBakery.Size = new System.Drawing.Size(99, 23);
            this.btnStartGrandBakery.TabIndex = 2;
            this.btnStartGrandBakery.Text = "Start Producing";
            this.btnStartGrandBakery.UseVisualStyleBackColor = true;
            this.btnStartGrandBakery.Click += new System.EventHandler(this.btnStartGrandBakery_Click);
            // 
            // lblStatusGrandBakery
            // 
            this.lblStatusGrandBakery.AutoSize = true;
            this.lblStatusGrandBakery.Location = new System.Drawing.Point(80, 31);
            this.lblStatusGrandBakery.Name = "lblStatusGrandBakery";
            this.lblStatusGrandBakery.Size = new System.Drawing.Size(98, 13);
            this.lblStatusGrandBakery.TabIndex = 1;
            this.lblStatusGrandBakery.Text = "NOT PRODUCING";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
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
            this.freshProduce.Location = new System.Drawing.Point(6, 19);
            this.freshProduce.Name = "freshProduce";
            this.freshProduce.Size = new System.Drawing.Size(217, 100);
            this.freshProduce.TabIndex = 0;
            this.freshProduce.TabStop = false;
            this.freshProduce.Text = "Fresh Produce";
            // 
            // btnStopFreshProduce
            // 
            this.btnStopFreshProduce.Enabled = false;
            this.btnStopFreshProduce.Location = new System.Drawing.Point(149, 58);
            this.btnStopFreshProduce.Name = "btnStopFreshProduce";
            this.btnStopFreshProduce.Size = new System.Drawing.Size(48, 23);
            this.btnStopFreshProduce.TabIndex = 3;
            this.btnStopFreshProduce.Text = "Stop";
            this.btnStopFreshProduce.UseVisualStyleBackColor = true;
            this.btnStopFreshProduce.Click += new System.EventHandler(this.btnStopFreshProduce_Click);
            // 
            // btnStartFreshProduce
            // 
            this.btnStartFreshProduce.Location = new System.Drawing.Point(29, 59);
            this.btnStartFreshProduce.Name = "btnStartFreshProduce";
            this.btnStartFreshProduce.Size = new System.Drawing.Size(99, 23);
            this.btnStartFreshProduce.TabIndex = 2;
            this.btnStartFreshProduce.Text = "Start Producing";
            this.btnStartFreshProduce.UseVisualStyleBackColor = true;
            this.btnStartFreshProduce.Click += new System.EventHandler(this.btnStartFreshProduce_Click);
            // 
            // lblStatusScan
            // 
            this.lblStatusScan.AutoSize = true;
            this.lblStatusScan.Location = new System.Drawing.Point(80, 31);
            this.lblStatusScan.Name = "lblStatusScan";
            this.lblStatusScan.Size = new System.Drawing.Size(98, 13);
            this.lblStatusScan.TabIndex = 1;
            this.lblStatusScan.Text = "NOT PRODUCING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // consumerGroupBox
            // 
            this.consumerGroupBox.Controls.Add(this.groupBoxWillys);
            this.consumerGroupBox.Controls.Add(this.groupBoxCoop);
            this.consumerGroupBox.Controls.Add(this.groupBoxIca);
            this.consumerGroupBox.Location = new System.Drawing.Point(266, 13);
            this.consumerGroupBox.Name = "consumerGroupBox";
            this.consumerGroupBox.Size = new System.Drawing.Size(410, 378);
            this.consumerGroupBox.TabIndex = 1;
            this.consumerGroupBox.TabStop = false;
            this.consumerGroupBox.Text = "Consumers";
            this.consumerGroupBox.Enter += new System.EventHandler(this.consumerGroupBox_Enter);
            // 
            // groupBoxWillys
            // 
            this.groupBoxWillys.Controls.Add(this.lblItems3);
            this.groupBoxWillys.Controls.Add(this.lstWillys);
            this.groupBoxWillys.Controls.Add(this.btnStopWillys);
            this.groupBoxWillys.Controls.Add(this.btnStartWillys);
            this.groupBoxWillys.Controls.Add(this.chkWillysCont);
            this.groupBoxWillys.Controls.Add(this.label16);
            this.groupBoxWillys.Controls.Add(this.lblWillysStatus);
            this.groupBoxWillys.Location = new System.Drawing.Point(19, 261);
            this.groupBoxWillys.Name = "groupBoxWillys";
            this.groupBoxWillys.Size = new System.Drawing.Size(385, 100);
            this.groupBoxWillys.TabIndex = 2;
            this.groupBoxWillys.TabStop = false;
            this.groupBoxWillys.Text = "Willys";
            this.groupBoxWillys.Enter += new System.EventHandler(this.groupBoxWillys_Enter);
            // 
            // lblWillysItems
            // 
            this.lblItems3.AutoSize = true;
            this.lblItems3.Location = new System.Drawing.Point(121, 46);
            this.lblItems3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItems3.Name = "lblWillysItems";
            this.lblItems3.Size = new System.Drawing.Size(31, 13);
            this.lblItems3.TabIndex = 10;
            this.lblItems3.Text = "items";
            this.lblItems3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstWillys
            // 
            this.lstWillys.FormattingEnabled = true;
            this.lstWillys.Location = new System.Drawing.Point(156, 23);
            this.lstWillys.Name = "lstWillys";
            this.lstWillys.Size = new System.Drawing.Size(224, 69);
            this.lstWillys.TabIndex = 8;
            // 
            // btnStopWillys
            // 
            this.btnStopWillys.Enabled = false;
            this.btnStopWillys.Location = new System.Drawing.Point(111, 71);
            this.btnStopWillys.Name = "btnStopWillys";
            this.btnStopWillys.Size = new System.Drawing.Size(40, 23);
            this.btnStopWillys.TabIndex = 7;
            this.btnStopWillys.Text = "Stop";
            this.btnStopWillys.UseVisualStyleBackColor = true;
            this.btnStopWillys.Click += new System.EventHandler(this.btnStopWillys_Click);
            // 
            // btnStartWillys
            // 
            this.btnStartWillys.Location = new System.Drawing.Point(7, 71);
            this.btnStartWillys.Name = "btnStartWillys";
            this.btnStartWillys.Size = new System.Drawing.Size(81, 23);
            this.btnStartWillys.TabIndex = 6;
            this.btnStartWillys.Text = "Start Loading";
            this.btnStartWillys.UseVisualStyleBackColor = true;
            this.btnStartWillys.Click += new System.EventHandler(this.btnStartWillys_Click);
            // 
            // chkWillysCont
            // 
            this.chkWillysCont.AutoSize = true;
            this.chkWillysCont.Location = new System.Drawing.Point(7, 46);
            this.chkWillysCont.Name = "chkWillysCont";
            this.chkWillysCont.Size = new System.Drawing.Size(91, 17);
            this.chkWillysCont.TabIndex = 5;
            this.chkWillysCont.Text = "Continue load";
            this.chkWillysCont.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-1, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Status:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // lblWillysStatus
            // 
            this.lblWillysStatus.AutoSize = true;
            this.lblWillysStatus.Location = new System.Drawing.Point(36, 23);
            this.lblWillysStatus.Name = "lblWillysStatus";
            this.lblWillysStatus.Size = new System.Drawing.Size(99, 13);
            this.lblWillysStatus.TabIndex = 3;
            this.lblWillysStatus.Text = "NOT CONSUMING";
            // 
            // groupBoxCoop
            // 
            this.groupBoxCoop.Controls.Add(this.lblItems2);
            this.groupBoxCoop.Controls.Add(this.lstCoop);
            this.groupBoxCoop.Controls.Add(this.btnStopCoop);
            this.groupBoxCoop.Controls.Add(this.btnStartCoop);
            this.groupBoxCoop.Controls.Add(this.chkCoopCont);
            this.groupBoxCoop.Controls.Add(this.label8);
            this.groupBoxCoop.Controls.Add(this.lblCoopStatus);
            this.groupBoxCoop.Location = new System.Drawing.Point(19, 139);
            this.groupBoxCoop.Name = "groupBoxCoop";
            this.groupBoxCoop.Size = new System.Drawing.Size(385, 100);
            this.groupBoxCoop.TabIndex = 1;
            this.groupBoxCoop.TabStop = false;
            this.groupBoxCoop.Text = "Coop Market";
            this.groupBoxCoop.Enter += new System.EventHandler(this.groupBoxCoop_Enter);
            // 
            // lblCoopItems
            // 
            this.lblItems2.AutoSize = true;
            this.lblItems2.Location = new System.Drawing.Point(121, 46);
            this.lblItems2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItems2.Name = "lblCoopItems";
            this.lblItems2.Size = new System.Drawing.Size(31, 13);
            this.lblItems2.TabIndex = 10;
            this.lblItems2.Text = "items";
            this.lblItems2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstCoop
            // 
            this.lstCoop.FormattingEnabled = true;
            this.lstCoop.Location = new System.Drawing.Point(163, 23);
            this.lstCoop.Name = "lstCoop";
            this.lstCoop.Size = new System.Drawing.Size(215, 69);
            this.lstCoop.TabIndex = 8;
            // 
            // btnStopCoop
            // 
            this.btnStopCoop.Enabled = false;
            this.btnStopCoop.Location = new System.Drawing.Point(111, 62);
            this.btnStopCoop.Name = "btnStopCoop";
            this.btnStopCoop.Size = new System.Drawing.Size(40, 23);
            this.btnStopCoop.TabIndex = 7;
            this.btnStopCoop.Text = "Stop";
            this.btnStopCoop.UseVisualStyleBackColor = true;
            this.btnStopCoop.Click += new System.EventHandler(this.btnStopCoop_Click);
            // 
            // btnStartCoop
            // 
            this.btnStartCoop.Location = new System.Drawing.Point(15, 71);
            this.btnStartCoop.Name = "btnStartCoop";
            this.btnStartCoop.Size = new System.Drawing.Size(81, 23);
            this.btnStartCoop.TabIndex = 6;
            this.btnStartCoop.Text = "Start Loading";
            this.btnStartCoop.UseVisualStyleBackColor = true;
            this.btnStartCoop.Click += new System.EventHandler(this.btnStartCoop_Click);
            // 
            // chkCoopCont
            // 
            this.chkCoopCont.AutoSize = true;
            this.chkCoopCont.Location = new System.Drawing.Point(15, 46);
            this.chkCoopCont.Name = "chkCoopCont";
            this.chkCoopCont.Size = new System.Drawing.Size(91, 17);
            this.chkCoopCont.TabIndex = 5;
            this.chkCoopCont.Text = "Continue load";
            this.chkCoopCont.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Status:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblCoopStatus
            // 
            this.lblCoopStatus.AutoSize = true;
            this.lblCoopStatus.Location = new System.Drawing.Point(43, 23);
            this.lblCoopStatus.Name = "lblCoopStatus";
            this.lblCoopStatus.Size = new System.Drawing.Size(99, 13);
            this.lblCoopStatus.TabIndex = 3;
            this.lblCoopStatus.Text = "NOT CONSUMING";
            // 
            // groupBoxIca
            // 
            this.groupBoxIca.Controls.Add(this.lblItems1);
            this.groupBoxIca.Controls.Add(this.lstIca);
            this.groupBoxIca.Controls.Add(this.btnStopIca);
            this.groupBoxIca.Controls.Add(this.btnStartIca);
            this.groupBoxIca.Controls.Add(this.chkIcaCont);
            this.groupBoxIca.Controls.Add(this.label6);
            this.groupBoxIca.Controls.Add(this.lblIcaStatus);
            this.groupBoxIca.Location = new System.Drawing.Point(19, 19);
            this.groupBoxIca.Name = "groupBoxIca";
            this.groupBoxIca.Size = new System.Drawing.Size(385, 100);
            this.groupBoxIca.TabIndex = 0;
            this.groupBoxIca.TabStop = false;
            this.groupBoxIca.Text = "Ica";
            this.groupBoxIca.Enter += new System.EventHandler(this.groupBoxIca_Enter);
            // 
            // lblIcaItems
            // 
            this.lblItems1.AutoSize = true;
            this.lblItems1.Location = new System.Drawing.Point(121, 38);
            this.lblItems1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItems1.Name = "lblIcaItems";
            this.lblItems1.Size = new System.Drawing.Size(31, 13);
            this.lblItems1.TabIndex = 9;
            this.lblItems1.Text = "items";
            this.lblItems1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstIca
            // 
            this.lstIca.FormattingEnabled = true;
            this.lstIca.Location = new System.Drawing.Point(163, 16);
            this.lstIca.Name = "lstIca";
            this.lstIca.Size = new System.Drawing.Size(215, 69);
            this.lstIca.TabIndex = 8;
            this.lstIca.SelectedIndexChanged += new System.EventHandler(this.lstIca_SelectedIndexChanged);
            // 
            // btnStopIca
            // 
            this.btnStopIca.Enabled = false;
            this.btnStopIca.Location = new System.Drawing.Point(111, 64);
            this.btnStopIca.Name = "btnStopIca";
            this.btnStopIca.Size = new System.Drawing.Size(40, 23);
            this.btnStopIca.TabIndex = 7;
            this.btnStopIca.Text = "Stop";
            this.btnStopIca.UseVisualStyleBackColor = true;
            this.btnStopIca.Click += new System.EventHandler(this.btnStopIca_Click);
            // 
            // btnStartIca
            // 
            this.btnStartIca.Location = new System.Drawing.Point(15, 64);
            this.btnStartIca.Name = "btnStartIca";
            this.btnStartIca.Size = new System.Drawing.Size(81, 23);
            this.btnStartIca.TabIndex = 6;
            this.btnStartIca.Text = "Start Loading";
            this.btnStartIca.UseVisualStyleBackColor = true;
            this.btnStartIca.Click += new System.EventHandler(this.btnStartIca_Click);
            // 
            // chkIcaCont
            // 
            this.chkIcaCont.AutoSize = true;
            this.chkIcaCont.Location = new System.Drawing.Point(15, 38);
            this.chkIcaCont.Name = "chkIcaCont";
            this.chkIcaCont.Size = new System.Drawing.Size(91, 17);
            this.chkIcaCont.TabIndex = 5;
            this.chkIcaCont.Text = "Continue load";
            this.chkIcaCont.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblIcaStatus
            // 
            this.lblIcaStatus.AutoSize = true;
            this.lblIcaStatus.Location = new System.Drawing.Point(43, 16);
            this.lblIcaStatus.Name = "lblIcaStatus";
            this.lblIcaStatus.Size = new System.Drawing.Size(99, 13);
            this.lblIcaStatus.TabIndex = 3;
            this.lblIcaStatus.Text = "NOT CONSUMING";
            // 
            // groupBoxStorage
            // 
            this.groupBoxStorage.Controls.Add(this.lblItemsProduced);
            this.groupBoxStorage.Controls.Add(this.progressItems);
            this.groupBoxStorage.Controls.Add(this.lblMax);
            this.groupBoxStorage.Location = new System.Drawing.Point(13, 398);
            this.groupBoxStorage.Name = "groupBoxStorage";
            this.groupBoxStorage.Size = new System.Drawing.Size(663, 82);
            this.groupBoxStorage.TabIndex = 2;
            this.groupBoxStorage.TabStop = false;
            this.groupBoxStorage.Text = "Storage";
            // 
            // lblItemsProduced
            // 
            this.lblItemsProduced.AutoSize = true;
            this.lblItemsProduced.Location = new System.Drawing.Point(595, 16);
            this.lblItemsProduced.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemsProduced.Name = "lblItemsProduced";
            this.lblItemsProduced.Size = new System.Drawing.Size(54, 13);
            this.lblItemsProduced.TabIndex = 9;
            this.lblItemsProduced.Text = "Max items";
            this.lblItemsProduced.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressItems
            // 
            this.progressItems.ForeColor = System.Drawing.Color.Blue;
            this.progressItems.Location = new System.Drawing.Point(155, 38);
            this.progressItems.Maximum = 20;
            this.progressItems.Name = "progressItems";
            this.progressItems.Size = new System.Drawing.Size(490, 23);
            this.progressItems.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressItems.TabIndex = 2;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(6, 42);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(106, 13);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Max capacity (items):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 487);
            this.Controls.Add(this.groupBoxStorage);
            this.Controls.Add(this.consumerGroupBox);
            this.Controls.Add(this.producerGroupBox);
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
            this.groupBoxCoop.ResumeLayout(false);
            this.groupBoxCoop.PerformLayout();
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
        private System.Windows.Forms.ListBox lstWillys;
        private System.Windows.Forms.Button btnStopWillys;
        private System.Windows.Forms.Button btnStartWillys;
        private System.Windows.Forms.CheckBox chkWillysCont;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblWillysStatus;
        private System.Windows.Forms.GroupBox groupBoxCoop;
        private System.Windows.Forms.ListBox lstCoop;
        private System.Windows.Forms.Button btnStopCoop;
        private System.Windows.Forms.Button btnStartCoop;
        private System.Windows.Forms.CheckBox chkCoopCont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCoopStatus;
        private System.Windows.Forms.ListBox lstIca;
        private System.Windows.Forms.Button btnStopIca;
        private System.Windows.Forms.Button btnStartIca;
        private System.Windows.Forms.CheckBox chkIcaCont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIcaStatus;
        private System.Windows.Forms.Label lblItems1;
        private System.Windows.Forms.Label lblItems3;
        private System.Windows.Forms.Label lblItems2;
        private System.Windows.Forms.Label lblItemsProduced;
    }
}

