
namespace W7_Demo_Classes1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCreator = new System.Windows.Forms.GroupBox();
            this.btnResetDroid = new System.Windows.Forms.Button();
            this.btnSaveDroid = new System.Windows.Forms.Button();
            this.btnSecondaryColour = new System.Windows.Forms.Button();
            this.lblSecondaryColour = new System.Windows.Forms.Label();
            this.lblSecondColourLabel = new System.Windows.Forms.Label();
            this.btnSetPrimaryColour = new System.Windows.Forms.Button();
            this.lblPrimaryColour = new System.Windows.Forms.Label();
            this.lblColour1Label = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.chkInService = new System.Windows.Forms.CheckBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDesignationLabel = new System.Windows.Forms.Label();
            this.grpSavedDroids = new System.Windows.Forms.GroupBox();
            this.grpDroidDetails = new System.Windows.Forms.GroupBox();
            this.lblDetailsSecondaryColour = new System.Windows.Forms.Label();
            this.lblDetailsPrimaryColour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDetailsOwner = new System.Windows.Forms.Label();
            this.lblOwnerLabel = new System.Windows.Forms.Label();
            this.chkDetailsInService = new System.Windows.Forms.CheckBox();
            this.lblDetailsDesignation = new System.Windows.Forms.Label();
            this.lboxDroids = new System.Windows.Forms.ListBox();
            this.lblDroidsTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.colorDialogMain = new System.Windows.Forms.ColorDialog();
            this.btnClearDroids = new System.Windows.Forms.Button();
            this.grpCreator.SuspendLayout();
            this.grpSavedDroids.SuspendLayout();
            this.grpDroidDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(-2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(919, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Droid Factory";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCreator
            // 
            this.grpCreator.BackColor = System.Drawing.Color.Transparent;
            this.grpCreator.Controls.Add(this.btnResetDroid);
            this.grpCreator.Controls.Add(this.btnSaveDroid);
            this.grpCreator.Controls.Add(this.btnSecondaryColour);
            this.grpCreator.Controls.Add(this.lblSecondaryColour);
            this.grpCreator.Controls.Add(this.lblSecondColourLabel);
            this.grpCreator.Controls.Add(this.btnSetPrimaryColour);
            this.grpCreator.Controls.Add(this.lblPrimaryColour);
            this.grpCreator.Controls.Add(this.lblColour1Label);
            this.grpCreator.Controls.Add(this.txtOwner);
            this.grpCreator.Controls.Add(this.lblOwner);
            this.grpCreator.Controls.Add(this.chkInService);
            this.grpCreator.Controls.Add(this.txtDesignation);
            this.grpCreator.Controls.Add(this.lblDesignationLabel);
            this.grpCreator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCreator.Location = new System.Drawing.Point(24, 53);
            this.grpCreator.Name = "grpCreator";
            this.grpCreator.Size = new System.Drawing.Size(463, 265);
            this.grpCreator.TabIndex = 1;
            this.grpCreator.TabStop = false;
            this.grpCreator.Text = "Droid Creator";
            // 
            // btnResetDroid
            // 
            this.btnResetDroid.Location = new System.Drawing.Point(19, 202);
            this.btnResetDroid.Name = "btnResetDroid";
            this.btnResetDroid.Size = new System.Drawing.Size(75, 38);
            this.btnResetDroid.TabIndex = 12;
            this.btnResetDroid.Text = "&Reset";
            this.btnResetDroid.UseVisualStyleBackColor = true;
            this.btnResetDroid.Click += new System.EventHandler(this.btnResetDroid_Click);
            // 
            // btnSaveDroid
            // 
            this.btnSaveDroid.Location = new System.Drawing.Point(334, 202);
            this.btnSaveDroid.Name = "btnSaveDroid";
            this.btnSaveDroid.Size = new System.Drawing.Size(106, 39);
            this.btnSaveDroid.TabIndex = 11;
            this.btnSaveDroid.Text = "&Save Droid";
            this.btnSaveDroid.UseVisualStyleBackColor = true;
            this.btnSaveDroid.Click += new System.EventHandler(this.btnSaveDroid_Click);
            // 
            // btnSecondaryColour
            // 
            this.btnSecondaryColour.Location = new System.Drawing.Point(369, 139);
            this.btnSecondaryColour.Name = "btnSecondaryColour";
            this.btnSecondaryColour.Size = new System.Drawing.Size(45, 38);
            this.btnSecondaryColour.TabIndex = 10;
            this.btnSecondaryColour.Text = "Set";
            this.btnSecondaryColour.UseVisualStyleBackColor = true;
            this.btnSecondaryColour.Click += new System.EventHandler(this.btnSecondaryColour_Click);
            // 
            // lblSecondaryColour
            // 
            this.lblSecondaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblSecondaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondaryColour.Location = new System.Drawing.Point(319, 139);
            this.lblSecondaryColour.Name = "lblSecondaryColour";
            this.lblSecondaryColour.Size = new System.Drawing.Size(43, 38);
            this.lblSecondaryColour.TabIndex = 9;
            // 
            // lblSecondColourLabel
            // 
            this.lblSecondColourLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondColourLabel.Location = new System.Drawing.Point(235, 139);
            this.lblSecondColourLabel.Name = "lblSecondColourLabel";
            this.lblSecondColourLabel.Size = new System.Drawing.Size(88, 52);
            this.lblSecondColourLabel.TabIndex = 8;
            this.lblSecondColourLabel.Text = "Secondary Colour";
            // 
            // btnSetPrimaryColour
            // 
            this.btnSetPrimaryColour.Location = new System.Drawing.Point(141, 139);
            this.btnSetPrimaryColour.Name = "btnSetPrimaryColour";
            this.btnSetPrimaryColour.Size = new System.Drawing.Size(45, 38);
            this.btnSetPrimaryColour.TabIndex = 7;
            this.btnSetPrimaryColour.Text = "Set";
            this.btnSetPrimaryColour.UseVisualStyleBackColor = true;
            this.btnSetPrimaryColour.Click += new System.EventHandler(this.btnSetPrimaryColour_Click);
            // 
            // lblPrimaryColour
            // 
            this.lblPrimaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblPrimaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrimaryColour.Location = new System.Drawing.Point(91, 139);
            this.lblPrimaryColour.Name = "lblPrimaryColour";
            this.lblPrimaryColour.Size = new System.Drawing.Size(43, 38);
            this.lblPrimaryColour.TabIndex = 6;
            // 
            // lblColour1Label
            // 
            this.lblColour1Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColour1Label.Location = new System.Drawing.Point(19, 139);
            this.lblColour1Label.Name = "lblColour1Label";
            this.lblColour1Label.Size = new System.Drawing.Size(76, 52);
            this.lblColour1Label.TabIndex = 5;
            this.lblColour1Label.Text = "Primary Colour";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(129, 82);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(311, 27);
            this.txtOwner.TabIndex = 4;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOwner.Location = new System.Drawing.Point(19, 85);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(42, 15);
            this.lblOwner.TabIndex = 3;
            this.lblOwner.Text = "Owner";
            // 
            // chkInService
            // 
            this.chkInService.AutoSize = true;
            this.chkInService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkInService.Location = new System.Drawing.Point(314, 45);
            this.chkInService.Name = "chkInService";
            this.chkInService.Size = new System.Drawing.Size(76, 19);
            this.chkInService.TabIndex = 2;
            this.chkInService.Text = "In Service";
            this.chkInService.UseVisualStyleBackColor = true;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(129, 41);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(162, 27);
            this.txtDesignation.TabIndex = 1;
            // 
            // lblDesignationLabel
            // 
            this.lblDesignationLabel.AutoSize = true;
            this.lblDesignationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesignationLabel.Location = new System.Drawing.Point(19, 44);
            this.lblDesignationLabel.Name = "lblDesignationLabel";
            this.lblDesignationLabel.Size = new System.Drawing.Size(70, 15);
            this.lblDesignationLabel.TabIndex = 0;
            this.lblDesignationLabel.Text = "Designation";
            // 
            // grpSavedDroids
            // 
            this.grpSavedDroids.BackColor = System.Drawing.Color.Transparent;
            this.grpSavedDroids.Controls.Add(this.grpDroidDetails);
            this.grpSavedDroids.Controls.Add(this.lboxDroids);
            this.grpSavedDroids.Controls.Add(this.lblDroidsTitle);
            this.grpSavedDroids.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSavedDroids.Location = new System.Drawing.Point(24, 332);
            this.grpSavedDroids.Name = "grpSavedDroids";
            this.grpSavedDroids.Size = new System.Drawing.Size(463, 293);
            this.grpSavedDroids.TabIndex = 2;
            this.grpSavedDroids.TabStop = false;
            this.grpSavedDroids.Text = "Saved Droids";
            // 
            // grpDroidDetails
            // 
            this.grpDroidDetails.Controls.Add(this.lblDetailsSecondaryColour);
            this.grpDroidDetails.Controls.Add(this.lblDetailsPrimaryColour);
            this.grpDroidDetails.Controls.Add(this.label3);
            this.grpDroidDetails.Controls.Add(this.label2);
            this.grpDroidDetails.Controls.Add(this.lblDetailsOwner);
            this.grpDroidDetails.Controls.Add(this.lblOwnerLabel);
            this.grpDroidDetails.Controls.Add(this.chkDetailsInService);
            this.grpDroidDetails.Controls.Add(this.lblDetailsDesignation);
            this.grpDroidDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDroidDetails.Location = new System.Drawing.Point(172, 36);
            this.grpDroidDetails.Name = "grpDroidDetails";
            this.grpDroidDetails.Size = new System.Drawing.Size(268, 236);
            this.grpDroidDetails.TabIndex = 2;
            this.grpDroidDetails.TabStop = false;
            this.grpDroidDetails.Text = "Droid Details";
            // 
            // lblDetailsSecondaryColour
            // 
            this.lblDetailsSecondaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblDetailsSecondaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDetailsSecondaryColour.Location = new System.Drawing.Point(145, 156);
            this.lblDetailsSecondaryColour.Name = "lblDetailsSecondaryColour";
            this.lblDetailsSecondaryColour.Size = new System.Drawing.Size(43, 38);
            this.lblDetailsSecondaryColour.TabIndex = 9;
            // 
            // lblDetailsPrimaryColour
            // 
            this.lblDetailsPrimaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblDetailsPrimaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDetailsPrimaryColour.Location = new System.Drawing.Point(23, 156);
            this.lblDetailsPrimaryColour.Name = "lblDetailsPrimaryColour";
            this.lblDetailsPrimaryColour.Size = new System.Drawing.Size(43, 38);
            this.lblDetailsPrimaryColour.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Secondary Colour";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Primary Colour";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetailsOwner
            // 
            this.lblDetailsOwner.AutoSize = true;
            this.lblDetailsOwner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetailsOwner.Location = new System.Drawing.Point(18, 87);
            this.lblDetailsOwner.Name = "lblDetailsOwner";
            this.lblDetailsOwner.Size = new System.Drawing.Size(45, 15);
            this.lblDetailsOwner.TabIndex = 3;
            this.lblDetailsOwner.Text = "Owner";
            // 
            // lblOwnerLabel
            // 
            this.lblOwnerLabel.AutoSize = true;
            this.lblOwnerLabel.Location = new System.Drawing.Point(18, 68);
            this.lblOwnerLabel.Name = "lblOwnerLabel";
            this.lblOwnerLabel.Size = new System.Drawing.Size(42, 15);
            this.lblOwnerLabel.TabIndex = 2;
            this.lblOwnerLabel.Text = "Owner";
            // 
            // chkDetailsInService
            // 
            this.chkDetailsInService.AutoSize = true;
            this.chkDetailsInService.Enabled = false;
            this.chkDetailsInService.Location = new System.Drawing.Point(18, 42);
            this.chkDetailsInService.Name = "chkDetailsInService";
            this.chkDetailsInService.Size = new System.Drawing.Size(76, 19);
            this.chkDetailsInService.TabIndex = 1;
            this.chkDetailsInService.Text = "In Service";
            this.chkDetailsInService.UseVisualStyleBackColor = true;
            // 
            // lblDetailsDesignation
            // 
            this.lblDetailsDesignation.AutoSize = true;
            this.lblDetailsDesignation.Location = new System.Drawing.Point(18, 23);
            this.lblDetailsDesignation.Name = "lblDetailsDesignation";
            this.lblDetailsDesignation.Size = new System.Drawing.Size(70, 15);
            this.lblDetailsDesignation.TabIndex = 0;
            this.lblDetailsDesignation.Text = "Designation";
            // 
            // lboxDroids
            // 
            this.lboxDroids.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxDroids.FormattingEnabled = true;
            this.lboxDroids.ItemHeight = 15;
            this.lboxDroids.Location = new System.Drawing.Point(14, 43);
            this.lboxDroids.Name = "lboxDroids";
            this.lboxDroids.Size = new System.Drawing.Size(142, 229);
            this.lboxDroids.TabIndex = 1;
            this.lboxDroids.SelectedIndexChanged += new System.EventHandler(this.lboxDroids_SelectedIndexChanged);
            // 
            // lblDroidsTitle
            // 
            this.lblDroidsTitle.AutoSize = true;
            this.lblDroidsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDroidsTitle.Location = new System.Drawing.Point(15, 25);
            this.lblDroidsTitle.Name = "lblDroidsTitle";
            this.lblDroidsTitle.Size = new System.Drawing.Size(43, 15);
            this.lblDroidsTitle.TabIndex = 0;
            this.lblDroidsTitle.Text = "Droids";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(827, 587);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearDroids
            // 
            this.btnClearDroids.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClearDroids.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearDroids.ForeColor = System.Drawing.Color.White;
            this.btnClearDroids.Location = new System.Drawing.Point(746, 588);
            this.btnClearDroids.Name = "btnClearDroids";
            this.btnClearDroids.Size = new System.Drawing.Size(75, 37);
            this.btnClearDroids.TabIndex = 4;
            this.btnClearDroids.Text = "&Clear";
            this.btnClearDroids.UseVisualStyleBackColor = false;
            this.btnClearDroids.Click += new System.EventHandler(this.btnClearDroids_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(914, 637);
            this.Controls.Add(this.btnClearDroids);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpSavedDroids);
            this.Controls.Add(this.grpCreator);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Droid Factory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCreator.ResumeLayout(false);
            this.grpCreator.PerformLayout();
            this.grpSavedDroids.ResumeLayout(false);
            this.grpSavedDroids.PerformLayout();
            this.grpDroidDetails.ResumeLayout(false);
            this.grpDroidDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCreator;
        private System.Windows.Forms.Button btnSaveDroid;
        private System.Windows.Forms.Button btnSecondaryColour;
        private System.Windows.Forms.Label lblSecondaryColour;
        private System.Windows.Forms.Label lblSecondColourLabel;
        private System.Windows.Forms.Button btnSetPrimaryColour;
        private System.Windows.Forms.Label lblPrimaryColour;
        private System.Windows.Forms.Label lblColour1Label;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.CheckBox chkInService;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDesignationLabel;
        private System.Windows.Forms.GroupBox grpSavedDroids;
        private System.Windows.Forms.GroupBox grpDroidDetails;
        private System.Windows.Forms.Label lblDetailsDesignation;
        private System.Windows.Forms.ListBox lboxDroids;
        private System.Windows.Forms.Label lblDroidsTitle;
        private System.Windows.Forms.Button btnResetDroid;
        private System.Windows.Forms.Label lblDetailsSecondaryColour;
        private System.Windows.Forms.Label lblDetailsPrimaryColour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetailsOwner;
        private System.Windows.Forms.Label lblOwnerLabel;
        private System.Windows.Forms.CheckBox chkDetailsInService;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColorDialog colorDialogMain;
        private System.Windows.Forms.Button btnClearDroids;
    }
}

