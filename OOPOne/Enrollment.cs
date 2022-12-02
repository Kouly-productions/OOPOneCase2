using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public class Enrollment
    {
        public Enrollment(Customer customerInfo, Vichle vichleInfo)
        {
            CustomerInfo = customerInfo;
            VichleInfo = vichleInfo;
        }

        public Enrollment()
        {
            Enrollments = new List<Enrollment>();
        }
        public Customer CustomerInfo { get; set; }

        public Vichle VichleInfo { get; set; }

        public List<Enrollment> Enrollments { get;set; }
        }
    }

