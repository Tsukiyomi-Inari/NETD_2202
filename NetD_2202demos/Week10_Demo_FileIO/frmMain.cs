/* 
 * Author: Clint MacDonald
 * Date: June 30, 2021
 * Title: Week 8 Class Demo for NETD2202
 * Revisions:  July 7, Clint, continued the demo to version 1.1.0
 * */

using System;
using System.Collections.Generic;
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

        List<String> Units = new List<String>();

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

            UpdateUnitsComboBox();

            saveFileDialog1.Filter = "CSV Files (*.csv) | *.csv";
            openFileDialog1.Filter = "CSV Files (*.csv) | *.csv";
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

                // determine if edit mode or add mode
                if (nudDesignation.Enabled  && !StormTrooper.AlreadyExists(Troopers, st.Designation))
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
                
                for( int i = 0; i < cboUnits.Items.Count; i++)
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
            if (cboUnits.SelectedIndex == 0)
            {
                UpdateDataGrid();
            }
            else if (cboUnits.SelectedIndex > 0)
            {
                UpdateDataGrid(cboUnits.SelectedValue.ToString());
            }
            else
            {
                // do nothing
            }
        }

        private void dgvSelectionChange(object sender, EventArgs e)
        {
            if (DGVSelectionOn && dgvClones.SelectedRows.Count > 0)
            {
                // for testing only
                //MessageBox.Show(dgvClones.SelectedRows[0].Cells[0].Value.ToString());

                StormTrooper st = new StormTrooper();
                st = StormTrooper.GetTrooperFromDesignation(Troopers, Convert.ToInt32(dgvClones.SelectedRows[0].Cells[0].Value));
                PopulateTrooper(st);
            }

        }
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            String fileName = string.Empty;
            if (saveFileDialog1.ShowDialog()==DialogResult.OK) 
            {
                fileName = saveFileDialog1.FileName;
                //save the troopers in the file
                StormTrooper.WriteToFile(Troopers, fileName);
                MessageBox.Show("Save was complete", "Save Confirmation", MessageBoxButtons.OK);
            }
        }
        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                Troopers.Clear();
                //Load form file
                Troopers = StormTrooper.LoadFromCSV(openFileDialog1.FileName);
                UpdateUnitsComboBox();
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

        private void UpdateDataGrid(String unit)
        {
            DGVSelectionOn = false;
            dgvClones.DataSource = null;
            dgvClones.DataSource = StormTrooper.GetUnitTroopers(Troopers, unit);
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
            Units.AddRange(StormTrooper.GetDistinctUnitList(Troopers));
            cboUnits.DataSource = Units;
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

                // does not work
                //cboPlanets.SelectedValue = trooper.HomeWorld;

                for (int i = 0; i < cboPlanets.Items.Count; i++)
                {
                    if (cboPlanets.Items[i].ToString() == trooper.HomeWorld)
                    {
                        cboPlanets.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("An error occured loading the trooper, try again later!", "Loading error", MessageBoxButtons.OK);
            }
           

        }



        #endregion

    }
}
