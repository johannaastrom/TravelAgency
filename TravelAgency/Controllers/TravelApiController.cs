using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelAgency.Data;
using TravelAgency.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelAgency.Controllers
{
    [Route("api/[controller]")]
    public class TravelApiController : Controller
    {
		private readonly IApiRequestSend<Journey> apiRequestSend;

		public TravelApiController(IApiRequestSend<Journey> service)
		{
			apiRequestSend = service;
		}

		// GET api/<controller>
		[HttpGet]
		public virtual IEnumerable<Journey> GetAllJourneys()
		{
			return apiRequestSend.GetAllData();
		}

		// DELETE api/<controller>
		[HttpDelete]
		public virtual void DeleteJourney(Journey entity)
		{
			apiRequestSend.DeleteEntity(entity);
		}

		// POST api/<controller>
		[HttpPost]
		public void AddJourney(Journey entity)
		{
			apiRequestSend.AddEntity(entity);
		}

		[HttpPost]
		public void ModifyJourney(int id, Journey entity)
		{
			apiRequestSend.ModifyEntity(id, entity);
		}
	}
}
