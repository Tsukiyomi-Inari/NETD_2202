/* 
 * Author: Katherine Bellman
 * Date: June 30th 2021
 * Title: Week 8 Class demo for NetD2202
 * sub-title: StormTrooper Class Definition
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace W8_Collections
{
    class StormTrooper
    {
        
        #region PROPERTIES

        public int Designation { get; set;}

        public String NickName { get; set;}

        public String HomeWorld { get; set; }

        public DateTime Born { get; set; }

        public String Unit { get; set; }
        
        public Boolean Defective { get; set; }

        public Color HairColour { get; set; }

        public Color EyeColour { get; set; }


        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Default Constructor
        /// </summary>
        public StormTrooper() { }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="designation"></param>
        /// <param name="nickName"></param>
        /// <param name="homeWorld">Home world trooper currently lives</param>
        /// <param name="born">When trooper was born</param>
        /// <param name="unit"></param>
        /// <param name="defective"></param>
        /// <param name="hairColour">What hair colour trooper has</param>
        /// <param name="eyeColour">what eye colour trooper has</param>
        public StormTrooper(int designation,String nickName, String homeWorld, DateTime born, String unit, Boolean defective, Color hairColour, Color eyeColour)
        {
            Designation = designation;
            NickName = nickName;
            HomeWorld = homeWorld;
            Born = born;
            Unit = unit;
            Defective = defective;
            HairColour = hairColour;
            EyeColour = eyeColour;
        }

        #endregion

        #region OBJECT METHODS

        public int Age()
        {
            int returnValue = 0;
            //calculate age from born
            //returnValue = calculation
            return returnValue;
        }
        #endregion

        #region STATIC METHODS

        public static List<StormTrooper> GetUnitTroopers(List<StormTrooper> inputTroopers, String unit) 
        {
            List<StormTrooper> returnTroopers = new List<StormTrooper>();

            return returnTroopers;
        }

        public static List<StormTrooper> GenerateTestTroopers() 
        {
            List<StormTrooper> returnTroopers = new List<StormTrooper>();

            returnTroopers.Add(new StormTrooper(1234, "Clint", "Tatooine", new DateTime(2020, 05, 16), "RC", false, Color.Brown, Color.Blue));
            returnTroopers.Add(new StormTrooper(7567, "Rex", "Kamino", new DateTime(2032, 07, 10), "CT", false, Color.White, Color.Brown));
            returnTroopers.Add(new StormTrooper(123456, "Bull", "Endor", new DateTime(2027, 11, 26), "Blue", false, Color.Brown, Color.Blue));

            return returnTroopers;
        
        }
        #endregion
    }
}
