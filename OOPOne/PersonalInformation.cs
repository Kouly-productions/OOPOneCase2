using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public abstract class PersonalInformation
    {
		private string _Firstname;
		private string _LastName;
        private int _Age;

        public PersonalInformation(string firstName, string lastName, int phoneNumber)
        {
            FirstName= firstName;
            LastName= lastName;
            PhoneNumber = phoneNumber;
        }

		public string FirstName
		{
			get { return _Firstname; }
			set { _Firstname = value; }
		}


		public string LastName
		{
			get { return _LastName; }
			set { _LastName = value; }
		}

        public DateTime DateOfTime { get; set; }

        public int PhoneNumber { get; set; }
        public abstract List<string> GetAllVichles(Enrollment en);
        public abstract void GetAllVichles(List<Enrollment> enrollments);





        /*
        public virtual void WriteAllNames(Enrollment en)
        {
                Console.WriteLine("Hi from Virtual");
        }
        */

        //Indkapsling
        //Abstract
        //Arv
        //Polymorfi

    }
}
