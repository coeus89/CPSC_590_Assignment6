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
    }
}
