
namespace Week12_MDI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewWindowMin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewWindowNorm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewWindowMax = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewListOfTroopers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewAddTrooper = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusNumberOfTroopersLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusNumberOfTroopers = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.statusChangeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusChange = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFileNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileNew,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(186, 22);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(186, 22);
            this.menuFileSave.Text = "Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(186, 22);
            this.menuFileSaveAs.Text = "Save As";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(186, 22);
            this.menuFileNew.Text = "Close/New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.menuFileExit.Size = new System.Drawing.Size(186, 22);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewWindow,
            this.menuViewListOfTroopers,
            this.menuViewAddTrooper});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            // 
            // menuViewWindow
            // 
            this.menuViewWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewWindowMin,
            this.menuViewWindowNorm,
            this.menuViewWindowMax});
            this.menuViewWindow.Name = "menuViewWindow";
            this.menuViewWindow.Size = new System.Drawing.Size(180, 22);
            this.menuViewWindow.Text = "Window";
            // 
            // menuViewWindowMin
            // 
            this.menuViewWindowMin.Name = "menuViewWindowMin";
            this.menuViewWindowMin.Size = new System.Drawing.Size(128, 22);
            this.menuViewWindowMin.Text = "Minimize";
            // 
            // menuViewWindowNorm
            // 
            this.menuViewWindowNorm.Name = "menuViewWindowNorm";
            this.menuViewWindowNorm.Size = new System.Drawing.Size(128, 22);
            this.menuViewWindowNorm.Text = "Normalize";
            // 
            // menuViewWindowMax
            // 
            this.menuViewWindowMax.Name = "menuViewWindowMax";
            this.menuViewWindowMax.Size = new System.Drawing.Size(128, 22);
            this.menuViewWindowMax.Text = "Maximize";
            // 
            // menuViewListOfTroopers
            // 
            this.menuViewListOfTroopers.Name = "menuViewListOfTroopers";
            this.menuViewListOfTroopers.Size = new System.Drawing.Size(180, 22);
            this.menuViewListOfTroopers.Text = "List of Troopers";
            this.menuViewListOfTroopers.Click += new System.EventHandler(this.menuViewListOfTroopers_Click);
            // 
            // menuViewAddTrooper
            // 
            this.menuViewAddTrooper.Name = "menuViewAddTrooper";
            this.menuViewAddTrooper.Size = new System.Drawing.Size(180, 22);
            this.menuViewAddTrooper.Text = "Add a New Trooper";
            this.menuViewAddTrooper.Click += new System.EventHandler(this.menuViewAddTrooper_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusNumberOfTroopersLabel,
            this.statusNumberOfTroopers,
            this.toolStripSplitButton1,
            this.statusChangeLabel,
            this.statusChange,
            this.toolStripStatusLabel1,
            this.statusFileNameLabel,
            this.statusFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(912, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusNumberOfTroopersLabel
            // 
            this.statusNumberOfTroopersLabel.Name = "statusNumberOfTroopersLabel";
            this.statusNumberOfTroopersLabel.Size = new System.Drawing.Size(116, 17);
            this.statusNumberOfTroopersLabel.Text = "Number of Troopers:";
            // 
            // statusNumberOfTroopers
            // 
            this.statusNumberOfTroopers.Name = "statusNumberOfTroopers";
            this.statusNumberOfTroopers.Size = new System.Drawing.Size(13, 17);
            this.statusNumberOfTroopers.Text = "0";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(26, 20);
            this.toolStripSplitButton1.Text = "|";
            this.toolStripSplitButton1.ToolTipText = "splitter";
            // 
            // statusChangeLabel
            // 
            this.statusChangeLabel.Name = "statusChangeLabel";
            this.statusChangeLabel.Size = new System.Drawing.Size(54, 17);
            this.statusChangeLabel.Text = "Change: ";
            // 
            // statusChange
            // 
            this.statusChange.Name = "statusChange";
            this.statusChange.Size = new System.Drawing.Size(33, 17);
            this.statusChange.Text = "False";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // statusFileNameLabel
            // 
            this.statusFileNameLabel.Name = "statusFileNameLabel";
            this.statusFileNameLabel.Size = new System.Drawing.Size(60, 17);
            this.statusFileNameLabel.Text = "FileName:";
            // 
            // statusFileName
            // 
            this.statusFileName.Name = "statusFileName";
            this.statusFileName.Size = new System.Drawing.Size(10, 17);
            this.statusFileName.Text = " ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Week12_MDI.Properties.Resources.stormtrooper_wallpaper_027___2880x1800;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 586);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Storm Troopers Inventory";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuViewWindow;
        private System.Windows.Forms.ToolStripMenuItem menuViewWindowMin;
        private System.Windows.Forms.ToolStripMenuItem menuViewWindowNorm;
        private System.Windows.Forms.ToolStripMenuItem menuViewWindowMax;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusNumberOfTroopersLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusNumberOfTroopers;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel statusChangeLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusChange;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusFileNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusFileName;
        private System.Windows.Forms.ToolStripMenuItem menuViewListOfTroopers;
        private System.Windows.Forms.ToolStripMenuItem menuViewAddTrooper;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

