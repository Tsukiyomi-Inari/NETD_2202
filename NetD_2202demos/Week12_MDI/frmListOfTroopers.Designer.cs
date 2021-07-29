
namespace Week12_MDI
{
    partial class frmListOfTroopers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOfTroopers));
            this.dgvTroopers = new System.Windows.Forms.DataGridView();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefective = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colHairColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEyeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblToolFilterByUnit = new System.Windows.Forms.ToolStripLabel();
            this.cboUnits = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTroopers)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTroopers
            // 
            this.dgvTroopers.AllowUserToAddRows = false;
            this.dgvTroopers.AllowUserToDeleteRows = false;
            this.dgvTroopers.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTroopers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTroopers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDesignation,
            this.colNickName,
            this.dataGridViewTextBoxColumn1,
            this.colBorn,
            this.dataGridViewTextBoxColumn2,
            this.colDefective,
            this.colHairColor,
            this.colEyeColor});
            this.dgvTroopers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTroopers.Location = new System.Drawing.Point(0, 26);
            this.dgvTroopers.MultiSelect = false;
            this.dgvTroopers.Name = "dgvTroopers";
            this.dgvTroopers.ReadOnly = true;
            this.dgvTroopers.RowHeadersVisible = false;
            this.dgvTroopers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgvTroopers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTroopers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvTroopers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.dgvTroopers.RowTemplate.Height = 25;
            this.dgvTroopers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTroopers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTroopers.ShowEditingIcon = false;
            this.dgvTroopers.Size = new System.Drawing.Size(800, 424);
            this.dgvTroopers.TabIndex = 2;
            this.dgvTroopers.VirtualMode = true;
            // 
            // colDesignation
            // 
            this.colDesignation.DataPropertyName = "Designation";
            this.colDesignation.HeaderText = "Designation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            // 
            // colNickName
            // 
            this.colNickName.DataPropertyName = "NickName";
            this.colNickName.HeaderText = "Nick Name";
            this.colNickName.Name = "colNickName";
            this.colNickName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HomeWorld";
            this.dataGridViewTextBoxColumn1.HeaderText = "Home World";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colBorn
            // 
            this.colBorn.DataPropertyName = "Born";
            this.colBorn.HeaderText = "Born";
            this.colBorn.Name = "colBorn";
            this.colBorn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn2.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // colDefective
            // 
            this.colDefective.DataPropertyName = "Defective";
            this.colDefective.HeaderText = "Defective";
            this.colDefective.Name = "colDefective";
            this.colDefective.ReadOnly = true;
            // 
            // colHairColor
            // 
            this.colHairColor.DataPropertyName = "HairColour";
            this.colHairColor.HeaderText = "Hair Colour";
            this.colHairColor.Name = "colHairColor";
            this.colHairColor.ReadOnly = true;
            // 
            // colEyeColor
            // 
            this.colEyeColor.DataPropertyName = "EyeColour";
            this.colEyeColor.HeaderText = "Eye Colour";
            this.colEyeColor.Name = "colEyeColor";
            this.colEyeColor.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblToolFilterByUnit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblToolFilterByUnit
            // 
            this.lblToolFilterByUnit.Name = "lblToolFilterByUnit";
            this.lblToolFilterByUnit.Size = new System.Drawing.Size(77, 22);
            this.lblToolFilterByUnit.Text = "Filter by Unit:";
            // 
            // cboUnits
            // 
            this.cboUnits.FormattingEnabled = true;
            this.cboUnits.Location = new System.Drawing.Point(93, 2);
            this.cboUnits.Name = "cboUnits";
            this.cboUnits.Size = new System.Drawing.Size(121, 23);
            this.cboUnits.TabIndex = 6;
            this.cboUnits.SelectedIndexChanged += new System.EventHandler(this.cboUnits_SelectedIndexChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(234, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(147, 23);
            this.btnAddNew.TabIndex = 7;
            this.btnAddNew.Text = "&Add a  New Trooper";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmListOfTroopers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cboUnits);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvTroopers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListOfTroopers";
            this.Text = "List of Troopers";
            this.Activated += new System.EventHandler(this.frmActivated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClosed);
            this.Load += new System.EventHandler(this.frmListOfTroopers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTroopers)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTroopers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDefective;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHairColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEyeColor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblToolFilterByUnit;
        private System.Windows.Forms.ComboBox cboUnits;
        private System.Windows.Forms.Button btnAddNew;
    }
}