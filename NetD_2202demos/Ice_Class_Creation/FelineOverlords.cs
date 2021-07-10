/* 
 *Author: Katherine Bellman
 *Date: July 6th 2021
 *Title: Week 8 ICE for NETD2202
 *Sub-Title: Main File for form
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Ice_Class_Creation
{
    public partial class frmFelineOverlords : Form
    {
        public frmFelineOverlords()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLES

        List<Cat> FelineOverLords = new List<Cat>();

        String felineOverlordSex;

        Boolean sexRadioSelected;

        Boolean DGVSelectionOn = false;

        #endregion
        #region EVENT HANDLERS
            
        /// <summary>
        private void frmFelineOverlords_Load(object sender, EventArgs e)
        {
            FelineOverLords = Cat.GenerateFelineOverLords();
            UpdateDataGrid();
        }
        /// Set colouring of feline overlord
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetColoring_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblPickColoring.BackColor = colorDialog1.Color;
        }
        
        /// <summary>
        /// Collect data and populate DataGridView if valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                //Grab state of radio button for class method use
                ReturnSex();

                Cat overLord = new Cat();
                overLord.Name = txbName.Text.Trim();
                overLord.Sex = Cat.SexToString(sexRadioSelected, felineOverlordSex);
                overLord.Coloring = lblPickColoring.BackColor;
                overLord.Breed = txbBreed.Text.Trim();
                overLord.IsFixed = chkFixed.Checked;

                FelineOverLords.Add(overLord);
                UpdateDataGrid();
            }
            catch { };
        }


        private void btnExitClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btnResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }


        #endregion
        #region CUSTOM METHODS (FUCNTIONS)

        private void SetDefaults() 
        {
            txbName.Clear();
            txbBreed.Clear();
            lblPickColoring.BackColor = Color.Gray;
            rbtSexMale.Checked = false;
            rbtSexFemale.Checked = false;
            chkFixed.Checked = false;
            
        }

        private void UpdateDataGrid() 
        {
            DGVSelectionOn = false;
            dgvFelineOverlords.DataSource = null;
            dgvFelineOverlords.DataSource = FelineOverLords;
            dgvFelineOverlords.ClearSelection();
            DGVSelectionOn = true;
        }

        private void ReturnSex() 
        {
            if(rbtSexMale.Checked == false)
            {
                sexRadioSelected = false;
            }
            else if(true) 
            {
                sexRadioSelected = true;
            }
            else 
            {
                MessageBox.Show("A selection of \"sex\" for feline must be made.", "Error", MessageBoxButtons.OK);
            }
        }

        #endregion
    }
}
