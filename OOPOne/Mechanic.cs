using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPOne
{
    public class Mechanic : PersonalInformation
    {
        public Mechanic(string firstName, string lastName, int phoneNumber, vehicleEnum vehichleType) : base(firstName, lastName, phoneNumber)
        {
            Vehicletype = vehichleType;
        }

		public vehicleEnum Vehicletype
        {
            get;
            set;
		}

        public override List<string> GetAllVichles(Enrollment en)
        {
            List<string> courses = new List<string>();
            foreach (var item in en.Enrollments)
            {
                if (item.VichleInfo.Mechanic.FirstName == FirstName)
                {
                    courses.Add($"{item.CustomerInfo.FirstName} {item.VichleInfo.Mechanic}");
                }
            }
            return courses;
        }

        public override void GetAllVichles(List<Enrollment> en)
        {
            foreach (var enrollment in en)
            {
                foreach (var item in enrollment.Enrollments)
                {
                    if (item.VichleInfo.Mechanic.FirstName == FirstName)
                    {
                        Console.WriteLine($"{item.CustomerInfo.FirstName} {item.VichleInfo.Mechanic}");
                    }
                }
            }
        }
    }
}
