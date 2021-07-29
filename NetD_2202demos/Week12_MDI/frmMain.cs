/**   frmMain.cs
 *  @Author: Katherine Bellman
 *  @Program: Storm Troopers Inventory
 *  @Description: MDI demo
 *
 * @date: July 28th 2021
 * 
 * 
 * @ Last changed on: July 28th 2021
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

namespace Week12_MDI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region "EVENT HANDLERS"
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
        /// <summary>
        /// opens the List of Troopers window within the parent (MAIN)
        /// form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuViewListOfTroopers_Click(object sender, EventArgs e)
        {
            frmListOfTroopers frm = frmListOfTroopers.Instance;
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }
        /// <summary>
        /// opens the Storm trooper editor within the parent (MAIN) form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuViewAddTrooper_Click(object sender, EventArgs e)
        {
            frmAddEdit frm = new frmAddEdit();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            StormTrooper.GenerateTestTroopers();
        }
        #endregion //EVENT HANDLERS END ///

        #region "CUSTOM METHODS"
        private void SetFileName(String str)
        {
            FileNameCurrent = str;
            statusFileName.Text = str;
        }

        private void SaveAsFile()
        {
            String filename = string.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                // save the information
                StormTrooper.FileWrite(filename);

                MessageBox.Show("Save was Complete", "Save Confirmation", MessageBoxButtons.OK);
                SetFileName(filename);
            };
        }

        private void SaveFile()
        {
            if (FileNameCurrent == string.Empty)
            {
                SaveAsFile();
            }
            else
            {
                StormTrooper.FileWrite(FileNameCurrent);
                MessageBox.Show("Save was Complete", "Save Confirmation", MessageBoxButtons.OK);
            }
        }

  

        private void OpenFile()
        {
            Boolean cont = true;
            if (statusChange.Text == "True")
            {
                if (!(MessageBox.Show("You have unsaved changes, Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    cont = false;
                }
            }

            if (cont && openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StormTrooper.Troopers.Clear();
                // Load from a file
                StormTrooper.Troopers = StormTrooper.LoadFromCSV(openFileDialog1.FileName);
                
                SetFileName(openFileDialog1.FileName);
            }

        }

        #endregion //CUSTOM METHODS END//

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            Boolean cont = true;
            if (statusChange.Text == "True")
            {
                if (!(MessageBox.Show("You have unsaved changes, Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    cont = false;
                }
            }

            if (cont && openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StormTrooper.Troopers.Clear();
                // Load from a file
                StormTrooper.Troopers = StormTrooper.LoadFromCSV(openFileDialog1.FileName);
                
                SetFileName(openFileDialog1.FileName);
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            if (statusChange.Text == "True")
            {
                if (MessageBox.Show("You have unsaved changes, Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {

        }
    }
}