
namespace RegionAverageWeeklyUnits
{
    partial class RegionAverageWeeklyUnitsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegionAverageWeeklyUnitsForm));
            this.labelCasesEntryPrompt = new System.Windows.Forms.Label();
            this.textBoxCasesInput = new System.Windows.Forms.TextBox();
            this.labelRegion1Prompt = new System.Windows.Forms.Label();
            this.labelRegion2Prompt = new System.Windows.Forms.Label();
            this.labelRegion3Prompt = new System.Windows.Forms.Label();
            this.textBoxRegion1List = new System.Windows.Forms.TextBox();
            this.textBoxRegion2List = new System.Windows.Forms.TextBox();
            this.textBoxRegion3List = new System.Windows.Forms.TextBox();
            this.textBoxRegion1AverageOutput = new System.Windows.Forms.TextBox();
            this.textBoxRegion2AverageOutput = new System.Windows.Forms.TextBox();
            this.textBoxRegion3AverageOutput = new System.Windows.Forms.TextBox();
            this.textBoxTotalOveralAverageOutput = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.regionAverageToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelDayCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCasesEntryPrompt
            // 
            this.labelCasesEntryPrompt.AutoSize = true;
            this.labelCasesEntryPrompt.Location = new System.Drawing.Point(35, 23);
            this.labelCasesEntryPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCasesEntryPrompt.Name = "labelCasesEntryPrompt";
            this.labelCasesEntryPrompt.Size = new System.Drawing.Size(101, 23);
            this.labelCasesEntryPrompt.TabIndex = 0;
            this.labelCasesEntryPrompt.Text = "Daily &Cases:";
            // 
            // textBoxCasesInput
            // 
            this.textBoxCasesInput.AcceptsReturn = true;
            this.textBoxCasesInput.AcceptsTab = true;
            this.textBoxCasesInput.Location = new System.Drawing.Point(135, 20);
            this.textBoxCasesInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCasesInput.Name = "textBoxCasesInput";
            this.textBoxCasesInput.Size = new System.Drawing.Size(141, 31);
            this.textBoxCasesInput.TabIndex = 1;
            this.regionAverageToolTip.SetToolTip(this.textBoxCasesInput, "Enter the number of  cases for the current day and current region. ");
            // 
            // labelRegion1Prompt
            // 
            this.labelRegion1Prompt.Location = new System.Drawing.Point(69, 70);
            this.labelRegion1Prompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegion1Prompt.Name = "labelRegion1Prompt";
            this.labelRegion1Prompt.Size = new System.Drawing.Size(76, 23);
            this.labelRegion1Prompt.TabIndex = 4;
            this.labelRegion1Prompt.Text = "Region &1";
            // 
            // labelRegion2Prompt
            // 
            this.labelRegion2Prompt.Location = new System.Drawing.Point(255, 70);
            this.labelRegion2Prompt.Name = "labelRegion2Prompt";
            this.labelRegion2Prompt.Size = new System.Drawing.Size(76, 23);
            this.labelRegion2Prompt.TabIndex = 6;
            this.labelRegion2Prompt.Text = "Region &2";
            // 
            // labelRegion3Prompt
            // 
            this.labelRegion3Prompt.Location = new System.Drawing.Point(437, 70);
            this.labelRegion3Prompt.Name = "labelRegion3Prompt";
            this.labelRegion3Prompt.Size = new System.Drawing.Size(76, 23);
            this.labelRegion3Prompt.TabIndex = 8;
            this.labelRegion3Prompt.Text = "Region &3";
            // 
            // textBoxRegion1List
            // 
            this.textBoxRegion1List.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRegion1List.Location = new System.Drawing.Point(35, 111);
            this.textBoxRegion1List.Multiline = true;
            this.textBoxRegion1List.Name = "textBoxRegion1List";
            this.textBoxRegion1List.ReadOnly = true;
            this.textBoxRegion1List.Size = new System.Drawing.Size(139, 224);
            this.textBoxRegion1List.TabIndex = 5;
            this.regionAverageToolTip.SetToolTip(this.textBoxRegion1List, "Displays the  entered case units for region 1.");
            // 
            // textBoxRegion2List
            // 
            this.textBoxRegion2List.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRegion2List.Location = new System.Drawing.Point(221, 111);
            this.textBoxRegion2List.Multiline = true;
            this.textBoxRegion2List.Name = "textBoxRegion2List";
            this.textBoxRegion2List.ReadOnly = true;
            this.textBoxRegion2List.Size = new System.Drawing.Size(139, 224);
            this.textBoxRegion2List.TabIndex = 7;
            this.regionAverageToolTip.SetToolTip(this.textBoxRegion2List, "Displays the  entered case units for region 2.");
            // 
            // textBoxRegion3List
            // 
            this.textBoxRegion3List.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRegion3List.Location = new System.Drawing.Point(406, 111);
            this.textBoxRegion3List.Multiline = true;
            this.textBoxRegion3List.Name = "textBoxRegion3List";
            this.textBoxRegion3List.ReadOnly = true;
            this.textBoxRegion3List.Size = new System.Drawing.Size(139, 224);
            this.textBoxRegion3List.TabIndex = 9;
            this.regionAverageToolTip.SetToolTip(this.textBoxRegion3List, "Displays the  entered case units for region 3.");
            // 
            // textBoxRegion1AverageOutput
            // 
            this.textBoxRegion1AverageOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxRegion1AverageOutput.Location = new System.Drawing.Point(28, 361);
            this.textBoxRegion1AverageOutput.MaxLength = 327;
            this.textBoxRegion1AverageOutput.Name = "textBoxRegion1AverageOutput";
            this.textBoxRegion1AverageOutput.ReadOnly = true;
            this.textBoxRegion1AverageOutput.Size = new System.Drawing.Size(156, 31);
            this.textBoxRegion1AverageOutput.TabIndex = 10;
            this.textBoxRegion1AverageOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regionAverageToolTip.SetToolTip(this.textBoxRegion1AverageOutput, "Displays the total average for region 1.");
            // 
            // textBoxRegion2AverageOutput
            // 
            this.textBoxRegion2AverageOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxRegion2AverageOutput.Location = new System.Drawing.Point(214, 361);
            this.textBoxRegion2AverageOutput.MaxLength = 327;
            this.textBoxRegion2AverageOutput.Name = "textBoxRegion2AverageOutput";
            this.textBoxRegion2AverageOutput.ReadOnly = true;
            this.textBoxRegion2AverageOutput.Size = new System.Drawing.Size(156, 31);
            this.textBoxRegion2AverageOutput.TabIndex = 11;
            this.textBoxRegion2AverageOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regionAverageToolTip.SetToolTip(this.textBoxRegion2AverageOutput, "Displays the total average for region 2.");
            // 
            // textBoxRegion3AverageOutput
            // 
            this.textBoxRegion3AverageOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxRegion3AverageOutput.Location = new System.Drawing.Point(399, 361);
            this.textBoxRegion3AverageOutput.MaxLength = 327;
            this.textBoxRegion3AverageOutput.Name = "textBoxRegion3AverageOutput";
            this.textBoxRegion3AverageOutput.ReadOnly = true;
            this.textBoxRegion3AverageOutput.Size = new System.Drawing.Size(156, 31);
            this.textBoxRegion3AverageOutput.TabIndex = 12;
            this.textBoxRegion3AverageOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regionAverageToolTip.SetToolTip(this.textBoxRegion3AverageOutput, "Displays the total average for region 3.");
            // 
            // textBoxTotalOveralAverageOutput
            // 
            this.textBoxTotalOveralAverageOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxTotalOveralAverageOutput.Location = new System.Drawing.Point(35, 422);
            this.textBoxTotalOveralAverageOutput.Name = "textBoxTotalOveralAverageOutput";
            this.textBoxTotalOveralAverageOutput.ReadOnly = true;
            this.textBoxTotalOveralAverageOutput.Size = new System.Drawing.Size(510, 31);
            this.textBoxTotalOveralAverageOutput.TabIndex = 13;
            this.textBoxTotalOveralAverageOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regionAverageToolTip.SetToolTip(this.textBoxTotalOveralAverageOutput, "Displays the average out of all three regions.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(35, 468);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(139, 33);
            this.buttonEnter.TabIndex = 14;
            this.buttonEnter.Text = "&Enter";
            this.regionAverageToolTip.SetToolTip(this.buttonEnter, "Click to input the current case total.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.Calculate_EnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(221, 468);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(139, 33);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "&Reset";
            this.regionAverageToolTip.SetToolTip(this.buttonReset, "Resets the application.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(406, 468);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(139, 33);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "E&xit";
            this.regionAverageToolTip.SetToolTip(this.buttonExit, "Exits application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // labelDayCount
            // 
            this.labelDayCount.AutoSize = true;
            this.labelDayCount.Location = new System.Drawing.Point(489, 20);
            this.labelDayCount.Name = "labelDayCount";
            this.labelDayCount.Size = new System.Drawing.Size(58, 23);
            this.labelDayCount.TabIndex = 3;
            this.labelDayCount.Text = "Day  1";
            this.labelDayCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regionAverageToolTip.SetToolTip(this.labelDayCount, "Current day count for current region.");
            // 
            // RegionAverageWeeklyUnitsForm
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(579, 523);
            this.Controls.Add(this.labelDayCount);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxTotalOveralAverageOutput);
            this.Controls.Add(this.textBoxRegion3AverageOutput);
            this.Controls.Add(this.textBoxRegion2AverageOutput);
            this.Controls.Add(this.textBoxRegion1AverageOutput);
            this.Controls.Add(this.textBoxRegion3List);
            this.Controls.Add(this.textBoxRegion2List);
            this.Controls.Add(this.textBoxRegion1List);
            this.Controls.Add(this.labelRegion3Prompt);
            this.Controls.Add(this.labelRegion2Prompt);
            this.Controls.Add(this.labelRegion1Prompt);
            this.Controls.Add(this.textBoxCasesInput);
            this.Controls.Add(this.labelCasesEntryPrompt);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegionAverageWeeklyUnitsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Units by Region";
            this.Load += new System.EventHandler(this.RegionAverageWeeklyUnitsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCasesEntryPrompt;
        private System.Windows.Forms.TextBox textBoxCasesInput;
        private System.Windows.Forms.Label labelRegion1Prompt;
        private System.Windows.Forms.Label labelRegion2Prompt;
        private System.Windows.Forms.Label labelRegion3Prompt;
        private System.Windows.Forms.TextBox textBoxRegion1List;
        private System.Windows.Forms.TextBox textBoxRegion2List;
        private System.Windows.Forms.TextBox textBoxRegion3List;
        private System.Windows.Forms.TextBox textBoxRegion1AverageOutput;
        private System.Windows.Forms.TextBox textBoxRegion2AverageOutput;
        private System.Windows.Forms.TextBox textBoxRegion3AverageOutput;
        private System.Windows.Forms.TextBox textBoxTotalOveralAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip regionAverageToolTip;
        private System.Windows.Forms.Label labelDayCount;
    }
}

