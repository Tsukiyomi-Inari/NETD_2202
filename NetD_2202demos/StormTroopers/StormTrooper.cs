/* 
 * Author: Clint MacDonald
 * Date: June 30, 2021
 * Title: Week 8 Class Demo for NETD2202
 * Sub-Title:  StormTrooper Class Definition
 * */

using System;
using System.Collections.Generic;
using System.Drawing;

namespace W8_Collections
{
    class StormTrooper
    {
        #region PROPERTIES
        public int Designation { get; set; }
        public String NickName { get; set; }
        public String HomeWorld { get; set; }
        public DateTime Born { get; set; }
        public String Unit { get; set; }
        public Boolean Defective { get; set; }
        public Color HairColour { get; set; }
        public Color EyeColour { get; set; }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default Constructor - CLINT WAS HERE
        /// </summary>
        public StormTrooper() { }

        /// <summary>
        /// Parameterized Constructor - CLINT WAS ALSO HERE
        /// </summary>
        /// <param name="designation"></param>
        /// <param name="nickName"></param>
        /// <param name="homeWorld">The world the trooper currently lives on</param>
        /// <param name="born">The date of Birth</param>
        /// <param name="unit">The squad name the trooper is currently a member of</param>
        /// <param name="defective"></param>
        /// <param name="hairColour"></param>
        /// <param name="eyeColour"></param>
        public StormTrooper(int designation, String nickName, String homeWorld,
                DateTime born, String unit, Boolean defective,
                Color hairColour, Color eyeColour)
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
            // calculate the age from Born
            // returnValue = calculation
            return returnValue;
        }

        #endregion

        #region STATIC METHODS

        public static List<StormTrooper> GetUnitTroopers(List<StormTrooper> inputTroopers, String unit)
        {
            List<StormTrooper> returnTroopers = new List<StormTrooper>();

            return returnTroopers;
        }


        public static List<String> GetDistinctUnitList(List<StormTrooper> inputTroopers) 
        {
            List<String> returnList = new List<string>();

            foreach(StormTrooper st in inputTroopers) 
            {
                if (!returnList.Contains(st.Unit)) 
                {
                    returnList.Add(st.Unit);
                }
            }
            returnList.Sort();
            return returnList;
            
        }

        public static List<StormTrooper> GenerateTestTroopers()
        {
            List<StormTrooper> returnTroopers = new List<StormTrooper>();

            returnTroopers.Add(new StormTrooper(1234, "Clint", "Tatooine", new DateTime(2020, 05, 16), "RC", false, Color.Brown, Color.Blue));
            returnTroopers.Add(new StormTrooper(7567, "Rex", "Kamino", new DateTime(2032, 07, 10), "CT", false, Color.White, Color.Brown));
            returnTroopers.Add(new StormTrooper(123456, "Bull", "Endor", new DateTime(2027, 11, 26), "Blue", false, Color.Brown, Color.Blue));

            return returnTroopers;

        }

        public static StormTrooper GetTrooperFromDesignation(List<StormTrooper> inputTroopers, int designation) 
        {
           foreach (StormTrooper st in inputTroopers) 
            {
                if (st.Designation == designation) 
                {

                }
            }
        }

        public static Boolean AlreadyExists(List<StormTrooper> inputTroopers, int designation) 
        {
            Boolean returnValue = false;

            foreach(StormTrooper st in inputTroopers) 
            {
                if(st.Designation == designation) 
                {
                returnValue = true;
                break;
                }
            }
        }
        #endregion

    }

}
