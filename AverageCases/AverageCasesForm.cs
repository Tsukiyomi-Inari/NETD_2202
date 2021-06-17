//
//Name : Katherine Bellman
//Student #: 100325825
//Program: Average Cases
//Program Description: Accepts 7 whole number inputs to calculate the average of inputs.
//Date: May 19th 2021
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class AverageCasesForm : Form
    {        
        //Declare class-level variables.        
        int currentDay = 1;
        int totalCases = 0;
        
        public AverageCasesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This exits the application
        /// </summary>
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        /// <summary>
        /// Clears all fields and resets the form to its default state.
        /// </summary>
        
        private void ResetClick(object sender, EventArgs e)
        {
            // Clear input and output controls.
            textBoxCaseEntry.Clear();
            textBoxCaseList.Clear();
            textBoxAverageOutput.Text = String.Empty;
            
            //Re-enable any controls that were disabled.
            textBoxCaseEntry.Enabled = true;
            buttonEnter.Enabled = true;
            
            // Reset values of class-level variables
            currentDay = 1;
            totalCases = 0;
            
            //Reset displayed day to default
            labelDay.Text = "Day" + currentDay; 
            
            //Set focus.
            textBoxCaseEntry.Focus();
        }
        /// <summary>
        ///  Validates and accepts a value for the number of cases entered by user. When entry is valid,it is recorded and then added to a running total.
        ///   After all 7 cases are entered,the final calculation is made. And the average is displayed.
        /// </summary>   
        private void EnterClick(object sender, EventArgs e)
        {
            //Declare constant representing number of days
            const int NumberOfDays = 7;
            //Declare variable to store user's last (numeric) entry.
            int enteredCases;
            //If contents of textbox are a number..
            if (int.TryParse(textBoxCaseEntry.Text, out enteredCases))
            {
                //If contents are in valid range (positivte)
                if (enteredCases > 0 && enteredCases <= int.MaxValue)
                {
                    //Increase number of cases as per user inputs valid entry
                    totalCases += enteredCases;
                    //add last entry to displayed text box (large)
                    textBoxCaseList.Text += enteredCases + Environment.NewLine ;
                    //Increase day by one
                    currentDay++;
                    
                    //If day is greater than 7
                    if (currentDay > NumberOfDays)
                    {
                        //Set the day to 7
                        currentDay = NumberOfDays;
                        //Calculate the average (divide case number entries by 7 days)
                        double averageCases = (double)totalCases / NumberOfDays;
                        //Display average output
                        textBoxAverageOutput.Text = "Average per Day: " + Math.Round(averageCases, 2);
                        
                        //Disable the input controls.
                        textBoxCaseEntry.Enabled = false;
                        buttonEnter.Enabled = false;
                    }
                    //update label for current day displayed
                    labelDay.Text = "Day" + currentDay;
                    //focus to the input textbox
                    textBoxCaseEntry.Clear();
                    textBoxCaseEntry.Focus();
                }
                //Contents not in range - display error to user
                else
                {
                    MessageBox.Show("Your entry must be between 0 and " + int.MaxValue, "Entry Error!");
                    textBoxCaseEntry.SelectAll();
                    textBoxCaseEntry.Focus();
                }                    
            }
            //Contents not whole number - display error to user
            else
            {
                MessageBox.Show("Your entry must be a whole number." , "Entry Error!");
            }
        }
        
    }
}
