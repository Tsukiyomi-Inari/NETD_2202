/**BasicTextEditor.cs
 * 
 * Name: Katherine Bellman
 * Date: July 25th 2021
 * 
 * Description:  Main file for text editor application that users can create, open, edit and save text files (*.txt)
 *                  Functions for copy, cut , paste and exit(application) allow for them to be used within the                          application.
 * 
 * Edit Date: July 26th 2021
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

        private bool hasText = false; //changes from "new"
              
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
        }

  ////////=======CUT/COPY/PASTE/FONT=======/////////
        /// <summary>
        /// Pastes contents from clipboard to rich text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditPaste_Click(object sender, EventArgs e)
        {
            rtbTextEntry.Paste();
        }

        /// <summary>
        /// Cuts selected text in rich text box, and adds a copy to the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditCut_Click(object sender, EventArgs e)
        {
            rtbTextEntry.Cut();
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
            fontDialog1.ShowDialog();
            rtbTextEntry.Font = fontDialog1.Font;
        }
    /////////=============end cut/copy/paste/font============//////////////
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
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            

            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                rtbTextEntry.Clear();
                
                FileStream fileRead = new FileStream(Path.GetFullPath(openFileDialog.FileName), FileMode.Open, FileAccess.Read);
                //StreamReader
                StreamReader sRead = new StreamReader(fileRead);
                //Load file
                rtbTextEntry.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
               
                sRead.ReadToEnd();
                sRead.Close();
                fileRead.Close();

            }
            this.Text = Path.GetFileName(openFileDialog.FileName) + " - Basic Text Editor";

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
            this.Text = "Untitled - Basic Text Editor";


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            

            SaveFile(rtbTextEntry, saveFileDialog1.FileName);
            this.Text = saveFileDialog1.FileName + " - Basic Text Editor";

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
           
            SaveFile(rtbTextEntry, saveFileDialog1.FileName);
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
            //TODO: Finish ConfirmClose method
            //confirm before close (When New, Open or Exit are executed)

            //activates only (message box) if current open file has changed

            // ignore any new and unsaved file while blank
            //if changes
            if (hasText == true)
            {
                if (MessageBox.Show("Would you like to save the document before closing?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    //save method call

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

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length >0)
            {
                txtFile = saveFileDialog1.FileName;
                //Save document
                rtbTextEntry.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                FileStream fsWrite = new FileStream(txtFile, FileMode.Create, FileAccess.Write);
                StreamWriter sWriter = new StreamWriter(fsWrite);
                sWriter.Write(rtbTextEntry.Text);
                sWriter.Close();
                fsWrite.Close();
            }
        }


        #endregion

    }
}
