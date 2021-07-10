/* -----------------------
 * Author: Clint MacDonald
 * Date: June 2021
 * Title: Droid Factory - Class Example 1
 * ----------------------- */

#region USING
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace W7_Demo_Classes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLES
        List<Droid> Droids = new List<Droid>();

        // Validation constants
        const int MinDesignationLength = 4;
        const int MaxDesignationLength = 8;
        const int MinOwnerLength = 5;
        #endregion

        #region Control Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaults();
            txtDesignation.MaxLength = MaxDesignationLength;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?","Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSetPrimaryColour_Click(object sender, EventArgs e)
        {
            colorDialogMain.ShowDialog();
            lblPrimaryColour.BackColor = colorDialogMain.Color;
        }

        private void btnSecondaryColour_Click(object sender, EventArgs e)
        {
            colorDialogMain.ShowDialog();
            lblSecondaryColour.BackColor = colorDialogMain.Color;
        }

        private void lboxDroids_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDroid(FindDroid(lboxDroids.SelectedItem.ToString()));
        }

        private void btnResetDroid_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnSaveDroid_Click(object sender, EventArgs e)
        {
            // do stuff here first
            if (IsValid())
            {
                Droid droid = new Droid();
                droid.Designation = txtDesignation.Text.Trim();
                droid.Owner = txtOwner.Text.Trim();
                droid.InService = chkInService.Checked;
                droid.PrimaryColour = lblPrimaryColour.BackColor;
                droid.SecondaryColour = lblSecondaryColour.BackColor;

                Droids.Add(droid);

                PopulateDroidListBox();
            }

            SetDefaults();
        }

        private void btnClearDroids_Click(object sender, EventArgs e)
        {
            Droids.Clear();
            lboxDroids.Items.Clear();
        }

        #endregion

        #region Custom UI Functions and Methods
        private void SetDefaults()
        {
            txtDesignation.Clear();
            txtOwner.Clear();
            chkInService.Checked = false;
            lblPrimaryColour.BackColor = Color.Gray;
            lblSecondaryColour.BackColor = Color.Gray;
        }

        private void PopulateDroidListBox()
        {
            lboxDroids.Items.Clear();
            foreach (Droid d in Droids)
            {
                lboxDroids.Items.Add(d.Designation);
            }
        }

        private Droid FindDroid(string designation)
        {
            return Droids.Find(d => d.Designation.ToUpper() == designation.ToUpper());
        }

        private void LoadDroid(Droid d)
        {
            lblDetailsDesignation.Text = d.Designation;
            chkDetailsInService.Checked = d.InService;
            lblDetailsOwner.Text = d.Owner;
            lblDetailsPrimaryColour.BackColor = d.PrimaryColour;
            lblDetailsSecondaryColour.BackColor = d.SecondaryColour;
        }
        #region DATA VALIDATION
            
        private bool IsValid()
        {
            bool retVal = true;
            if (txtDesignation.Text.Trim().Length < MinDesignationLength || txtDesignation.Text.Trim().Length > MaxDesignationLength)
            {
                MessageBox.Show("The Designation is not valid!");
                retVal = false;
            }
            if (txtOwner.Text.Trim().Length < MinOwnerLength)
            {
                MessageBox.Show("The Owner is not valid!");
                retVal = false;
            }
            return retVal;
        }

        #endregion

        #endregion


    }
}
