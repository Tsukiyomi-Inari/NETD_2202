/* 
 * Author: Clint MacDonald
 * Date: June 30, 2021
 * Title: Week 8 Class Demo for NETD2202
 *  
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        List<String> Units = new List<string>();

        Boolean DGVSelectionOn = false;
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


            //StormTrooper st1 = new StormTrooper();
            //StormTrooper st2 = new StormTrooper();
            //st1.Age();
            //st2.Age();
            //StormTrooper.GetUnitTroopers

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // add data validation
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

                //determine if in edit or add mode
                if (nudDesignation.Enabled && !StormTrooper.AlreadyExists(Troopers, st.Designation))
                {
                    Troopers.Add(st);
                }
                else if (nudDesignation.Enabled) 
                {
                    MessageBox.Show("That designation has already been used!");
                }
                else 
                {
                    Troopers.Remove(StormTrooper.GetTrooperFromDesignation(Troopers, st.Designation));
                    Troopers.Add(st);
                }

                UpdateUnitsComboBox();
                for(int i = 0; i > cboUnits.Items.Count; i++) 
                {
                    if (cboUnits.Items[i].ToString() == st.Unit) 
                    {
                        cboUnits.SelectedIndex = i;
                        break;
                    }
                }
                //UpdateDataGrid();
                SetDefaults();
            }
            catch { };
        }

        private void cboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboUnits.SelectedIndex == 0) 
            {
                UpdateDataGrid();
            }
            else if (cboUnits.SelectedIndex > 0) 
            {
                UpdateDataGrid(cboUnits.SelectedValue.ToString());
            }
            else 
            {
                //it does nothing
            }
        }
        private void dgvSelectionChange(object sender, EventArgs e)
        {
            if(DGVSelectionOn && dgvClones.SelectedRows.Count > 0) 
            {
                //testing
                // MessageBox.Show(dgvClones.SelectedRows[0].Cells[0].Value.ToString());

                StormTrooper st = new StormTrooper();
                st = StormTrooper.GetTrooperFromDesignation(Convert.ToInt32(dgvClones.SelectedRows[0].Cells[0].Value));
                PopulateTrooper(st);
            }
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

        private void UpdateDataGrid()
        {
            DGVSelectionOn = false;
            dgvClones.DataSource = null;
            dgvClones.DataSource = Troopers;
            dgvClones.ClearSelection();
            DGVSelectionOn = true;
        }

        private void UpdateDataGrid(String Unit)
        {
            DGVSelectionOn = false;
            dgvClones.DataSource = null;
            dgvClones.DataSource = StormTrooper.GetUnitTroopers(Troopers , Unit);
            dgvClones.ClearSelection();
            DGVSelectionOn = true;
        }

        private void SetDefaults()
        {
            nudDesignation.Enabled = true;
            lblHairColour.BackColor = Color.Gray;
            lblEyeColour.BackColor = Color.Gray;
            txtNickName.Clear();
            txtUnit.Clear();
            cboPlanets.SelectedIndex = -1;
            dtpBorn.Value = DateTime.Now;
            nudDesignation.Value = 0;
            chkDefective.Checked = false;
        }

        private void UpdateUnitsComboBox() 
        {
            cboUnits.DataSource = null;
            Units.Clear();
            Units.Add("Show All");
            Units.AddRange(StormTrooper.GetDistinctUnitList(Troopers);
            cboUnits.DataSource= Units;
        }

        private void PopulateTrooper(StormTrooper trooper) 
        {
            try
            {
                nudDesignation.Enabled = false;

                nudDesignation.Value = trooper.Designation;
                txtNickName.Text = trooper.NickName;
                dtpBorn.Value = trooper.Born;
                txtUnit.Text = trooper.Unit;
                chkDefective.Checked = trooper.Defective;
                lblHairColour.BackColor = trooper.HairColour;
                lblEyeColour.BackColor = trooper.EyeColour;

                //cboPlanets.SelectedValue = trooper.HomeWorld;   this won't work so using a for loop

                for (int i = 0; i < cboPlanets.Items.Count; i++) 
                {
                    if(cboPlanets.Items[i].ToString() == trooper.HomeWorld) 
                    {
                        cboPlanets.SelectedIndex = i;
                        break;
                    }
                }

                        //other options mentioned but more advanced
                //cboPlanets.DisplayMember  DBMS integration related
                //cboPlanets.ValueMember    is value behind what is being displayed
            }
            catch
            {
                MessageBox.Show("An error occurred loading the trooper, try again latter", "Loading error", MessageBoxButtons.OK);
            }
        }



        #endregion

    }
}
