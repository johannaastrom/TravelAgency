using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Models;

namespace TravelAgency.Data
{
	public class TravelContext : DbContext
	{
		public TravelContext(DbContextOptions<TravelContext> options) : base(options)
		{
		}

		public virtual DbSet<Journey> Journeys { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
	}
}
