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
    public partial class frmListOfTroopers : Form
    {
        public frmListOfTroopers()
        {
            InitializeComponent();
        }
        #region "SINGLETON PATTERN"
        //singleton pattern
        private static frmListOfTroopers troopersListInstance;
        public static frmListOfTroopers Instance
        {
            get
            {
                if (troopersListInstance == null)
                {
                    troopersListInstance = new frmListOfTroopers();
                }
                return troopersListInstance;
            }
        }

        #endregion
        #region "EVENT HANDLERS"
        private void frmListOfTroopers_Load(object sender, EventArgs e)
        {
            
        }


        private void frmClosed(object sender, FormClosedEventArgs e)
        {
            troopersListInstance = null;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEdit frm = new frmAddEdit();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.Focus();

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
        #endregion //end EVENT HANDLERS
        #region "CUSTOM METHODS"
        public void UpdateForm()
        {
            UpdateUnitComboBox();
            UpdateTrooperGrid();

            frmMain frm = (frmMain)this.MdiParent;
            frm.setNumberOfTroopers(StormTrooper.Troopers.Count);

        }

        private void UpdateUnitComboBox()
        {
            cboUnits.DataSource = null;
            cboUnits.DataSource = StormTrooper.GetDistinctUnitList();
        }

        private void UpdateTrooperGrid()
        {
            dgvTroopers.DataSource = null;
            dgvTroopers.DataSource = StormTrooper.Troopers;
            dgvTroopers.ClearSelection();
        }

        

        #endregion //end CUSTOM METHODS

        private void frmActivated(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
