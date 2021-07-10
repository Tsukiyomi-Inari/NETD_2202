/* 
 *Author: Katherine Bellman
 *Date: July 6th 2021
 *Title: Week 8 ICE for NETD2202
 *Sub-Title: Cat Class Definition
 */

using System;
using System.Collections.Generic;
using System.Drawing;

namespace Ice_Class_Creation
{
    
	public class Cat
    {
		#region PROPERTIES

		public String Name { get; set; }

		public String Sex { get; set; }

		public Color Coloring { get; set; }

		public String Breed { get; set; }

		public Boolean IsFixed { get; set; }



		#endregion

		#region CONSTRUCTORS
		
		/// <summary>
		/// Default Constructor 
		/// </summary>
		public Cat() { }

		/// <summary>
		/// Parameterized Constructor
		/// </summary>
		/// <param name="felineName">Name of feline overlord</param>
		/// <param name="felineSex">Sex status of feline overlord</param>
		/// <param name="felineIsFixed">Has feline overlord been altered?</param>
		/// <param name="felineBreeds">Feline overlord breed</param>
		/// <param name="felineCoatColouring">Feline overlord colouring </param>
		public Cat(String felineName, String felineSex, Boolean felineIsFixed, String felineBreeds, Color felineCoatColouring)
		{
			Name = felineName;
			Sex = felineSex;
			IsFixed = felineIsFixed;
			Breed = felineBreeds;
			Coloring = felineCoatColouring;
		}

        #endregion

        #region OBJECT METHODS
        /// Leaving here to utilize as template
	
		public static string SexToString(bool sexWhich, string sexGet) 
		{
					
			if(sexWhich is true) 
			{
				return "Male";
			}
            else if(sexWhich is false) 
			{
				return "Female";
			}
            else { return "null"; }
		}

        #endregion

        #region STATIC METHODS

		public static List<Cat> GenerateFelineOverLords() 
		{
			List<Cat> starterFelines = new List<Cat>();

			starterFelines.Add(new Cat("Capitan Meow","Male", true,"Persian",Color.Black ));
			starterFelines.Add(new Cat("Salem", "Male", true, "Persian", Color.Black));

			return starterFelines;
		}

        #endregion
    }
}
