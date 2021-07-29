
namespace Week12_MDI
{
    partial class frmAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEdit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkDefective = new System.Windows.Forms.CheckBox();
            this.btnSetEyeColour = new System.Windows.Forms.Button();
            this.lblEyeColour = new System.Windows.Forms.Label();
            this.lblSecondColourLabel = new System.Windows.Forms.Label();
            this.btnSetHairColour = new System.Windows.Forms.Button();
            this.lblHairColour = new System.Windows.Forms.Label();
            this.lblColour1Label = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.lblBorn = new System.Windows.Forms.Label();
            this.cboPlanets = new System.Windows.Forms.ComboBox();
            this.lblHomeWorld = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.nudDesignation = new System.Windows.Forms.NumericUpDown();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesignation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSaveExit);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.chkDefective);
            this.groupBox1.Controls.Add(this.btnSetEyeColour);
            this.groupBox1.Controls.Add(this.lblEyeColour);
            this.groupBox1.Controls.Add(this.lblSecondColourLabel);
            this.groupBox1.Controls.Add(this.btnSetHairColour);
            this.groupBox1.Controls.Add(this.lblHairColour);
            this.groupBox1.Controls.Add(this.lblColour1Label);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.dtpBorn);
            this.groupBox1.Controls.Add(this.lblBorn);
            this.groupBox1.Controls.Add(this.cboPlanets);
            this.groupBox1.Controls.Add(this.lblHomeWorld);
            this.groupBox1.Controls.Add(this.txtNickName);
            this.groupBox1.Controls.Add(this.lblNickName);
            this.groupBox1.Controls.Add(this.nudDesignation);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit";
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.ForeColor = System.Drawing.Color.Black;
            this.btnSaveExit.Location = new System.Drawing.Point(364, 205);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(75, 43);
            this.btnSaveExit.TabIndex = 20;
            this.btnSaveExit.Text = "&Save and Exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(194, 205);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 43);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(279, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 43);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "&Save and Continue";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkDefective
            // 
            this.chkDefective.AutoSize = true;
            this.chkDefective.Location = new System.Drawing.Point(103, 217);
            this.chkDefective.Name = "chkDefective";
            this.chkDefective.Size = new System.Drawing.Size(75, 19);
            this.chkDefective.TabIndex = 17;
            this.chkDefective.Text = "Defective";
            this.chkDefective.UseVisualStyleBackColor = true;
            // 
            // btnSetEyeColour
            // 
            this.btnSetEyeColour.ForeColor = System.Drawing.Color.Black;
            this.btnSetEyeColour.Location = new System.Drawing.Point(385, 63);
            this.btnSetEyeColour.Name = "btnSetEyeColour";
            this.btnSetEyeColour.Size = new System.Drawing.Size(45, 38);
            this.btnSetEyeColour.TabIndex = 16;
            this.btnSetEyeColour.Text = "Set";
            this.btnSetEyeColour.UseVisualStyleBackColor = true;
            this.btnSetEyeColour.Click += new System.EventHandler(this.btnSetEyeColour_Click);
            // 
            // lblEyeColour
            // 
            this.lblEyeColour.BackColor = System.Drawing.Color.Gray;
            this.lblEyeColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEyeColour.Location = new System.Drawing.Point(335, 63);
            this.lblEyeColour.Name = "lblEyeColour";
            this.lblEyeColour.Size = new System.Drawing.Size(43, 38);
            this.lblEyeColour.TabIndex = 15;
            // 
            // lblSecondColourLabel
            // 
            this.lblSecondColourLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondColourLabel.Location = new System.Drawing.Point(251, 63);
            this.lblSecondColourLabel.Name = "lblSecondColourLabel";
            this.lblSecondColourLabel.Size = new System.Drawing.Size(78, 38);
            this.lblSecondColourLabel.TabIndex = 14;
            this.lblSecondColourLabel.Text = "Eye Colour";
            this.lblSecondColourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetHairColour
            // 
            this.btnSetHairColour.ForeColor = System.Drawing.Color.Black;
            this.btnSetHairColour.Location = new System.Drawing.Point(385, 19);
            this.btnSetHairColour.Name = "btnSetHairColour";
            this.btnSetHairColour.Size = new System.Drawing.Size(45, 38);
            this.btnSetHairColour.TabIndex = 13;
            this.btnSetHairColour.Text = "Set";
            this.btnSetHairColour.UseVisualStyleBackColor = true;
            this.btnSetHairColour.Click += new System.EventHandler(this.btnSetHairColour_Click);
            // 
            // lblHairColour
            // 
            this.lblHairColour.BackColor = System.Drawing.Color.Gray;
            this.lblHairColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHairColour.Location = new System.Drawing.Point(335, 19);
            this.lblHairColour.Name = "lblHairColour";
            this.lblHairColour.Size = new System.Drawing.Size(43, 38);
            this.lblHairColour.TabIndex = 12;
            // 
            // lblColour1Label
            // 
            this.lblColour1Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColour1Label.Location = new System.Drawing.Point(251, 19);
            this.lblColour1Label.Name = "lblColour1Label";
            this.lblColour1Label.Size = new System.Drawing.Size(76, 38);
            this.lblColour1Label.TabIndex = 11;
            this.lblColour1Label.Text = "Hair Colour";
            this.lblColour1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(103, 174);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 23);
            this.txtUnit.TabIndex = 9;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(21, 177);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 15);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit";
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(103, 133);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(163, 23);
            this.dtpBorn.TabIndex = 7;
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Location = new System.Drawing.Point(21, 139);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(32, 15);
            this.lblBorn.TabIndex = 6;
            this.lblBorn.Text = "Born";
            // 
            // cboPlanets
            // 
            this.cboPlanets.FormattingEnabled = true;
            this.cboPlanets.Location = new System.Drawing.Point(103, 98);
            this.cboPlanets.Name = "cboPlanets";
            this.cboPlanets.Size = new System.Drawing.Size(121, 23);
            this.cboPlanets.TabIndex = 5;
            // 
            // lblHomeWorld
            // 
            this.lblHomeWorld.AutoSize = true;
            this.lblHomeWorld.Location = new System.Drawing.Point(21, 101);
            this.lblHomeWorld.Name = "lblHomeWorld";
            this.lblHomeWorld.Size = new System.Drawing.Size(75, 15);
            this.lblHomeWorld.TabIndex = 4;
            this.lblHomeWorld.Text = "Home World";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(103, 60);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(100, 23);
            this.txtNickName.TabIndex = 3;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(21, 63);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(66, 15);
            this.lblNickName.TabIndex = 2;
            this.lblNickName.Text = "Nick Name";
            // 
            // nudDesignation
            // 
            this.nudDesignation.Location = new System.Drawing.Point(103, 23);
            this.nudDesignation.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDesignation.Name = "nudDesignation";
            this.nudDesignation.Size = new System.Drawing.Size(85, 23);
            this.nudDesignation.TabIndex = 1;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(21, 25);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(70, 15);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "Designation";
            // 
            // frmAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(467, 281);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEdit";
            this.Text = "Storm Trooper Editor";
            this.Load += new System.EventHandler(this.frmAddEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesignation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkDefective;
        private System.Windows.Forms.Button btnSetEyeColour;
        private System.Windows.Forms.Label lblEyeColour;
        private System.Windows.Forms.Label lblSecondColourLabel;
        private System.Windows.Forms.Button btnSetHairColour;
        private System.Windows.Forms.Label lblHairColour;
        private System.Windows.Forms.Label lblColour1Label;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.ComboBox cboPlanets;
        private System.Windows.Forms.Label lblHomeWorld;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.NumericUpDown nudDesignation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}