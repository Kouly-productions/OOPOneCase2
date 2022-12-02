using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public class Vichle
    {

		 public Vichle(string numberPlate, string brand, string model, DateTime year, Customer owner ,Mechanic mechanic)
		{
			NumberPlate = numberPlate;
			Brand = brand;
			Model = model;
			Year = year;
			Owner = owner;
            Mechanic = mechanic;
		}

		public Vichle()
		{
			vichleList = new List<Vichle>();
		}

		public string NumberPlate { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public DateTime Year { get; set; }
		public Customer Owner { get; set; }
		public Mechanic Mechanic { get; set; }
		public List<Vichle> vichleList { get; set; }
	}
}
