using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        STKClient stkC = new STKClient();
        int myId = 0;
        private void btnTestCallback_Click(object sender, EventArgs e)
        {
            try
            {
                CBClient cbc = new CBClient();
                cbc.CallLongCompute(int.Parse(txtA.Text), int.Parse(txtB.Text), txtClientID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                stkC.SubscribeToPriceChange("IBM", 128, myId);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                stkC.UnsubscribeToPriceChange("IBM");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            PC.PriceChangeClient pcc = new PC.PriceChangeClient();
            pcc.ChangeStockPrice("IBM", double.Parse(txtNewPrice.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myId = new Random((int)DateTime.Now.Ticks).Next();
            this.Text = myId.ToString();
        }
    }
}
