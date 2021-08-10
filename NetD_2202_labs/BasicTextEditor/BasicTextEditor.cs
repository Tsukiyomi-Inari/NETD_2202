/**BasicTextEditor.cs
 * 
 * Name: Katherine Bellman
 * Date: July 25th 2021
 * 
 * Description:  Main file for text editor application that users can create, open, edit and save text files (*.txt)
 *                  Functions for copy, cut , paste and exit(application) allow for them to be used within the                          application.
 * 
 * Edit Date: August 5th  2021
 */


using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace BasicTextEditor
{
    public partial class frmBasicTextEditor : Form
    {
        #region READ-ONLY VARIABLES

        private bool hasText = false; //changes from "new", "open" and "save"
              
        #endregion
        public frmBasicTextEditor()
        {
            InitializeComponent();

        }

        #region EVENT HANDLERS
        /// <summary>
        /// Sets filter for save and open file types
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBasicTextEditor_Load(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TXT files (*.txt)|*.txt";
            openFileDialog1.Filter = "TXT files (*.txt)|*.txt";
            this.Text = "Untitled - Basic Text Editor";
            SetDefaults();
        }

  ////////=======CUT/COPY/PASTE/FONT/SELECT ALL=======/////////

        /// <summary>
        /// Pastes contents from clipboard to rich text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditPaste_Click(object sender, EventArgs e)
        {
            rtbTextEntry.Paste();
            hasText = true;
        }

        /// <summary>
        /// Cuts selected text in rich text box, and adds a copy to the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditCut_Click(object sender, EventArgs e)
        {
            rtbTextEntry.Cut();
            hasText = true;
        }

        /// <summary>
        /// Copies currently selected contents within rich text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditCopy_Click(object sender, EventArgs e)
        {
            rtbTextEntry.Copy();
        }
        /// <summary>
        /// Opens font dialog box, takes in change of font and sets
        /// rich text box font to selected font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditFont_Change(object sender, EventArgs e)
        {
            //Check if there is only a partial selection
            if (rtbTextEntry.SelectedText == RichTextBoxSelectionTypes.MultiChar.ToString()) 
            {
                //only change the font for that selection
                fontDialog1.ShowDialog();
                rtbTextEntry.SelectionFont = fontDialog1.Font;
                hasText = true;
            }
            else
            {
                fontDialog1.ShowDialog();
                rtbTextEntry.Font = fontDialog1.Font;
                hasText = true;
            }
                        
        }
        /// <summary>
        /// Selects all text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditSelectAll_Click(object sender, EventArgs e)
        {
            rtbTextEntry.SelectAll();
            hasText = true;
        }
    /////////=============end cut/copy/paste/font/select all============//////////////
    ///
        /// <summary>
        /// Display About form as dialog box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            Form aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

/////============OPEN/NEW/SAVE/SAVE-AS/CLOSE/EXIT================/////////
        /// <summary>
        ///Opens file dialog box launches to load a file into rich text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rtbTextEntry.Text = sr.ReadToEnd();
                sr.Close();
               
                this.Text = Path.GetFileName(openFileDialog1.FileName) + " - Basic Text Editor";
                fs.Close();
            }

            SetDefaults();
        }
        /// <summary>
        /// Starts new text document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            //Clear rich text box to start a new "file"
            rtbTextEntry.Clear();
            //Update form title to reflect the new untitled file 
            this.Text = "Untitled - Basic Text Editor";
            SetDefaults();
        }
        /// <summary>
        /// Event handler for 'Save' in the menu strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSave_Click(object sender, EventArgs e)
        {

            // does the file already exist in open directory


                //Use the save method to save the current progress of opened file
                SaveFile(rtbTextEntry, saveFileDialog1.FileName);
            //Set the form name to reflect the saved file name 
            this.Text = saveFileDialog1.FileName + " - Basic Text Editor";

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
           //save the file with save method
            SaveFile(rtbTextEntry, saveFileDialog1.FileName);
            //Set the form name to reflect the saved file
            this.Text = saveFileDialog1.FileName + " - Basic Text Editor";

        }
        /// <summary>
        /// Closes current document
        /// and calls ConfirmClose to prevent loss of work        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileClose_Click(object sender, EventArgs e)
        {
            //Confirm before close
            ConfirmClose();
        }
        /// <summary>
        /// Exits application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        /////============end open/new/save/save-as/close/exit================/////////
        
        /// <summary>
        /// Changes made within Rich Text Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtTextEntry_Changed(object sender, EventArgs e)
        {
            hasText = true;
        }
        #endregion

        #region Menu OPTIONS METHOD
        /// <summary>
        /// Method to close application
        /// </summary>
        private void ExitApplication()
        {
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Confirm before performing action
        ///  For use with:
        ///                 -"Close" for closing current file
        ///                 -"Exit" to prevent loss of work
        /// </summary>
        private void ConfirmClose() 
        {
            //if changes
            if (hasText == true)
            {
                if (MessageBox.Show("Would you like to save the document before closing?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    SetDefaults();
                    this.Close();
                }
                else
                {
                    //save method call
                    SaveFile(rtbTextEntry, saveFileDialog1.FileName);

                    //reset changes tracking variable 
                    SetDefaults();
                    this.Close();
                }

            }

        }
        /// <summary>
        /// Write to file
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="fileName"></param>
        public void SaveFile(RichTextBox textBox , string fileName) 
        {
            string txtFile = string.Empty;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                txtFile = saveFileDialog1.FileName;
                //Save document
                 rtbTextEntry.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                FileStream fsWrite = new FileStream(txtFile, FileMode.Create, FileAccess.Write);
                StreamWriter sWriter = new StreamWriter(fsWrite);
                sWriter.Write(rtbTextEntry.Text);
                sWriter.Close();
                fsWrite.Close();

                //update variable with set defaults for unsaved changes

                SetDefaults();
             }



        }

        /// <summary>
        /// Sets has Text to false aka no changes to opened, saved or new document
        /// </summary>
        public void SetDefaults()
        {
            hasText = false;
        }



        #endregion

    }
}
