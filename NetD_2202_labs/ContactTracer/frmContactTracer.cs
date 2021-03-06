/**
*Name : Katherine Bellman
*Student #: 100325825
*Program: Contact Tracer
*Program Description: Takes input of contact information and stores it for view. When a contact is clicked the associated information will populate the associated fields.
*
*Date: July 3rd 2021
*Last Modified : July 24th 2021
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
using System.Text.RegularExpressions;

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
            ContactList = Contact.LoadTestContacts();
            UpdateDataGrid();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            /// need to use validation here via isFormEntryValid()
            try
            {
                //String variable to hold error messages
                String errorMessageString = string.Empty;

                List<Contact> ConstactList = new List<Contact>();

                Contact add = new Contact();
                    
                //Add if valid
                if (isFormEntryValid())
                {
                    //Add if contact doesn't exist
                    if (GetContactfromid(ContactList,add.Id))
                    {
                        add.ContactStatus = chkContacted.Checked;
                        add.FirstName = txbFirstName.Text.Trim();
                        add.LastName = txbLastName.Text.Trim();
                        //Convert.ToDateTime(DateTime.Now);
                        add.EMailAddress = mtbEMail.ToString();
                        add.PhoneNumber = mtbPhoneNumber.ToString();

                        ContactList.Add(add);
                        UpdateDataGrid();
                    }
              /*      //Update existing contact
                    else 
                    {
                        add.ContactStatus = chkContacted.Checked;
                        add.FirstName = txbFirstName.Text.Trim();
                        add.LastName = txbLastName.Text.Trim();
                        //Convert.ToDateTime(DateTime.Now);
                        add.EMailAddress = mtbEMail.ToString();
                        add.PhoneNumber = mtbPhoneNumber.ToString();

                        ContactList.(add);
                        UpdateDataGrid();
                    } */                 
                }
                else 
                {
                    MessageBox.Show(errorMessageString , "Errors Found", MessageBoxButtons.OK);
                }
                
                

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
        /// <summary>
        /// I
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DvgSelectionChanged(object sender, EventArgs e)
        {
            if (DGVSelectionOn && dgvContactList.SelectedRows.Count > 0) 
            {
                Contact change = new Contact();
                change = Contact.GetContactfromid(ContactList, Convert.ToInt32(dgvContactList.SelectedRows[0].Cells[0].Value));
                PopulateContacts(change);
            }
        }
        #endregion
        #region  FUNCTIONS
        /// <summary>
        /// 
        /// </summary>
        private void UpdateDataGrid() 
        {
            DGVSelectionOn = false;
            dgvContactList.DataSource = null;
            dgvContactList.DataSource = ContactList;
            dgvContactList.ClearSelection();
            DGVSelectionOn = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contactsList"></param>
        private void PopulateContacts(Contact contactsList)
        {
            try
            {
                List<Contact> newContact = new List<Contact>();

                Contact input = new Contact();

                chkContacted.Checked = input.ContactStatus;
                txbFirstName.Text = input.FirstName;
                txbLastName.Text = input.LastName;
                DateTime date = DateTime.Now;
                mtbEMail.Text = input.EMailAddress;
                mtbPhoneNumber.Text = input.PhoneNumber;
                
            }
            catch
            {
                MessageBox.Show("An error occurred loading contacts, please try again", "Loading error", MessageBoxButtons.OK);
            }
        }

        public void SetDefaults()
        {
            DGVSelectionOn = false;
            txbFirstName.Clear();
            txbLastName.Clear();
            mtbEMail.Clear();
            mtbPhoneNumber.Clear();
            chkContacted.Checked = false;
            DateTime date = DateTime.Now;
            
          
            DGVSelectionOn = true;

            txbFirstName.Focus();
        }

        /// <summary>
        /// Validates all entries within their associated fields and validation each one.
        /// </summary>
        /// <returns></returns>
        private Boolean isFormEntryValid() 
        {
            Boolean returnValue = true;
            String errorMessageString = string.Empty;

            // are fields empty?
            if(txbFirstName is null) 
            {
                returnValue = false;

                errorMessageString += "First name must have an input!\n";
            }

            if (txbLastName is null)
            {
                returnValue = false;

                errorMessageString += "Last name must have an input!\n";
            }


            if (mtbPhoneNumber is null|| mtbEMail is null )
            {
                returnValue = false;

                errorMessageString += "Phone Number or E=mail must have an input!\n";
            }
            

            //first name test
            if (!(isTextBoxLengthText(txbFirstName, 2))) 
            {
                returnValue = false;
                //message box message ** concatenate if others 
                errorMessageString += "First name must be between 2 and 30 characters long! \n";

            }

            if (!(isTextBoxLengthText(txbLastName, 2))) 
            {
                returnValue = false;

                // message box message
                errorMessageString += "textbox length.\n";
            }

            if(!Regex.IsMatch(mtbEMail.Text.Trim(), "[A-Z0-9a-z._%+-]+@[A-Z0-9a-z0-9.-]+\\.[A-Za-z]{2,64}")) 
            {
                returnValue = false;
                errorMessageString += "Email is not in a valid format. \n";
            }
            else if (returnValue == false) 
            {
                MessageBox.Show(errorMessageString, "Error Encountered",MessageBoxButtons.OK);
            }

            return returnValue;
        }
        /// <summary>
        /// Checks the length of inputs for valid entry lengths
        /// </summary>
        /// <param name="inputControl"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private Boolean isTextBoxLengthText(TextBox inputControl, int length) 
        {
            Boolean returnValue = true;
            
            if(inputControl.Text.Trim().Length < length) 
            {
                returnValue = false;
            }
            return returnValue;
        }


        #endregion

    }
}
