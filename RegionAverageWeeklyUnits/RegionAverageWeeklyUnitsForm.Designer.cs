
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegionAverageWeeklyUnitsForm));
            this.labelCasesEntry = new System.Windows.Forms.Label();
            this.textBoxCasesInput = new System.Windows.Forms.TextBox();
            this.labelRegion1 = new System.Windows.Forms.Label();
            this.labelRegion2 = new System.Windows.Forms.Label();
            this.labelRegion3 = new System.Windows.Forms.Label();
            this.textBoxRegion1Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCasesEntry
            // 
            this.labelCasesEntry.AutoSize = true;
            this.labelCasesEntry.Location = new System.Drawing.Point(19, 20);
            this.labelCasesEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCasesEntry.Name = "labelCasesEntry";
            this.labelCasesEntry.Size = new System.Drawing.Size(59, 23);
            this.labelCasesEntry.TabIndex = 0;
            this.labelCasesEntry.Text = "&Cases:";
            // 
            // textBoxCasesInput
            // 
            this.textBoxCasesInput.Location = new System.Drawing.Point(86, 20);
            this.textBoxCasesInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCasesInput.Name = "textBoxCasesInput";
            this.textBoxCasesInput.Size = new System.Drawing.Size(141, 31);
            this.textBoxCasesInput.TabIndex = 1;
            // 
            // labelRegion1
            // 
            this.labelRegion1.AutoSize = true;
            this.labelRegion1.Location = new System.Drawing.Point(50, 95);
            this.labelRegion1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegion1.Name = "labelRegion1";
            this.labelRegion1.Size = new System.Drawing.Size(76, 23);
            this.labelRegion1.TabIndex = 2;
            this.labelRegion1.Text = "Region 1";
            // 
            // labelRegion2
            // 
            this.labelRegion2.AutoSize = true;
            this.labelRegion2.Location = new System.Drawing.Point(251, 95);
            this.labelRegion2.Name = "labelRegion2";
            this.labelRegion2.Size = new System.Drawing.Size(76, 23);
            this.labelRegion2.TabIndex = 3;
            this.labelRegion2.Text = "Region 2";
            // 
            // labelRegion3
            // 
            this.labelRegion3.AutoSize = true;
            this.labelRegion3.Location = new System.Drawing.Point(447, 95);
            this.labelRegion3.Name = "labelRegion3";
            this.labelRegion3.Size = new System.Drawing.Size(76, 23);
            this.labelRegion3.TabIndex = 4;
            this.labelRegion3.Text = "Region 3";
            // 
            // textBoxRegion1Output
            // 
            this.textBoxRegion1Output.Location = new System.Drawing.Point(39, 136);
            this.textBoxRegion1Output.Name = "textBoxRegion1Output";
            this.textBoxRegion1Output.Size = new System.Drawing.Size(100, 31);
            this.textBoxRegion1Output.TabIndex = 5;
            // 
            // RegionAverageWeeklyUnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 579);
            this.Controls.Add(this.textBoxRegion1Output);
            this.Controls.Add(this.labelRegion3);
            this.Controls.Add(this.labelRegion2);
            this.Controls.Add(this.labelRegion1);
            this.Controls.Add(this.textBoxCasesInput);
            this.Controls.Add(this.labelCasesEntry);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegionAverageWeeklyUnitsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Units by Region";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCasesEntry;
        private System.Windows.Forms.TextBox textBoxCasesInput;
        private System.Windows.Forms.Label labelRegion1;
        private System.Windows.Forms.Label labelRegion2;
        private System.Windows.Forms.Label labelRegion3;
        private System.Windows.Forms.TextBox textBoxRegion1Output;
    }
}

