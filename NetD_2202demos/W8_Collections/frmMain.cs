/* 
 * Author: Katherine Bellman
 * Date: June 30th 2021
 * Title: Week 8 Class demo for NetD2202
 * sub-title: Main form file
 **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W8_Collections
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        #region GLOBAL VARS
        List<String> Planets = new List<String>();

        List<StormTrooper> Troopers = new List<StormTrooper>();

        

        #endregion

        #region EVENT HANDLERS
        /// <summary>
        /// Main form loading commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulatePlanets();
            cboPlanets.DataSource = Planets;

            Troopers = StormTrooper.GenerateTestTroopers();

            UpdateDataGrid();
        }

        private void btnSetHairColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblHairColour.BackColor = colorDialog1.Color;
        }

        private void btnSetEyeColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblEyeColour.BackColor = colorDialog1.Color;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //add data validation
            try 
            {
                StormTrooper st = new StormTrooper();
                st.Designation = Decimal.ToInt32(nudDesignation.Value);
                st.NickName = txtNickName.Text.Trim();
                st.HomeWorld = cboPlanets.SelectedValue.ToString();
                st.Unit = txtUnit.Text.Trim();
                st.Born = dtpBorn.Value;
                st.Defective = chkDefective.Checked;
                st.HairColour = lblHairColour.BackColor;
                st.EyeColour = lblEyeColour.BackColor;

                Troopers.Add(st);
                UpdateDataGrid();
            }
            catch { };
        }

        #endregion

        #region CUSTOM METHODS
        private void PopulatePlanets()
        {
            Planets.Add("Alderaan");
            Planets.Add("Bespin");
            Planets.Add("Coruscant");
            Planets.Add("Dagobah");
            Planets.Add("Endor");
            Planets.Add("Geonosis");
            Planets.Add("Hoth");
            Planets.Add("Jakku");
            Planets.Add("Kamino");
            Planets.Add("Mandalore");
            Planets.Add("Mustafar");
            Planets.Add("Naboo");
            Planets.Add("Scarif");
            Planets.Add("Tatooine");
            Planets.Add("Yavin");
        }

        private void SetDefaults()
        {
            lblHairColour.BackColor = Color.Gray;
            lblEyeColour.BackColor = Color.Gray;
            txtNickName.Clear();
            txtUnit.Clear();
            cboPlanets.SelectedIndex = -1;
            dtpBorn.Value = DateTime.Now;
            nudDesignation.Value = 0;
            chkDefective.Checked = false;
        }

        private void UpdateDataGrid() 
        {
            dgvClones.DataSource = null;
            dgvClones.DataSource = Troopers;
        }

        #endregion


        


    

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitButton_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }
    }
}
