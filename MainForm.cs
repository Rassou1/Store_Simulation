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
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start  producer 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartFreshProduce_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Start producer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGrandBakery_Click(object sender, EventArgs e)
        {
 
        }

        /// <summary>
        /// Start  producer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartElectronicsInc_Click(object sender, EventArgs e)
        {
 
        }

        /// <summary>
        /// Stop  producer´1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopFreshProduce_Click(object sender, EventArgs e)
        {
 
        }

        /// <summary>
        /// Stop  producer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopGrandBakery_Click(object sender, EventArgs e)
        {
 
        }

        /// <summary>
        /// Stop producer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopElectronicsInc_Click(object sender, EventArgs e)
        {
          }
        /// <summary>
        /// Start consumer 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartIca_Click(object sender, EventArgs e)
        {
 
        }

        /// <summary>
        /// Stop thread 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopIca_Click(object sender, EventArgs e)
        {
            
            //Use the following patter to invoke updating of a control by other threads
            //lblIcaStatus.Invoke((MethodInvoker)(() => lblIcaStatus.Text = 
                   //xxThread.IsAlive ? "alive" : "dead"));



        }

        /// <summary>
        /// Start  consumer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCoop_Click(object sender, EventArgs e)
        {
  
        }
 
        private void lstIca_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lblIcaStatus.Invoke((MethodInvoker)(() => 
            //lblIcaStatus.Text = xxThread.IsAlive ? "alive" : "dead"));

        }

        /// <summary>
        /// Stop  thread 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopCoop_Click(object sender, EventArgs e)
        {
          }

        /// <summary>
        /// Start consumer 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartWillys_Click(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Stop thread 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopWillys_Click(object sender, EventArgs e)
        {
   
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

        private void groupBoxCoop_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxWillys_Enter(object sender, EventArgs e)
        {

        }
    }
}
