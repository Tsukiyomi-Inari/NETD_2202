/* Demo Author: Katherine Bellman
 * Followed demo on: July 28th 2021
 * 
 * Author: Clint MacDonald
 * Date: June 30, 2021
 * Title: Week 8 Class Demo for NETD2202
 * Sub-Title:  StormTrooper Class Definition
 * Revisions:  July 7, Clint, continued the demo to version 1.1.0
 * 
 * 
 * Revisions: July 28th 2021, Copied from W11_Strips Demo for internal list of troopers
 * */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Week12_MDI
{
    class StormTrooper
    {
        #region PROPERTIES

        public static List<StormTrooper> Troopers = new List<StormTrooper>();

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

        public static List<StormTrooper> GetUnitTroopers(String unit)
        {
            List<StormTrooper> returnTroopers = new List<StormTrooper>();

            foreach(StormTrooper st in Troopers)
            {
                if (st.Unit == unit)
                {
                    returnTroopers.Add(st);
                }
            }

            // more advanced way to do it
            //returnTroopers = inputTroopers.FindAll(st => st.Unit == unit);

            return returnTroopers;
        }

        public static List<String> GetDistinctUnitList()
        {
            List<String> returnList = new List<String>();

            foreach(StormTrooper st in Troopers)
            {
                if (!returnList.Contains(st.Unit))
                {
                    returnList.Add(st.Unit);
                }
            }

            returnList.Sort();
            return returnList;
        }

        public static void GenerateTestTroopers()
        {
           
            Troopers.Add(new StormTrooper(1234, "Clint", "Tatooine", new DateTime(2020, 05, 16), "RC", false, Color.Brown, Color.Blue));
            Troopers.Add(new StormTrooper(7567, "Rex", "Kamino", new DateTime(2032, 07, 10), "CT", false, Color.White, Color.Brown));
            Troopers.Add(new StormTrooper(3456, "Bull", "Endor", new DateTime(2027, 11, 26), "Blue", false, Color.Brown, Color.Blue));

        }

        public static StormTrooper GetTrooperFromDesignation(int designation)
        {
            StormTrooper returnTrooper = new StormTrooper();

            foreach (StormTrooper st in Troopers)
            {
                if (st.Designation == designation)
                {
                    returnTrooper = st;
                    break;
                }
            }

            return returnTrooper;
        }

        public static Boolean AlreadyExists(int designation)
        {
            Boolean returnValue = false;

            foreach(StormTrooper st in Troopers)
            {
                if (st.Designation == designation)
                {
                    returnValue = true;
                    break;
                }
            }

            return returnValue;
        }

        public static void FileWrite(String fileName)
        {
            FileStream fsWrite = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sWriter = new StreamWriter(fsWrite);
            sWriter.Write(FileCreateCSV());
            sWriter.Close();
            fsWrite.Close();
        }

        private static String FileCreateCSV()
        {
            String returnString = string.Empty;
            String line;

            foreach(StormTrooper st in Troopers)
            {
                line = string.Empty;
                line += st.Designation.ToString() + ",";
                line += st.NickName + ",";
                line += st.Unit + ",";
                line += st.Born.ToString().Substring(0,10) + ",";
                line += st.HomeWorld + ",";
                line += st.Defective + ",";
                line += ConvertColourToString(st.HairColour) + ",";
                line += ConvertColourToString(st.EyeColour);
                line += "\n";
                returnString += line;
            }

            return returnString;
        }

        public static void LoadFromCSV(String fileName)
        {
            Troopers.Clear();            

            FileStream fileRead = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sRead = new StreamReader(fileRead);

            String lineContent;
            String[] items = new String[7];
            String[] dateItems = new String[2];
            StormTrooper st;

            while (!sRead.EndOfStream)
            {
                try
                {
                    lineContent = sRead.ReadLine();
                    items = new string[7];
                    items = lineContent.Split(",");

                    st = new StormTrooper();
                    st.Designation = Convert.ToInt32(items[0]);
                    st.NickName = items[1];
                    st.Unit = items[2];

                    dateItems = items[3].Split("-");
                    st.Born = new DateTime(Convert.ToInt32(dateItems[0]), Convert.ToInt32(dateItems[1]), Convert.ToInt32(dateItems[2]));

                    st.HomeWorld = items[4];
                    st.Defective = Convert.ToBoolean(items[5]);

                    st.HairColour = ConvertStringToColour(items[6]);
                    st.EyeColour = ConvertStringToColour(items[7]);

                    Troopers.Add(st);
                }
                catch { }
            }

            sRead.Close();
            fileRead.Close();

            
        }

        private static String ConvertColourToString(Color color)
        {
            String returnString = color.ToString();

            returnString = returnString.Replace("Color [", "");
            returnString = returnString.Replace("]", "");
            returnString = returnString.Replace(" ", "");
            returnString = returnString.Replace("A=", "");
            returnString = returnString.Replace("R=", "");
            returnString = returnString.Replace("G=", "");
            returnString = returnString.Replace("B=", "");
            returnString = returnString.Replace(",", ";");

            return returnString;

        }

        private static Color ConvertStringToColour(String color)
        {
            Color returnColor;

            if (color.Contains(";"))
            {
                String[] items = new string[3];
                items = color.Split(";");
                returnColor = Color.FromArgb(Convert.ToInt32(items[0]), Convert.ToInt32(items[1]), Convert.ToInt32(items[2]), Convert.ToInt32(items[3]));
            }
            else
            {
                returnColor = Color.FromName(color);
            }

            return returnColor;
        }

        #endregion

    }

}
