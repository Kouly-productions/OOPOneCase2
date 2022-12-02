using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public class Customer : PersonalInformation
    {
		public Customer(string firstName, string lastName, int phoneNumber) : base(firstName, lastName, phoneNumber)
		{
        }
		public override List<string> GetAllVichles(Enrollment en)
		{
            List<string> names = new List<string>();
			foreach (var item in en.Enrollments)
			{
				if (item.CustomerInfo.FirstName == FirstName)
				{
                    names.Add($"{item.CustomerInfo.FirstName} {item.VichleInfo.vichleList}");
				};
			}
            return names;
		}

        public override void GetAllVichles(List<Enrollment> en)
        {
            foreach (var enrollment in en)
            {
                foreach (var item in enrollment.Enrollments)
                {
                    if (item.CustomerInfo.FirstName == FirstName)
                    {
                        Console.WriteLine($"{item.CustomerInfo.FirstName} {item.VichleInfo.vichleList}");
                    };
                }
            }
        }
    }
}
