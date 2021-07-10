
namespace Ice_Class_Creation
{
    partial class frmFelineOverlords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFelineOverlords));
            this.dgvFelineOverlords = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.chkFixed = new System.Windows.Forms.CheckBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblColoring = new System.Windows.Forms.Label();
            this.txbBreed = new System.Windows.Forms.TextBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPickColoring = new System.Windows.Forms.Label();
            this.rbtSexFemale = new System.Windows.Forms.RadioButton();
            this.rbtSexMale = new System.Windows.Forms.RadioButton();
            this.grbSexPick = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tipToolFeline = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFelineOverlords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFelineOverlords
            // 
            this.dgvFelineOverlords.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvFelineOverlords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFelineOverlords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFelineOverlords.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvFelineOverlords.Location = new System.Drawing.Point(364, 106);
            this.dgvFelineOverlords.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFelineOverlords.Name = "dgvFelineOverlords";
            this.dgvFelineOverlords.RowTemplate.Height = 25;
            this.dgvFelineOverlords.Size = new System.Drawing.Size(543, 343);
            this.dgvFelineOverlords.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(428, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 67);
            this.label1.TabIndex = 16;
            this.label1.Text = "Feline Overlords";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(808, 487);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 50);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExitClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(135, 235);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 34);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnResetClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 235);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(37, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(119, 24);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 30);
            this.txbName.TabIndex = 2;
            this.tipToolFeline.SetToolTip(this.txbName, "Enter name of feline overlord");
            // 
            // chkFixed
            // 
            this.chkFixed.AutoSize = true;
            this.chkFixed.BackColor = System.Drawing.SystemColors.MenuText;
            this.chkFixed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFixed.ForeColor = System.Drawing.SystemColors.Window;
            this.chkFixed.Location = new System.Drawing.Point(27, 188);
            this.chkFixed.Name = "chkFixed";
            this.chkFixed.Size = new System.Drawing.Size(104, 27);
            this.chkFixed.TabIndex = 11;
            this.chkFixed.Text = "Fixed? :   ";
            this.tipToolFeline.SetToolTip(this.chkFixed, "Check if feline is fixed.");
            this.chkFixed.UseVisualStyleBackColor = false;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblSex.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSex.Location = new System.Drawing.Point(43, 67);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(43, 23);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Sex:";
            // 
            // lblColoring
            // 
            this.lblColoring.AutoSize = true;
            this.lblColoring.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblColoring.ForeColor = System.Drawing.SystemColors.Window;
            this.lblColoring.Location = new System.Drawing.Point(23, 109);
            this.lblColoring.Name = "lblColoring";
            this.lblColoring.Size = new System.Drawing.Size(83, 23);
            this.lblColoring.TabIndex = 6;
            this.lblColoring.Text = "Colouring:";
            // 
            // txbBreed
            // 
            this.txbBreed.Location = new System.Drawing.Point(119, 150);
            this.txbBreed.Name = "txbBreed";
            this.txbBreed.Size = new System.Drawing.Size(100, 30);
            this.txbBreed.TabIndex = 10;
            this.tipToolFeline.SetToolTip(this.txbBreed, "Enter breed of feline");
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblBreed.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBreed.Location = new System.Drawing.Point(35, 153);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(58, 23);
            this.lblBreed.TabIndex = 9;
            this.lblBreed.Text = "Breed:";
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(174, 107);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(45, 30);
            this.btnSetColor.TabIndex = 8;
            this.btnSetColor.Text = "S&et";
            this.tipToolFeline.SetToolTip(this.btnSetColor, "Press to confirm colouring selection");
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColoring_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuText;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(6, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Add Overlord";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Controls.Add(this.lblPickColoring);
            this.groupBox1.Controls.Add(this.rbtSexFemale);
            this.groupBox1.Controls.Add(this.rbtSexMale);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSetColor);
            this.groupBox1.Controls.Add(this.txbBreed);
            this.groupBox1.Controls.Add(this.lblBreed);
            this.groupBox1.Controls.Add(this.lblColoring);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.chkFixed);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.grbSexPick);
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblPickColoring
            // 
            this.lblPickColoring.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblPickColoring.ForeColor = System.Drawing.Color.Transparent;
            this.lblPickColoring.Location = new System.Drawing.Point(122, 107);
            this.lblPickColoring.Name = "lblPickColoring";
            this.lblPickColoring.Size = new System.Drawing.Size(33, 30);
            this.lblPickColoring.TabIndex = 7;
            this.tipToolFeline.SetToolTip(this.lblPickColoring, "Use Color Dialog box to select colouring");
            // 
            // rbtSexFemale
            // 
            this.rbtSexFemale.ForeColor = System.Drawing.SystemColors.Window;
            this.rbtSexFemale.Location = new System.Drawing.Point(174, 67);
            this.rbtSexFemale.Name = "rbtSexFemale";
            this.rbtSexFemale.Size = new System.Drawing.Size(94, 27);
            this.rbtSexFemale.TabIndex = 5;
            this.rbtSexFemale.Text = "Female";
            this.tipToolFeline.SetToolTip(this.rbtSexFemale, "Select if feline is female");
            this.rbtSexFemale.UseVisualStyleBackColor = true;
            // 
            // rbtSexMale
            // 
            this.rbtSexMale.ForeColor = System.Drawing.SystemColors.Window;
            this.rbtSexMale.Location = new System.Drawing.Point(109, 67);
            this.rbtSexMale.Name = "rbtSexMale";
            this.rbtSexMale.Size = new System.Drawing.Size(64, 27);
            this.rbtSexMale.TabIndex = 4;
            this.rbtSexMale.Text = "Male";
            this.tipToolFeline.SetToolTip(this.rbtSexMale, "Select if feline is male");
            this.rbtSexMale.UseVisualStyleBackColor = true;
            // 
            // grbSexPick
            // 
            this.grbSexPick.Location = new System.Drawing.Point(105, 59);
            this.grbSexPick.Name = "grbSexPick";
            this.grbSexPick.Size = new System.Drawing.Size(159, 37);
            this.grbSexPick.TabIndex = 14;
            this.grbSexPick.TabStop = false;
            // 
            // frmFelineOverlords
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(971, 558);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFelineOverlords);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFelineOverlords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feline Overlords";
            this.tipToolFeline.SetToolTip(this, "Application to register feline overlords");
            this.Load += new System.EventHandler(this.frmFelineOverlords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFelineOverlords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFelineOverlords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.CheckBox chkFixed;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblColoring;
        private System.Windows.Forms.TextBox txbBreed;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip tipToolFeline;
        private System.Windows.Forms.RadioButton rbtSexMale;
        private System.Windows.Forms.RadioButton rbtSexFemale;
        private System.Windows.Forms.Label lblPickColoring;
        private System.Windows.Forms.GroupBox grbSexPick;
    }
}

