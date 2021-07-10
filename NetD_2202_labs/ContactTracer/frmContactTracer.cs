//
//Name : Katherine Bellman
//Student #: 100325825
//Program: 
//Program Description: 
//
//Last Modified : July 
//Date: July 3rd 2021
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracer
{
    public partial class ContactTracerForm : Form
    {
        public ContactTracerForm()
        {
            InitializeComponent();
        }
        #region GLOBAL VARIABLES

        List<Contact> ContactList = new List<Contact>();

        Boolean DGVSelectionOn = false;

        #endregion
        #region EVENT HANDLERS
        private void ContactTracerForm_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                ref Contact Count => Count ;

                Contact add = new Contact();
                
                add.FirstName = txbFirstName.Text.Trim();
                add.LastName = txbLastName.Text.Trim();
                add.EMailAddress = mtbEMail.ToString();
                add.PhoneNumber = mtbPhoneNumber.ToString();
                add.ContactStatus = chkContacted.Checked;

                UpdateDataGrid();
                SetDefaults();
            }
            catch
            { };
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Event handler for exit button. Confirms exit with message box before exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        #region  FUNCTIONS

        private void UpdateDataGrid() 
        {
            DGVSelectionOn = false;
            dgvContactList.DataSource = null;
            dgvContactList.DataSource = ContactList;
            dgvContactList.ClearSelection();
            DGVSelectionOn = true;
        }

        private void PopulateContacts(Contact contactsList)
        {
            try
            {
                txbFirstName.Text = contactsList.FirstName;
                txbLastName.Text = contactsList.LastName;
                mtbEMail.Text = contactsList.EMailAddress;
                mtbPhoneNumber.Text = contactsList.PhoneNumber;
                chkContacted.Checked = contactsList.ContactStatus;
                
            }
            catch
            {
                MessageBox.Show("An error occurred loading contacts, please try again", "Loading error", MessageBoxButtons.OK);
            }
        }

        public void SetDefaults()
        {
            txbFirstName.Clear();
            txbLastName.Clear();
            mtbEMail.Clear();
            mtbPhoneNumber.Clear();
            chkContacted.Checked = false;
        }

            #endregion



        }
}
