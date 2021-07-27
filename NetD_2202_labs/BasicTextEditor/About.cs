/**About.cs
 * 
 * Name: Katherine Bellman
 * Date: July 25th 2021
 * 
 * Description: Secondary form to open from main form (BasicTextEditor) menu strip item "About".
 * 
 * Edit Date: July 26th 2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicTextEditor
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes only the current (About form) window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAboutOk_Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
