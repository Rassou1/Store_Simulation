using Assignment3_Form.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Assignment3_Form
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// 
        StorageManager storageManager;
        Storage<Product> storage;   
        public MainForm()
        {
            InitializeComponent();
            storageManager = new StorageManager(this);
            storage = storageManager.Storage;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            storageManager.Start();
            storageManager.managerThread.Start();
            btnStartFreshProduce.Enabled = true;
            btnStartElectronicsInc.Enabled = true;
            btnStartCarrefour.Enabled = true;
            btnStartGrandBakery.Enabled = true;
            btnStartIca.Enabled = true;
            btnStartWillys.Enabled = true;
        }
        
        

        /// <summary>
        /// Start  producer 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartFreshProduce_Click(object sender, EventArgs e)
        {
            storageManager.StartProducer(Product.categoryType.Produce);
            lblStatusScan.Text = "Currently Producing";
            btnStartFreshProduce.Enabled = false;
            btnStopFreshProduce.Enabled = true;
        }

        /// <summary>
        /// Start producer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGrandBakery_Click(object sender, EventArgs e)
        {
            storageManager.StartProducer(Product.categoryType.Bread);
            lblStatusGrandBakery.Text = "Currently Producing";
            btnStartGrandBakery.Enabled = false;
            btnStopGrandBakery.Enabled = true;
        }

        /// <summary>
        /// Start  producer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartElectronicsInc_Click(object sender, EventArgs e)
        {
            storageManager.StartProducer(Product.categoryType.Electronics);
            lblStatusElectronicsInc.Text = "Currently Producing";
            btnStartElectronicsInc.Enabled = false;
            btnStopElectronicsInc.Enabled = true;
        }

        /// <summary>
        /// Stop  producer´1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopFreshProduce_Click(object sender, EventArgs e)
        {
            storageManager.StopProducer(Product.categoryType.Produce);
            lblStatusScan.Text = "Not Producing";
            btnStartFreshProduce.Enabled = true;
            btnStopFreshProduce.Enabled = false;
        }

        /// <summary>
        /// Stop  producer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopGrandBakery_Click(object sender, EventArgs e)
        {
            storageManager.StopProducer(Product.categoryType.Bread);
            lblStatusGrandBakery.Text = "Not Producing";
            btnStartGrandBakery.Enabled = true;
            btnStopGrandBakery.Enabled = false;
        }

        /// <summary>
        /// Stop producer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopElectronicsInc_Click(object sender, EventArgs e)
        {
            storageManager.StopProducer(Product.categoryType.Electronics);
            lblStatusElectronicsInc.Text = "Not Producing";
            btnStartElectronicsInc.Enabled = true;
            btnStopElectronicsInc.Enabled = false;
        }
        /// <summary>
        /// Start consumer 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartIca_Click(object sender, EventArgs e)
        {
            storageManager.StartConsumer(Product.categoryType.Produce);
            lblIcaStatus.Text = "CONSUMING";
            btnStartIca.Enabled = false;
            btnStopIca.Enabled = true;
            
        }

        /// <summary>
        /// Stop thread 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopIca_Click(object sender, EventArgs e)
        {

            storageManager.StopConsumer(Product.categoryType.Produce);
            lblIcaStatus.Text = "NOT CONSUMING";
            btnStartIca.Enabled = true;
            btnStopIca.Enabled = false;



        }

        /// <summary>
        /// Start  consumer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCarrefour_Click(object sender, EventArgs e)
        {
            storageManager.StartConsumer(Product.categoryType.Electronics);
            lblCarrefourStatus.Text = "CONSUMING";
            btnStartCarrefour.Enabled = false;
            btnStopCarrefour.Enabled = true;
        }
 
        private void IcaTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lblIcaStatus.Invoke((MethodInvoker)(() => 
            //lblIcaStatus.Text = xxThread.IsAlive ? "alive" : "dead"));

        }

        /// <summary>
        /// Stop  thread 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCarrefour_Click(object sender, EventArgs e)
        {
            storageManager.StopConsumer(Product.categoryType.Electronics);
            lblCarrefourStatus.Text = "NOT CONSUMING";
            btnStartCarrefour.Enabled = true;
            btnStopCarrefour.Enabled = false;
        }

        /// <summary>
        /// Start consumer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartWillys_Click(object sender, EventArgs e)
        {
            storageManager.StartConsumer(Product.categoryType.Bread);
            lblWillysStatus.Text = "CONSUMING";
            btnStartWillys.Enabled = false;
            btnStopWillys.Enabled = true;

        }

        /// <summary>
        /// Stop thread 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopWillys_Click(object sender, EventArgs e)
        {
            storageManager.StopConsumer(Product.categoryType.Bread);
            lblWillysStatus.Text = "NOT CONSUMING";
            btnStartWillys.Enabled = true;
            btnStopWillys.Enabled = false;
        }

        public void UpdateWillysProducts(string thing)
        {
            if(WillysTextBox.InvokeRequired)
            {
                WillysTextBox.Invoke(new Action<string>(UpdateWillysProducts), thing);
            }
            else
            {
                WillysTextBox.Items.Add(thing);
            }
        }

        public void UpdateWillys(bool isConsuming)
        {
            if(lblWillysStatus.InvokeRequired)
            {
                lblWillysStatus.Invoke(new Action<bool>(UpdateWillys), isConsuming);
            }
            else
            {
                if(isConsuming)
                {
                    lblWillysStatus.Text = "CONSUMING";
                }
                else
                {
                    lblWillysStatus.Text = "NOT CONSUMING";
                }
            }
        }

        public void UpdateCarrefourProducts(string thing)
        {
            if (CarrefourTextBox.InvokeRequired)
            {
                CarrefourTextBox.Invoke(new Action<string>(UpdateCarrefourProducts), thing);
            }
            else
            {
                CarrefourTextBox.Items.Add(thing);
            }
        }

        public void UpdateCarrefour(bool isConsuming)
        {
            if (lblCarrefourStatus.InvokeRequired)
            {
                lblCarrefourStatus.Invoke(new Action<bool>(UpdateCarrefour), isConsuming);
            }
            else
            {
                if (isConsuming)
                {
                    lblCarrefourStatus.Text = "CONSUMING";
                }
                else
                {
                    lblCarrefourStatus.Text = "NOT CONSUMING";
                }
            }
        }

        public void UpdateIcaProducts(string thing)
        {
            if (IcaTextBox.InvokeRequired)
            {
                IcaTextBox.Invoke(new Action<string>(UpdateIcaProducts), thing);
            }
            else
            {
                IcaTextBox.Items.Add(thing);
            }
        }

        public void UpdateIca(bool isConsuming)
        {
            if (lblIcaStatus.InvokeRequired)
            {
                lblIcaStatus.Invoke(new Action<bool>(UpdateIca), isConsuming);
            }
            else
            {
                if (isConsuming)
                {
                    lblIcaStatus.Text = "CONSUMING";
                }
                else
                {
                    lblIcaStatus.Text = "NOT CONSUMING";
                }
            }
        }

        public void UpdateBufferBar(int number)
        {
            if(progressItems.InvokeRequired)
            {
                progressItems.Invoke(new Action<int>(UpdateBufferBar), number);
            }
            else
            {
                progressItems.Value = number;
            }
        }

        private void consumerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxIca_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxCarrefour_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxWillys_Enter(object sender, EventArgs e)
        {

        }

        private void lblIcaStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblStatusElectronicsInc_Click(object sender, EventArgs e)
        {

        }

        private void electronicsInc_Enter(object sender, EventArgs e)
        {

        }

        private void lblStatusScan_Click(object sender, EventArgs e)
        {

        }

        private void IcaCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblCarrefourStatus_Click(object sender, EventArgs e)
        {

        }

        private void CarrefourCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void progressItems_Click(object sender, EventArgs e)
        {

        }
    }
}
