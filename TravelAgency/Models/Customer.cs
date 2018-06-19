using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class Customer
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public double TravelLength { get; set; }
		public int Age { get; set; }
		public string Occupation { get; set; }
		public bool TravelsWithAnimal { get; set; }
		public virtual List<Journey> Journeys { get; set; }
    }
}
