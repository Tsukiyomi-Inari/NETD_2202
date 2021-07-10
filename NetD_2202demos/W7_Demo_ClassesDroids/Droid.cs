/* -----------------------
 * Author: Clint MacDonald
 * Date: June 2021
 * Title: Droid Class Object Definition
 * ----------------------- */

#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
#endregion


namespace W7_Demo_Classes1
{
    /// <summary>
    /// Class Droid definition
    /// </summary>
    class Droid
    {

        #region PROPERTIES
        public string Designation { get; set; }
        public string Owner { get; set; }
        public bool InService { get; set; }
        public Color PrimaryColour { get; set; }
        public Color SecondaryColour { get; set; }

        #endregion

        #region CONSTRUCTORS
        public Droid()
        { }

        public Droid(string designation, string owner, bool inService, Color primaryColour, Color secondaryColor)
        {
            Designation = designation;
            Owner = owner;
            InService = inService;
            PrimaryColour = primaryColour;
            SecondaryColour = secondaryColor;
        }
        #endregion

        #region METHODS


        #endregion

    }

}
