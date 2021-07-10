
namespace Awesome2020Spring
{
    partial class formIceOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIceOne));
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonLeftNo = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.buttonRightNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuestion.Location = new System.Drawing.Point(10, 19);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(324, 156);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "In May of 2021, the computer has detected that Katherine is awesome.\r\n\r\nIs it pos" +
    "sible that they are awesome?";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestion.UseCompatibleTextRendering = true;
            this.labelQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLeftNo
            // 
            this.buttonLeftNo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLeftNo.Location = new System.Drawing.Point(135, 200);
            this.buttonLeftNo.Margin = new System.Windows.Forms.Padding(1);
            this.buttonLeftNo.Name = "buttonLeftNo";
            this.buttonLeftNo.Size = new System.Drawing.Size(75, 40);
            this.buttonLeftNo.TabIndex = 2;
            this.buttonLeftNo.Text = "&No";
            this.buttonLeftNo.UseVisualStyleBackColor = true;
            this.buttonLeftNo.Click += new System.EventHandler(this.buttonLeftNo_Click);
            this.buttonLeftNo.MouseEnter += new System.EventHandler(this.buttonLeftNo_Click);
            // 
            // yesButton
            // 
            this.yesButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yesButton.Location = new System.Drawing.Point(30, 200);
            this.yesButton.Margin = new System.Windows.Forms.Padding(1);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 40);
            this.yesButton.TabIndex = 3;
            this.yesButton.Text = " &Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // buttonRightNo
            // 
            this.buttonRightNo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRightNo.Location = new System.Drawing.Point(234, 200);
            this.buttonRightNo.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRightNo.Name = "buttonRightNo";
            this.buttonRightNo.Size = new System.Drawing.Size(75, 40);
            this.buttonRightNo.TabIndex = 4;
            this.buttonRightNo.Text = "&No";
            this.buttonRightNo.UseVisualStyleBackColor = true;
            this.buttonRightNo.Visible = false;
            this.buttonRightNo.Click += new System.EventHandler(this.buttonRightNo_Click);
            this.buttonRightNo.MouseEnter += new System.EventHandler(this.buttonRightNo_Click);
            // 
            // formIceOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.buttonRightNo);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.buttonLeftNo);
            this.Controls.Add(this.labelQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "formIceOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Awesome - Katherine Bellman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonLeftNo;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button buttonRightNo;
    }
}

