/** CONTACT CLASS
 * 
 *  Name: Katherine Bellman
 *  
 *  Date: July 19th 2021
 *  Description: A class to represent the customers who will be added by the user of the 
 *				program using the class
 *  
 *  Last modified: July 24th 2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ContactTracer
{
    class Contact
    {
		#region PROPERTIES
		//read-only  properties
		public readonly int Count;
		public readonly int Id;
		public readonly DateTime date = DateTime.Now;

	//Public properties
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EMailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public bool ContactStatus { get; set; }
		public int ID { get; }
	

		#endregion
		#region CONSTRUCTORS
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Contact() { Count++; Id = Count;}

		/// <summary>
		/// Parametrized Constructor
		/// </summary>
		/// <param name="Count"></param>
		/// <param name="Id"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="emailAddress"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="contactStatus"></param>
		public Contact(bool contactStatus, string firstName, string lastName, string emailAddress, string phoneNumber): this() 
		{
			// From default constructor added via this()
			Count++;
			Id = Count;
			date = DateTime.Now;
            

			// Get/Set input data 
			ContactStatus = contactStatus;
			FirstName = firstName;
			LastName = lastName;
			EMailAddress = emailAddress;
			PhoneNumber = phoneNumber;
		}


        #endregion
        #region CLASS METHODS
        /// <summary>
        /// Outputs customer status as a string
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactStatus"></param>
        /// <returns></returns>
        public String GetStatus()
        {
            String returnStatus = string.Empty;
            String info;

            info = string.Empty;
            info += FirstName;
            info += LastName;
            info += DateTime.Now;
            info += ContactStatus.ToString();


			return returnStatus;
        }

        #endregion
        #region STATIC METHODS
        public static List<Contact> LoadTestContacts() 
		{
			List<Contact> returnContacts = new List<Contact>();
			returnContacts.Add(new Contact(false, "(689)289-3453","James", "Grey","James.Grey@gmail.ca"));
			returnContacts.Add(new Contact (true, "(789)432-5665","Akasha", "Lynn", ""));

			return returnContacts;
		}

		public static Contact GetContactfromid(List<Contact> inputContacts, int id) 
		{
			Contact returnContact = new Contact();

			foreach (Contact change in inputContacts) 
			{
				if(change.Id == id) 
				{
					returnContact = change;
					break;
				}

			}
			return returnContact;
		}

		/*public static bool ContactExists(List<Contact> inputContacts, int Id)
		{
			Boolean returnValue = false;
			id = ;

			foreach(Contact change in inputContacts) 
			{
			
				if(change.Id == id) 
				{
					returnValue = true;
					return returnValue;
					break;
				}
			}
		}*/

        #endregion
    }
}
