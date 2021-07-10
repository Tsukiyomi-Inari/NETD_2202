//PROGRAM INFO
//
//Name : Katherine Bellman
//Student #: 100325825
//Program: Semester Grades Calculator
//Program Description: Accepts input for 7 numerical grades, and outputs the letter grade as each is inputted.
//                     And also calculates the semester numerical grade average and also displays the letter 
//                      grade that corresponds to it.
//Date: June 6th 2021
//

using System;
using System.Windows.Forms;

namespace LabTwoSemesterGrades
{
    public partial class SemesterGradesForm : Form
    {


        public SemesterGradesForm()
        {
            InitializeComponent();
        }

        #region "Variable Declarations"
        //Variable declarations
        Label[] outputLabel;
        TextBox[] inputTextBoxes;
        TextBox[] semesterAverageOutput;
        Label[] semesterGradeLetterOutput;

        #endregion

        #region "Event Handlers"
        private void FormLoad(object sender, EventArgs e)
        {

        inputTextBoxes = new TextBox[] { textBoxCourse1Input, textBoxCourse2Input, textBoxCourse3Input, textBoxCourse4Input, textBoxCourse5Input, textBoxCourse6Input, textBoxCourse7Input };
        outputLabel = new Label[] { labelGrade1Output, labelGrade2Output, labelGrade3Output, labelGrade4Output, labelGrade5Output, labelGrade6Output, labelGrade7Output };
        semesterAverageOutput = new TextBox[] { textBoxSemesterAverage };
        semesterGradeLetterOutput = new Label[] { labelSemesterGradeLetter };

        SetDefaults();

        }



        // Event Handler for input GradeTextboxes and output lettergradeLables
        private void LeaveInputTextbox(object sender, EventArgs e)
        {
            for (int inputCounter = 0; inputCounter < inputTextBoxes.Length; inputCounter++)
            {
                //determine if text box contents are valid
                if (IsTextBoxValid(inputTextBoxes[inputCounter]))
                {
                    double grade;

                    //get the letter grade from this text box
                    grade = double.Parse(inputTextBoxes[inputCounter].Text);

                    //assign letter grade to corresponding label
                    outputLabel[inputCounter].Text = GetLetterGrade(grade);

                }
            }
        }

        /// <summary>
        ///  After validation (function IsTextBoxValid) it adds each entry to a running total, calculates the semester average and displays results to user.
        /// </summary>
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double semesterTotal = 0;
            double validTextBoxes = 0;
            double invalidTextBoxes = 0;
            double blankTextBoxes = 0;
            double semesterAverage = 0;

            // Count through all of the text boxes.
            for (int inputCounter = 0; inputCounter < inputTextBoxes.Length; inputCounter++)
            {

                // Determine if the text box's contents are valid by
                //  use of the IsTextBoxValid function.
                if (IsTextBoxValid(inputTextBoxes[inputCounter]))
                {
                    //Clear error messages 
                    textBoxErrorMessage.Clear();

                    // Increment the number of valid boxes by one.
                    validTextBoxes++;

                    // Add the box's contents to a running total.
                    semesterTotal += double.Parse(inputTextBoxes[inputCounter].Text);
                }
                else
                {
                    // If the box is not blank, increment the number of invalid boxes by one.
                    invalidTextBoxes++;

                    // Add an error message to the error message TextBox.
                    textBoxErrorMessage.Text = "The entered value is not valid. Please enter a numeric grade. \r\n";
                }
            }

            // If valid input value is equal to number of input text boxes
            if ( validTextBoxes > 0 && invalidTextBoxes == 0) //TODO: make use of blankTextBoxes within statement
            {
                //Clear error messages 
                textBoxErrorMessage.Clear();

                // Calculate and output the rounded average.
                semesterAverage =  Math.Round(semesterTotal / validTextBoxes) ;

                //semesterAverage
                textBoxSemesterAverage.Text = semesterAverage.ToString() ;
                labelSemesterGradeLetter.Text = GetLetterGrade(semesterAverage);

                //Disable input controls until form is reset
                buttonCalculate.Enabled = false;
                SetControlsEnabled(inputTextBoxes, false);

                //Set focus to reset button
                buttonReset.Focus();

            }
            
        }


        /// <summary>
        /// Closes the application.
        /// </summary>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Clears all the fields
        /// </summary>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        #endregion


        #region "Functions"

        /// <summary>
        /// Compares the inputed numeric grade value to the array of grades to determine the corresponding letter grade (from a different array).
        /// </summary>
        /// <param name="numericGrade">A grade between 0 and 100</param>
        /// <returns>Letter grade as a short string</returns>
        private string GetLetterGrade(double numericGrade)
        {
            //Declared array for both grades and letter values that correspond. 
            double[] gradeValues = { 0D, 50D, 52D, 58D, 60D, 62D, 68D, 70D, 72D, 78, 80D, 82D, 90D };
            // Declared array for letter grades
            string[] gradeLetters = { "F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A", "A+" };
            //Default returnLetter to 'F' 
            string returnLetter = "F";

            // Sequence through the array by count comparing grades to the input grade value.
            for (int counter = 0; counter < gradeValues.Length; counter++)
            {
                // If input grade value is more than the value in the array, assign the letter grade that matches
                if (numericGrade >= gradeValues[counter])
                {
                    returnLetter = gradeLetters[counter];
                }
                // Should input grade value is not higher than the value in the array, return the previous (last) assigned letter grade.
                else
                {
                    return returnLetter;
                }
            }
            return returnLetter;
        }


        /// <summary>
        /// Checks if entry into text boxes is valid after they are inputed.
        /// </summary>
        /// <param name="boxToCheck">A text box to confirm if the user input is valid entry</param>
        /// <returns></returns>
        private bool IsTextBoxValid(TextBox boxToCheck)
        {
            const double MinimumGrade = 0.0;
            const double MaxGrade = 100.0;
            double gradeValue = 0;

            if (double.TryParse(boxToCheck.Text, out gradeValue))
            {
                //Checks  if input entry is between 0 and 100
                if (gradeValue >= MinimumGrade && gradeValue <= MaxGrade)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Clears input and output, re-enables controls, sets the form to its default state.
        /// </summary>
        private void SetDefaults()
        {
            //Clear all input controls.
            ClearControls(inputTextBoxes);

            //Clear all output controls.
            ClearControls(outputLabel);
            textBoxSemesterAverage.Clear();
            ClearControls(semesterGradeLetterOutput);
            textBoxErrorMessage.Clear();

            //Re-enable any controls that could be disabled
            SetControlsEnabled(inputTextBoxes, true);
            buttonCalculate.Enabled = true;

            //Set the focus. 
            textBoxCourse1Input.Focus();
        }


        /// <summary>
        /// Function that enables or disables controls
        /// </summary>
        /// <param name="controlArray">An array of controls to enable or disable</param>
        /// <param name="enabledStatus">true to enable, false to disable</param>
        private void SetControlsEnabled(Control[] controlArray, bool enabledStatus)
        {
            foreach (Control controlToSet in controlArray)
            {
                controlToSet.Enabled = enabledStatus;
            }
        }

        /// <summary>
        /// Function which clears the controls in SetDefaults function
        /// </summary>
        /// <param name="controlArray"> An array of controls with a text property to clear</param>
        private void ClearControls(Control[] controlArray)
        {
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
        }

        #endregion
    }

}