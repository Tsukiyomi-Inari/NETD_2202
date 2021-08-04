
namespace BasicTextEditor
{
    partial class frmBasicTextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBasicTextEditor));
            this.rtbTextEntry = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTextEntry
            // 
            this.rtbTextEntry.BackColor = System.Drawing.SystemColors.Window;
            this.rtbTextEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTextEntry.EnableAutoDragDrop = true;
            this.rtbTextEntry.Location = new System.Drawing.Point(0, 26);
            this.rtbTextEntry.Margin = new System.Windows.Forms.Padding(4);
            this.rtbTextEntry.Name = "rtbTextEntry";
            this.rtbTextEntry.Size = new System.Drawing.Size(984, 669);
            this.rtbTextEntry.TabIndex = 0;
            this.rtbTextEntry.Text = "";
            this.toolTip1.SetToolTip(this.rtbTextEntry, "Text Editor input space.");
            this.rtbTextEntry.ModifiedChanged += new System.EventHandler(this.rbtTextEntry_Changed);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(984, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileClose,
            this.toolStripSeparator3,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.menuFile.Size = new System.Drawing.Size(48, 22);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "File Options Menu";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = global::BasicTextEditor.Properties.Resources.Icons8_Ios7_Files_Txt;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeyDisplayString = "";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(180, 22);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "Starts a empty text file";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = global::BasicTextEditor.Properties.Resources.Icons8_Ios7_Very_Basic_Opened_Folder;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeyDisplayString = "";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.ToolTipText = "Open a file";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = global::BasicTextEditor.Properties.Resources.Icons8_Ios7_User_Interface_Save_As;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeyDisplayString = "";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(180, 22);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.ToolTipText = "Save current file";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Image = global::BasicTextEditor.Properties.Resources.Iconsmind_Outline_Save;
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeyDisplayString = "";
            this.menuFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.menuFileSaveAs.Text = "Save &As..";
            this.menuFileSaveAs.ToolTipText = "Save file As..";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Image = global::BasicTextEditor.Properties.Resources.Roundicons_100_Free_Solid_Confirm_notification;
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.Size = new System.Drawing.Size(180, 22);
            this.menuFileClose.Text = "Close";
            this.menuFileClose.ToolTipText = "Close the window";
            this.menuFileClose.Click += new System.EventHandler(this.menuFileClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Image = global::BasicTextEditor.Properties.Resources.Icons8_Ios7_User_Interface_Exit;
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeyDisplayString = "";
            this.menuFileExit.Size = new System.Drawing.Size(180, 22);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.ToolTipText = "Exit this application";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCopy,
            this.menuEditCut,
            this.menuEditPaste,
            this.toolStripSeparator2,
            this.menuEditFont,
            this.menuEditSelectAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(50, 22);
            this.menuEdit.Text = "&Edit";
            this.menuEdit.ToolTipText = "Edit options menu";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Image = global::BasicTextEditor.Properties.Resources.Icons8_Ios7_Very_Basic_Copy;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeyDisplayString = "";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(205, 22);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.ToolTipText = "Copy";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Image = global::BasicTextEditor.Properties.Resources.Icons8_Ios7_Editing_Cut_Filled;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(205, 22);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.ToolTipText = "Cut";
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Image = global::BasicTextEditor.Properties.Resources.Custom_Icon_Design_Mini_Paste;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(205, 22);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.ToolTipText = "Paste";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // menuEditFont
            // 
            this.menuEditFont.Image = global::BasicTextEditor.Properties.Resources.Icons8_Ios7_Editing_Decrease_Font;
            this.menuEditFont.Name = "menuEditFont";
            this.menuEditFont.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.menuEditFont.Size = new System.Drawing.Size(205, 22);
            this.menuEditFont.Text = "Font";
            this.menuEditFont.ToolTipText = "Open font menu";
            this.menuEditFont.Click += new System.EventHandler(this.menuEditFont_Change);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(57, 22);
            this.menuHelp.Text = "&Help";
            this.menuHelp.ToolTipText = "Help options menu";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Image = global::BasicTextEditor.Properties.Resources.Icons8_Ios7_Very_Basic_Help_Filled;
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.menuHelpAbout.Text = "&About";
            this.menuHelpAbout.ToolTipText = "About this application";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.FontMustExist = true;
            this.fontDialog1.Apply += new System.EventHandler(this.menuEditFont_Change);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuEditSelectAll.Size = new System.Drawing.Size(205, 22);
            this.menuEditSelectAll.Text = "Select All";
            this.menuEditSelectAll.ToolTipText = "Select All";
            this.menuEditSelectAll.Click += new System.EventHandler(this.menuEditSelectAll_Click);
            // 
            // frmBasicTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 695);
            this.Controls.Add(this.rtbTextEntry);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 734);
            this.Name = "frmBasicTextEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Basic Text Editor";
            this.toolTip1.SetToolTip(this, "Basic text editor application");
            this.Load += new System.EventHandler(this.frmBasicTextEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTextEntry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuEditFont;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelectAll;
    }
}

