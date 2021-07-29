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
    public partial class frmAddEdit : Form
    {   /// <summary>
    /// Default Constructor
    /// </summary>
        public frmAddEdit()
        {
            InitializeComponent();
        }

        public frmAddEdit(int trooperID) 
        {
            InitializeComponent();
            TrooperID = trooperID;
        }
        #region "GLOBAL VARIBALES"
        List<String> Planets = new List<string>();
        int TrooperID = 0;

        #endregion //GLOBAL VARIABLES END//
        #region "EVENT HANDLERS"
        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            PopulatePlanets();
            cboPlanets.DataSource = Planets;
            if(TrooperID > 0) 
            {
                PopulateTrooper(StormTrooper.GetTrooperFromDesignation(TrooperID));

            }
            else 
            {
                SetDefaults();                
            }
        }
        private void btnSetHairColour_Click(object sender, EventArgs e)
        {
            Color originalColor = lblHairColour.BackColor;
            colorDialog1.Color = originalColor;
            colorDialog1.ShowDialog();
            if (!(colorDialog1.Color == originalColor))
            {
                lblHairColour.BackColor = colorDialog1.Color;
                
            }
        }

        private void btnSetEyeColour_Click(object sender, EventArgs e)
        {
            Color originalColor = lblEyeColour.BackColor;
            colorDialog1.Color = originalColor;
            colorDialog1.ShowDialog();
            if (!(colorDialog1.Color == originalColor))
            {
                lblEyeColour.BackColor = colorDialog1.Color;
                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        { 
                SetDefaults();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTrooper();

            frmListOfTroopers frm = frmListOfTroopers.Instance;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.Focus();

            this.Focus();

            SetDefaults();
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            SaveTrooper();

            frmListOfTroopers frm = frmListOfTroopers.Instance;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.Focus();
            this.Close();
        }

        #endregion // EVENT HANDLERS END//
        #region "CUSTOM METHODS"
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
                cboPlanets.SelectedItem = trooper.HomeWorld;
               
            }
            catch
            {
                MessageBox.Show("An error occured loading the trooper, try again later!", "Loading error", MessageBoxButtons.OK);
            }


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


        private void SaveTrooper()
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
                if (nudDesignation.Enabled && !StormTrooper.AlreadyExists(st.Designation))
                {
                    StormTrooper.Troopers.Add(st);
                }
                else if (nudDesignation.Enabled)
                {
                    MessageBox.Show("That designation has already been used!");
                }
                else
                {
                    StormTrooper.Troopers.Remove(StormTrooper.GetTrooperFromDesignation(st.Designation));
                    StormTrooper.Troopers.Add(st);
                }

            }
            catch { };
        }
       
        #endregion //CUSTOM METHODS END//

       
    }

}
