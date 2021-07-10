using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awesome2020Spring
{
    public partial class formIceOne : Form
    {
        public formIceOne()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, Katherine is awesome, aren't they!");
            Close();
        }

       
        private void buttonLeftNo_Click(object sender, EventArgs e)
        {
            buttonLeftNo.Visible = false;
            buttonRightNo.Visible = true;
        }

        private void buttonRightNo_Click(object sender, EventArgs e)
        {
            buttonRightNo.Visible = false;
            buttonLeftNo.Visible = true;
        }

    }
}
