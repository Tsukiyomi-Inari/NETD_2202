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
		public readonly DateTime Date = DateTime.Now;

	//Public properties
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EMailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public bool ContactStatus { get; set; }

		#endregion
		#region CONSTRUCTORS

		public Contact(ref int Count,ref int Id) { Count++; Id = Count; }

		public Contact(int Count, int Id, string firstName, string lastName, string emailAddress, string phoneNumber, bool contactStatus) 
		{
			// From default constructor
			Count++;
			Id = Count;

			// Get/Set input data 
			FirstName = firstName;
			LastName = lastName;
			EMailAddress = emailAddress;
			PhoneNumber = phoneNumber;
			ContactStatus = contactStatus;
		}


		#endregion
		#region CLASS METHODS

		public String GetStatus( string firstName, string lastName, DateTime date, bool contactStatus)
		{
			
		}

		#endregion
	}
}
