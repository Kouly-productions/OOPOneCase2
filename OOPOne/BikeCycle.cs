using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public class BikeCycle : Vichle
    {
        public BikeCycle(string numberPlate, string brand, string model, DateTime year, Customer owner,
    Mechanic mechanic) : base(numberPlate, brand, model, year, owner, mechanic)
        {

        }
    }
}
