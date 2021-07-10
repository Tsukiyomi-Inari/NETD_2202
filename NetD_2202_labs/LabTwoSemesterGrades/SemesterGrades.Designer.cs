
namespace LabTwoSemesterGrades
{
    partial class SemesterGradesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemesterGradesForm));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxErrorMessage = new System.Windows.Forms.TextBox();
            this.textBoxCourse1Input = new System.Windows.Forms.TextBox();
            this.toolTipSemesterGrades = new System.Windows.Forms.ToolTip(this.components);
            this.labelGrade1Output = new System.Windows.Forms.Label();
            this.labelGrade2Output = new System.Windows.Forms.Label();
            this.textBoxCourse2Input = new System.Windows.Forms.TextBox();
            this.labelGrade3Output = new System.Windows.Forms.Label();
            this.textBoxCourse3Input = new System.Windows.Forms.TextBox();
            this.labelGrade4Output = new System.Windows.Forms.Label();
            this.textBoxCourse4Input = new System.Windows.Forms.TextBox();
            this.labelGrade5Output = new System.Windows.Forms.Label();
            this.textBoxCourse5Input = new System.Windows.Forms.TextBox();
            this.labelGrade6Output = new System.Windows.Forms.Label();
            this.textBoxCourse6Input = new System.Windows.Forms.TextBox();
            this.labelGrade7Output = new System.Windows.Forms.Label();
            this.textBoxCourse7Input = new System.Windows.Forms.TextBox();
            this.labelSemesterGradeLetter = new System.Windows.Forms.Label();
            this.textBoxSemesterAverage = new System.Windows.Forms.TextBox();
            this.labelCourse1 = new System.Windows.Forms.Label();
            this.labelCourse2 = new System.Windows.Forms.Label();
            this.labelCourse3 = new System.Windows.Forms.Label();
            this.labelCourse4 = new System.Windows.Forms.Label();
            this.labelCourse5 = new System.Windows.Forms.Label();
            this.labelCourse6 = new System.Windows.Forms.Label();
            this.labelCourse7 = new System.Windows.Forms.Label();
            this.labelSemesterAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.Location = new System.Drawing.Point(10, 526);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(110, 31);
            this.buttonCalculate.TabIndex = 26;
            this.buttonCalculate.Text = "C&alculate";
            this.toolTipSemesterGrades.SetToolTip(this.buttonCalculate, "Calculates the average of entered grades for the semester.");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(133, 526);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(110, 31);
            this.buttonReset.TabIndex = 27;
            this.buttonReset.Text = "R&eset";
            this.toolTipSemesterGrades.SetToolTip(this.buttonReset, "Resets application.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(261, 526);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 31);
            this.buttonExit.TabIndex = 28;
            this.buttonExit.Text = "Ex&it";
            this.toolTipSemesterGrades.SetToolTip(this.buttonExit, "Closes application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textBoxErrorMessage
            // 
            this.textBoxErrorMessage.Location = new System.Drawing.Point(13, 387);
            this.textBoxErrorMessage.Multiline = true;
            this.textBoxErrorMessage.Name = "textBoxErrorMessage";
            this.textBoxErrorMessage.ReadOnly = true;
            this.textBoxErrorMessage.Size = new System.Drawing.Size(356, 122);
            this.textBoxErrorMessage.TabIndex = 29;
            this.toolTipSemesterGrades.SetToolTip(this.textBoxErrorMessage, "Displays an error message if an invalid input has been entered.");
            // 
            // textBoxCourse1Input
            // 
            this.textBoxCourse1Input.Location = new System.Drawing.Point(133, 26);
            this.textBoxCourse1Input.Name = "textBoxCourse1Input";
            this.textBoxCourse1Input.Size = new System.Drawing.Size(100, 30);
            this.textBoxCourse1Input.TabIndex = 2;
            this.textBoxCourse1Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipSemesterGrades.SetToolTip(this.textBoxCourse1Input, "Enter course 1 numeric grade.");
            this.textBoxCourse1Input.Leave += new System.EventHandler(this.LeaveInputTextbox);
            // 
            // labelGrade1Output
            // 
            this.labelGrade1Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGrade1Output.Location = new System.Drawing.Point(261, 25);
            this.labelGrade1Output.Name = "labelGrade1Output";
            this.labelGrade1Output.Size = new System.Drawing.Size(84, 30);
            this.labelGrade1Output.TabIndex = 3;
            this.labelGrade1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipSemesterGrades.SetToolTip(this.labelGrade1Output, "Displays letter grade output for course 1.");
            // 
            // labelGrade2Output
            // 
            this.labelGrade2Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGrade2Output.Location = new System.Drawing.Point(261, 68);
            this.labelGrade2Output.Name = "labelGrade2Output";
            this.labelGrade2Output.Size = new System.Drawing.Size(84, 30);
            this.labelGrade2Output.TabIndex = 6;
            this.labelGrade2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipSemesterGrades.SetToolTip(this.labelGrade2Output, "Displays letter grade output for course 2.");
            // 
            // textBoxCourse2Input
            // 
            this.textBoxCourse2Input.Location = new System.Drawing.Point(133, 69);
            this.textBoxCourse2Input.Name = "textBoxCourse2Input";
            this.textBoxCourse2Input.Size = new System.Drawing.Size(100, 30);
            this.textBoxCourse2Input.TabIndex = 5;
            this.textBoxCourse2Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipSemesterGrades.SetToolTip(this.textBoxCourse2Input, "Enter course 2 numeric grade.");
            this.textBoxCourse2Input.Leave += new System.EventHandler(this.LeaveInputTextbox);
            // 
            // labelGrade3Output
            // 
            this.labelGrade3Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGrade3Output.Location = new System.Drawing.Point(261, 115);
            this.labelGrade3Output.Name = "labelGrade3Output";
            this.labelGrade3Output.Size = new System.Drawing.Size(84, 30);
            this.labelGrade3Output.TabIndex = 9;
            this.labelGrade3Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipSemesterGrades.SetToolTip(this.labelGrade3Output, "Displays letter grade output for course 3.");
            // 
            // textBoxCourse3Input
            // 
            this.textBoxCourse3Input.Location = new System.Drawing.Point(133, 116);
            this.textBoxCourse3Input.Name = "textBoxCourse3Input";
            this.textBoxCourse3Input.Size = new System.Drawing.Size(100, 30);
            this.textBoxCourse3Input.TabIndex = 8;
            this.textBoxCourse3Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipSemesterGrades.SetToolTip(this.textBoxCourse3Input, "Enter course 3 numeric grade.");
            this.textBoxCourse3Input.Leave += new System.EventHandler(this.LeaveInputTextbox);
            // 
            // labelGrade4Output
            // 
            this.labelGrade4Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGrade4Output.Location = new System.Drawing.Point(261, 158);
            this.labelGrade4Output.Name = "labelGrade4Output";
            this.labelGrade4Output.Size = new System.Drawing.Size(84, 30);
            this.labelGrade4Output.TabIndex = 12;
            this.labelGrade4Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipSemesterGrades.SetToolTip(this.labelGrade4Output, "Displays letter grade output for course 4.");
            // 
            // textBoxCourse4Input
            // 
            this.textBoxCourse4Input.Location = new System.Drawing.Point(133, 159);
            this.textBoxCourse4Input.Name = "textBoxCourse4Input";
            this.textBoxCourse4Input.Size = new System.Drawing.Size(100, 30);
            this.textBoxCourse4Input.TabIndex = 11;
            this.textBoxCourse4Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipSemesterGrades.SetToolTip(this.textBoxCourse4Input, "Enter course 4 numeric grade.");
            this.textBoxCourse4Input.Leave += new System.EventHandler(this.LeaveInputTextbox);
            // 
            // labelGrade5Output
            // 
            this.labelGrade5Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGrade5Output.Location = new System.Drawing.Point(261, 201);
            this.labelGrade5Output.Name = "labelGrade5Output";
            this.labelGrade5Output.Size = new System.Drawing.Size(84, 30);
            this.labelGrade5Output.TabIndex = 15;
            this.labelGrade5Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipSemesterGrades.SetToolTip(this.labelGrade5Output, "Displays letter grade output for course 5.");
            // 
            // textBoxCourse5Input
            // 
            this.textBoxCourse5Input.Location = new System.Drawing.Point(133, 202);
            this.textBoxCourse5Input.Name = "textBoxCourse5Input";
            this.textBoxCourse5Input.Size = new System.Drawing.Size(100, 30);
            this.textBoxCourse5Input.TabIndex = 14;
            this.textBoxCourse5Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipSemesterGrades.SetToolTip(this.textBoxCourse5Input, "Enter course 5 numeric grade.");
            this.textBoxCourse5Input.Leave += new System.EventHandler(this.LeaveInputTextbox);
            // 
            // labelGrade6Output
            // 
            this.labelGrade6Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGrade6Output.Location = new System.Drawing.Point(261, 243);
            this.labelGrade6Output.Name = "labelGrade6Output";
            this.labelGrade6Output.Size = new System.Drawing.Size(84, 30);
            this.labelGrade6Output.TabIndex = 18;
            this.labelGrade6Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipSemesterGrades.SetToolTip(this.labelGrade6Output, "Displays letter grade output for course 6.");
            // 
            // textBoxCourse6Input
            // 
            this.textBoxCourse6Input.Location = new System.Drawing.Point(133, 244);
            this.textBoxCourse6Input.Name = "textBoxCourse6Input";
            this.textBoxCourse6Input.Size = new System.Drawing.Size(100, 30);
            this.textBoxCourse6Input.TabIndex = 17;
            this.textBoxCourse6Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipSemesterGrades.SetToolTip(this.textBoxCourse6Input, "Enter course 6 numeric grade.");
            this.textBoxCourse6Input.Leave += new System.EventHandler(this.LeaveInputTextbox);
            // 
            // labelGrade7Output
            // 
            this.labelGrade7Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGrade7Output.Location = new System.Drawing.Point(261, 285);
            this.labelGrade7Output.Name = "labelGrade7Output";
            this.labelGrade7Output.Size = new System.Drawing.Size(84, 30);
            this.labelGrade7Output.TabIndex = 21;
            this.labelGrade7Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipSemesterGrades.SetToolTip(this.labelGrade7Output, "Displays letter grade output for course 7.");
            // 
            // textBoxCourse7Input
            // 
            this.textBoxCourse7Input.Location = new System.Drawing.Point(133, 286);
            this.textBoxCourse7Input.Name = "textBoxCourse7Input";
            this.textBoxCourse7Input.Size = new System.Drawing.Size(100, 30);
            this.textBoxCourse7Input.TabIndex = 20;
            this.textBoxCourse7Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipSemesterGrades.SetToolTip(this.textBoxCourse7Input, "Enter course 7 numeric grade.");
            this.textBoxCourse7Input.Leave += new System.EventHandler(this.LeaveInputTextbox);
            // 
            // labelSemesterGradeLetter
            // 
            this.labelSemesterGradeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSemesterGradeLetter.Location = new System.Drawing.Point(261, 341);
            this.labelSemesterGradeLetter.Name = "labelSemesterGradeLetter";
            this.labelSemesterGradeLetter.Size = new System.Drawing.Size(84, 30);
            this.labelSemesterGradeLetter.TabIndex = 24;
            this.labelSemesterGradeLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipSemesterGrades.SetToolTip(this.labelSemesterGradeLetter, "Letter grade output for course 1.");
            // 
            // textBoxSemesterAverage
            // 
            this.textBoxSemesterAverage.Location = new System.Drawing.Point(133, 342);
            this.textBoxSemesterAverage.Name = "textBoxSemesterAverage";
            this.textBoxSemesterAverage.ReadOnly = true;
            this.textBoxSemesterAverage.Size = new System.Drawing.Size(100, 30);
            this.textBoxSemesterAverage.TabIndex = 23;
            this.textBoxSemesterAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipSemesterGrades.SetToolTip(this.textBoxSemesterAverage, "Displays the calulated semester grade average.");
            this.textBoxSemesterAverage.Leave += new System.EventHandler(this.LeaveInputTextbox);
            // 
            // labelCourse1
            // 
            this.labelCourse1.Location = new System.Drawing.Point(31, 29);
            this.labelCourse1.Name = "labelCourse1";
            this.labelCourse1.Size = new System.Drawing.Size(96, 23);
            this.labelCourse1.TabIndex = 1;
            this.labelCourse1.Text = "Course &1:";
            // 
            // labelCourse2
            // 
            this.labelCourse2.AutoSize = true;
            this.labelCourse2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCourse2.Location = new System.Drawing.Point(30, 72);
            this.labelCourse2.Name = "labelCourse2";
            this.labelCourse2.Size = new System.Drawing.Size(79, 23);
            this.labelCourse2.TabIndex = 4;
            this.labelCourse2.Text = "Course &2:";
            // 
            // labelCourse3
            // 
            this.labelCourse3.AutoSize = true;
            this.labelCourse3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCourse3.Location = new System.Drawing.Point(30, 119);
            this.labelCourse3.Name = "labelCourse3";
            this.labelCourse3.Size = new System.Drawing.Size(79, 23);
            this.labelCourse3.TabIndex = 7;
            this.labelCourse3.Text = "Course &3:";
            // 
            // labelCourse4
            // 
            this.labelCourse4.AutoSize = true;
            this.labelCourse4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCourse4.Location = new System.Drawing.Point(30, 162);
            this.labelCourse4.Name = "labelCourse4";
            this.labelCourse4.Size = new System.Drawing.Size(79, 23);
            this.labelCourse4.TabIndex = 10;
            this.labelCourse4.Text = "Course &4:";
            // 
            // labelCourse5
            // 
            this.labelCourse5.AutoSize = true;
            this.labelCourse5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCourse5.Location = new System.Drawing.Point(30, 205);
            this.labelCourse5.Name = "labelCourse5";
            this.labelCourse5.Size = new System.Drawing.Size(79, 23);
            this.labelCourse5.TabIndex = 13;
            this.labelCourse5.Text = "Course &5:";
            // 
            // labelCourse6
            // 
            this.labelCourse6.AutoSize = true;
            this.labelCourse6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCourse6.Location = new System.Drawing.Point(30, 247);
            this.labelCourse6.Name = "labelCourse6";
            this.labelCourse6.Size = new System.Drawing.Size(79, 23);
            this.labelCourse6.TabIndex = 16;
            this.labelCourse6.Text = "Course &6:";
            // 
            // labelCourse7
            // 
            this.labelCourse7.AutoSize = true;
            this.labelCourse7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCourse7.Location = new System.Drawing.Point(30, 289);
            this.labelCourse7.Name = "labelCourse7";
            this.labelCourse7.Size = new System.Drawing.Size(79, 23);
            this.labelCourse7.TabIndex = 19;
            this.labelCourse7.Text = "Course &7:";
            // 
            // labelSemesterAverage
            // 
            this.labelSemesterAverage.AutoSize = true;
            this.labelSemesterAverage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSemesterAverage.Location = new System.Drawing.Point(30, 345);
            this.labelSemesterAverage.Name = "labelSemesterAverage";
            this.labelSemesterAverage.Size = new System.Drawing.Size(83, 23);
            this.labelSemesterAverage.TabIndex = 22;
            this.labelSemesterAverage.Text = "&Semester:";
            // 
            // SemesterGradesForm
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(381, 569);
            this.Controls.Add(this.labelSemesterGradeLetter);
            this.Controls.Add(this.labelSemesterAverage);
            this.Controls.Add(this.textBoxSemesterAverage);
            this.Controls.Add(this.labelGrade7Output);
            this.Controls.Add(this.labelCourse7);
            this.Controls.Add(this.textBoxCourse7Input);
            this.Controls.Add(this.labelGrade6Output);
            this.Controls.Add(this.labelCourse6);
            this.Controls.Add(this.textBoxCourse6Input);
            this.Controls.Add(this.labelGrade5Output);
            this.Controls.Add(this.labelCourse5);
            this.Controls.Add(this.textBoxCourse5Input);
            this.Controls.Add(this.labelGrade4Output);
            this.Controls.Add(this.labelCourse4);
            this.Controls.Add(this.textBoxCourse4Input);
            this.Controls.Add(this.labelGrade3Output);
            this.Controls.Add(this.labelCourse3);
            this.Controls.Add(this.textBoxCourse3Input);
            this.Controls.Add(this.labelGrade2Output);
            this.Controls.Add(this.labelCourse2);
            this.Controls.Add(this.textBoxCourse2Input);
            this.Controls.Add(this.labelGrade1Output);
            this.Controls.Add(this.labelCourse1);
            this.Controls.Add(this.textBoxCourse1Input);
            this.Controls.Add(this.textBoxErrorMessage);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SemesterGradesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katherine Bellman \'s Grade Calculator";
            this.toolTipSemesterGrades.SetToolTip(this, "A form to calculate letter grades and semester average grade ");
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxErrorMessage;
        private System.Windows.Forms.TextBox textBoxCourse1Input;
        private System.Windows.Forms.ToolTip toolTipSemesterGrades;
        private System.Windows.Forms.Label labelCourse1;
        private System.Windows.Forms.Label labelGrade1Output;
        private System.Windows.Forms.Label labelGrade2Output;
        private System.Windows.Forms.Label labelCourse2;
        private System.Windows.Forms.TextBox textBoxCourse2Input;
        private System.Windows.Forms.Label labelGrade3Output;
        private System.Windows.Forms.Label labelCourse3;
        private System.Windows.Forms.TextBox textBoxCourse3Input;
        private System.Windows.Forms.Label labelGrade4Output;
        private System.Windows.Forms.Label labelCourse4;
        private System.Windows.Forms.TextBox textBoxCourse4Input;
        private System.Windows.Forms.Label labelGrade5Output;
        private System.Windows.Forms.Label labelCourse5;
        private System.Windows.Forms.TextBox textBoxCourse5Input;
        private System.Windows.Forms.Label labelGrade6Output;
        private System.Windows.Forms.Label labelCourse6;
        private System.Windows.Forms.TextBox textBoxCourse6Input;
        private System.Windows.Forms.Label labelGrade7Output;
        private System.Windows.Forms.Label labelCourse7;
        private System.Windows.Forms.TextBox textBoxCourse7Input;
        private System.Windows.Forms.Label labelSemesterGradeLetter;
        private System.Windows.Forms.Label labelSemesterAverage;
        private System.Windows.Forms.TextBox textBoxSemesterAverage;
       // private System.Windows.Forms.Label labelGrade2Output;
    }
}

