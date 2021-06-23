//
//Name : Katherine Bellman
//Student #: 100325825
//Program: Region Average Weekly Units
//Program Description: Accepts 7 whole number inputs to calculate the average of inputs for 3 regions. And a final total average of the three regions.
//
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
        //Declare class-level variables.
        int currentDay = 1;
        int totalCases = 0;
        int currentRegion = 1;

        public RegionAverageWeeklyUnitsForm()
        {
            InitializeComponent();
        }

        #region "Event Handlers"

        private void RegionAverageWeeklyUnitsForm_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        //Enter button Event handler
        private void EnterClick(object sender, EventArgs e)
        {
            //Declare constant representing the number of days
            const int NumberOfDays = 7;
            //Declare variable to store user's (numeric) last entry
            int enteredCases;
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

        private void SetDefaults()
        {
            //Clear all input controls
            textBoxCasesInput.Clear();

            //Clear all output controls
            textBoxRegion1AverageOutput.Clear();
            textBoxRegion2AverageOutput.Clear();
            textBoxRegion3AverageOutput.Clear();


            //Re-enable any controls that could be disabled
            textBoxCasesInput.Enabled = true;
            buttonEnter.Enabled = true;

            //Reset values of class-level variables
            currentDay = 1;
            totalCases = 0;
            currentRegion = 1;

            //Set the focus
            textBoxCasesInput.Focus();
        }

        
        #endregion
    }
}
