using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Data;

namespace TravelAgency.Models
{
    public class Journey
    {
		public int Id { get; set; }
		public string StartPosition { get; set; }
		public string EndPosition { get; set; }
		public double Distance { get; set; }
		public bool AnimalsAllowed { get; set; }
    }
}
