//
//Name : Katherine Bellman
//Student #: 100325825
//Program: Region Average Weekly Units
//Program Description: Accepts 7 whole number inputs to calculate the average of inputs for 3 regions. And a final total average of the three regions.
//
//Last Modified : June 23rd 2021
//Date: June 27th 2021
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

namespace RegionAverageWeeklyUnits
{
    public partial class RegionAverageWeeklyUnitsForm : Form
    {
        #region "Declarations"
        //Declare class-level variables
        int currentDay = 0;                     
        int currentRegion = 0;                                                 
        int dayCountLabel = 1;                
        const int NumberOfRegions = 3; 
        const int NumberOfDays = 7;

        //This is the 2D array of all cases recorded
        int[,] cases = new int[NumberOfRegions, NumberOfDays];

        //These arrays are arrays of controls on the form
        TextBox[] textBoxCaseLists;
        TextBox[] textBoxAverages;

        #endregion

        /// <summary>
        /// Initializes the form and the arrays of controls.
        /// </summary>
        public RegionAverageWeeklyUnitsForm()
        {
            InitializeComponent();

            textBoxCaseLists = new TextBox[] { textBoxRegion1List, textBoxRegion2List, textBoxRegion3List};
            textBoxAverages = new TextBox[] { textBoxRegion1AverageOutput, textBoxRegion2AverageOutput, textBoxRegion3AverageOutput};
        }

        #region "Event Handlers"
        /// <summary>
        /// On form load the default settings are applied.
        /// </summary>
        private void RegionAverageWeeklyUnitsForm_Load(object sender, EventArgs e)
        {

            SetDefaults();
        }

        //Enter button Event handler
        private void Calculate_EnterClick(object sender, EventArgs e)
        {
            //Declare a variable to store the users last (numeric) input
            int enteredCases;
            
            //If contents of text box are a number..
            if (int.TryParse(textBoxCasesInput.Text, out enteredCases))
            {
                //If contents are in valid range (positive)
                if (enteredCases > 0 && enteredCases <= int.MaxValue)
                {
                    // Add valid case entry to array
                    cases[currentRegion, currentDay] = enteredCases;

                    // Add the entered case value to appropriate region text box list
                    textBoxCaseLists[currentRegion].Text += enteredCases + Environment.NewLine;
                    
                    //Increase day by one
                    currentDay++;

                    //increase the day number label by one
                    labelDayCount.Text = "Day " + (dayCountLabel += 1);

                    //focus to the input text box
                    textBoxCasesInput.Clear();
                    textBoxCasesInput.Focus();

                    //if day is 7, change to next region
                    if (currentDay >= NumberOfDays) 
                    {
                        //Reset day count label to 1
                        labelDayCount.Text = "Day " + (dayCountLabel = 1);

                        double totalCases = 0;
                        // calculate average for current region
                        for(int dayCount = 0; dayCount < NumberOfDays; dayCount++) 
                        {
                            
                            //add to running total for each day for current region
                            totalCases += cases[currentRegion, dayCount];
                        }
                        // calculate and display rounded average for current region
                        textBoxAverages[currentRegion].Text = "Average: " + Math.Round( totalCases / NumberOfDays, 2);

                        //reset the day count and move to next region
                        currentDay = 0;
                        currentRegion++;                        

                        //if  at region 3, calculate final output
                        if (currentRegion >= NumberOfRegions) 
                        {    
                            //Add each input element by iteration through rows and columns of 2d array
                            int allRegionsSubtotal = 0;
                            for(int outer = cases.GetLowerBound(0); outer <= cases.GetUpperBound(0); outer++) 
                            {                             
                               for(int inner = cases.GetLowerBound(1); inner <= cases.GetUpperBound(1); inner++) 
                                {
                                    //Obtain all elements at each (row, column )indexes within 2d array 
                                    allRegionsSubtotal += (int)cases.GetValue(outer,inner);
                                }                            
                            }
                            //Calculate overall total days to use in calculation
                            double divideBy = NumberOfDays * NumberOfRegions ;                            
                            
                            //Round average to 2 decimal places and display in Overall Average Output text box
                            textBoxTotalOveralAverageOutput.Text = "Overall Average: " + Math.Round(allRegionsSubtotal / divideBy , 2);

                            //Disable the input text box and calculate button
                            buttonEnter.Enabled = false;
                            textBoxCasesInput.Enabled = false;
                        }
                    }

                    
                }
                //Contents not in range - display error to user
                else
                {
                    MessageBox.Show("Your entry must be between 0 and " + int.MaxValue, "Entry Error!");
                    textBoxCasesInput.SelectAll();
                    textBoxCasesInput.Focus();
                }
            }
            //Contents not whole number - display error to user
            else
            {
                MessageBox.Show("Your entry must be a whole number.", "Entry Error!");
            }
        }

        /// <summary>
        /// Clears all fields and resets the form to its default state
        /// </summary>
        private void ResetClick(object sender, EventArgs e)
        {
            //Clear input and output controls.
            SetDefaults();
        }

        /// <summary>
        /// Exits the application,
        /// </summary>
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region "Functions"

        public void SetDefaults()
        {
            //Clear all input and output controls
            textBoxCasesInput.Clear();
            textBoxRegion1List.Clear();
            textBoxRegion2List.Clear();
            textBoxRegion3List.Clear();
   
            textBoxRegion1AverageOutput.Clear();
            textBoxRegion2AverageOutput.Clear();
            textBoxRegion3AverageOutput.Clear();
            textBoxTotalOveralAverageOutput.Clear();

            //Clear arrays
            //ClearControls(textBoxCaseLists);
            //ClearControls(textBoxAverages);

            //Re-enable any controls that could be disabled
            textBoxCasesInput.Enabled = true;
            buttonEnter.Enabled = true;

            //Reset the values of class-level variables
            currentDay = 0;
            currentRegion = 0;

            //Set displayed day back to default
            labelDayCount.Text = "Day" + dayCountLabel;
            
            //Set the focus
            textBoxCasesInput.Focus();
        }

        #endregion

    }
}
