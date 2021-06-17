
namespace Lab1
{
    partial class AverageCasesForm
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
            this.textBoxCaseEntry = new System.Windows.Forms.TextBox();
            this.labelCasePrompt = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxAverageOutput = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxCaseList = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBoxCaseEntry
            // 
            this.textBoxCaseEntry.AcceptsReturn = true;
            this.textBoxCaseEntry.AcceptsTab = true;
            this.textBoxCaseEntry.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCaseEntry.Location = new System.Drawing.Point(137, 19);
            this.textBoxCaseEntry.Name = "textBoxCaseEntry";
            this.textBoxCaseEntry.Size = new System.Drawing.Size(137, 31);
            this.textBoxCaseEntry.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxCaseEntry, "Enter this days number of cases");
            // 
            // labelCasePrompt
            // 
            this.labelCasePrompt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCasePrompt.Location = new System.Drawing.Point(30, 22);
            this.labelCasePrompt.Name = "labelCasePrompt";
            this.labelCasePrompt.Size = new System.Drawing.Size(101, 23);
            this.labelCasePrompt.TabIndex = 0;
            this.labelCasePrompt.Text = "Daily &Cases:";
            this.labelCasePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDay
            // 
            this.labelDay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDay.Location = new System.Drawing.Point(280, 22);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(54, 23);
            this.labelDay.TabIndex = 2;
            this.labelDay.Tag = "";
            this.labelDay.Text = "Day 1";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAverageOutput
            // 
            this.textBoxAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAverageOutput.Location = new System.Drawing.Point(36, 338);
            this.textBoxAverageOutput.Name = "textBoxAverageOutput";
            this.textBoxAverageOutput.ReadOnly = true;
            this.textBoxAverageOutput.Size = new System.Drawing.Size(298, 23);
            this.textBoxAverageOutput.TabIndex = 4;
            this.textBoxAverageOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.Location = new System.Drawing.Point(30, 385);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 29);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to input current day case total");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.EnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(136, 385);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 29);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(259, 385);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 29);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // textBoxCaseList
            // 
            this.textBoxCaseList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxCaseList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCaseList.Location = new System.Drawing.Point(36, 63);
            this.textBoxCaseList.Multiline = true;
            this.textBoxCaseList.Name = "textBoxCaseList";
            this.textBoxCaseList.ReadOnly = true;
            this.textBoxCaseList.Size = new System.Drawing.Size(296, 252);
            this.textBoxCaseList.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxCaseList, "Displays this week\'s cases in order of entry/day.");
            // 
            // AverageCasesForm
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(373, 432);
            this.Controls.Add(this.textBoxCaseList);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxAverageOutput);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelCasePrompt);
            this.Controls.Add(this.textBoxCaseEntry);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AverageCasesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Cases - Katherine Bellman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCaseEntry;
        private System.Windows.Forms.Label labelCasePrompt;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxCaseList;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

