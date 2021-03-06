
namespace ContactTracer
{
    partial class ContactTracerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracerForm));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.chkContacted = new System.Windows.Forms.CheckBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mtbEMail = new System.Windows.Forms.MaskedTextBox();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.colContacted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbContactInput = new System.Windows.Forms.GroupBox();
            this.ttipContactTracer = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.grbContactInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(67, 33);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(98, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "&First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(167, 30);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(253, 31);
            this.txbFirstName.TabIndex = 0;
            this.ttipContactTracer.SetToolTip(this.txbFirstName, "Input field for contact first name");
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(167, 72);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(253, 31);
            this.txbLastName.TabIndex = 2;
            this.ttipContactTracer.SetToolTip(this.txbLastName, "Input field for contact last name");
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(67, 75);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(98, 23);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "&Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEMail
            // 
            this.lblEMail.Location = new System.Drawing.Point(34, 117);
            this.lblEMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(131, 23);
            this.lblEMail.TabIndex = 3;
            this.lblEMail.Text = "E&mail Address:";
            this.lblEMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 159);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(140, 23);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "&Phone Number:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkContacted
            // 
            this.chkContacted.AutoSize = true;
            this.chkContacted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkContacted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkContacted.Location = new System.Drawing.Point(67, 192);
            this.chkContacted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkContacted.Name = "chkContacted";
            this.chkContacted.Size = new System.Drawing.Size(116, 27);
            this.chkContacted.TabIndex = 5;
            this.chkContacted.Text = "&Contacted?";
            this.chkContacted.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ttipContactTracer.SetToolTip(this.chkContacted, "Checkbox if input has been contacted");
            this.chkContacted.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEnter.Location = new System.Drawing.Point(347, 606);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(107, 35);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "&Enter";
            this.ttipContactTracer.SetToolTip(this.btnEnter, "Add contact input fields to datagrid");
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReset.Location = new System.Drawing.Point(485, 606);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 35);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.ttipContactTracer.SetToolTip(this.btnReset, "Reset contact input fields");
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(623, 606);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.ttipContactTracer.SetToolTip(this.btnExit, "Exits Application");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mtbEMail
            // 
            this.mtbEMail.Location = new System.Drawing.Point(167, 114);
            this.mtbEMail.Name = "mtbEMail";
            this.mtbEMail.Size = new System.Drawing.Size(253, 31);
            this.mtbEMail.TabIndex = 3;
            this.ttipContactTracer.SetToolTip(this.mtbEMail, "Input field for contact e-mail");
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(167, 156);
            this.mtbPhoneNumber.Mask = "(999) 000-0000";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(253, 31);
            this.mtbPhoneNumber.TabIndex = 4;
            this.ttipContactTracer.SetToolTip(this.mtbPhoneNumber, "Input field for contact phone number");
            // 
            // dgvContactList
            // 
            this.dgvContactList.AllowUserToAddRows = false;
            this.dgvContactList.AllowUserToDeleteRows = false;
            this.dgvContactList.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvContactList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContacted,
            this.colFirstName,
            this.colLastName,
            this.colDateTime,
            this.colEMail,
            this.colPhoneNumber,
            this.colId});
            this.dgvContactList.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvContactList.Location = new System.Drawing.Point(18, 249);
            this.dgvContactList.MultiSelect = false;
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.ReadOnly = true;
            this.dgvContactList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvContactList.RowHeadersVisible = false;
            this.dgvContactList.RowTemplate.Height = 25;
            this.dgvContactList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvContactList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactList.ShowEditingIcon = false;
            this.dgvContactList.Size = new System.Drawing.Size(707, 334);
            this.dgvContactList.TabIndex = 6;
            this.ttipContactTracer.SetToolTip(this.dgvContactList, "Inputted contacts datadrid");
            this.dgvContactList.SelectionChanged += new System.EventHandler(this.DvgSelectionChanged);
            // 
            // colContacted
            // 
            this.colContacted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContacted.DataPropertyName = "ContactStatus";
            this.colContacted.FalseValue = "No";
            this.colContacted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colContacted.HeaderText = "Contacted?";
            this.colContacted.IndeterminateValue = "Yes";
            this.colContacted.MinimumWidth = 10;
            this.colContacted.Name = "colContacted";
            this.colContacted.ReadOnly = true;
            this.colContacted.ToolTipText = "Column displaying if contacts have been contacted.";
            // 
            // colFirstName
            // 
            this.colFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "First name";
            this.colFirstName.MinimumWidth = 12;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.ToolTipText = "Contacts First Name Column";
            // 
            // colLastName
            // 
            this.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last name";
            this.colLastName.MinimumWidth = 12;
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.ToolTipText = "Contacts Last Name Column";
            // 
            // colDateTime
            // 
            this.colDateTime.HeaderText = "Date";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            // 
            // colEMail
            // 
            this.colEMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEMail.DataPropertyName = "EMailAddress";
            this.colEMail.HeaderText = "E-Mail";
            this.colEMail.MinimumWidth = 15;
            this.colEMail.Name = "colEMail";
            this.colEMail.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhoneNumber.DataPropertyName = "PhoneNumber";
            this.colPhoneNumber.HeaderText = "Phone Number";
            this.colPhoneNumber.MinimumWidth = 11;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            this.colPhoneNumber.ToolTipText = "Contacts Phone Number Column";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // grbContactInput
            // 
            this.grbContactInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbContactInput.Controls.Add(this.mtbPhoneNumber);
            this.grbContactInput.Controls.Add(this.mtbEMail);
            this.grbContactInput.Controls.Add(this.lblPhoneNumber);
            this.grbContactInput.Controls.Add(this.lblEMail);
            this.grbContactInput.Controls.Add(this.chkContacted);
            this.grbContactInput.Controls.Add(this.txbLastName);
            this.grbContactInput.Controls.Add(this.lblLastName);
            this.grbContactInput.Controls.Add(this.txbFirstName);
            this.grbContactInput.Controls.Add(this.lblFirstName);
            this.grbContactInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grbContactInput.Location = new System.Drawing.Point(144, 11);
            this.grbContactInput.Name = "grbContactInput";
            this.grbContactInput.Size = new System.Drawing.Size(457, 226);
            this.grbContactInput.TabIndex = 0;
            this.grbContactInput.TabStop = false;
            this.ttipContactTracer.SetToolTip(this.grbContactInput, "Contact input fields group");
            // 
            // ContactTracerForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(744, 661);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.grbContactInput);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactTracerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Contact Tacer";
            this.ttipContactTracer.SetToolTip(this, "Contact tacking form application. ");
            this.Load += new System.EventHandler(this.ContactTracerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.grbContactInput.ResumeLayout(false);
            this.grbContactInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.CheckBox chkContacted;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MaskedTextBox mtbEMail;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.GroupBox grbContactInput;
        private System.Windows.Forms.ToolTip ttipContactTracer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colContacted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    }
}

