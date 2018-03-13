using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using ElementsAPI.Models;
//using System.Web.Http.Cors;

namespace ElementsAPI.api
{
	//[System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
	public class ElementController : ApiController
	{
		private ElementsAPI.Models.ElementDBEntities dbContext = new ElementsAPI.Models.ElementDBEntities();

		// curl -X GET http://localhost:64227/api/Element see also WebApiConfig
		[Route("api/Element")]
		[HttpGet]
		public IEnumerable<ElementsAPI.Models.Element> Get()
		{
			var elements = dbContext.Elements.ToList().OrderBy(s => s.AtomicNumber);
			return elements;
		}

		// curl -X GET http://localhost:64227/api/Element/1 
		[Route("api/Element/{id}")]
		[HttpGet]
		public Element Get(int? id)
		{
			List<Element> elements = dbContext.Elements.ToList();

			if (id == null)
			{
				return null;
			}

			if (id > elements.Count)
			{
				return new Element { ID = id.Value, AtomicNumber = id.Value, AtomicWeight = 0.0f, Name = "Unknown", Symbol = "?", MeltingPoint = 0.0f, BoilingPoint = +0.0f, Density = 0.0f, EarthCrustPerCentage = 0.0f, Discovered = "", Group = 0, ElectronConfiguration = "", IonizationEnergy = 0.0f };
			}

			var element = dbContext.Elements.Find(id.Value);
			if (element == null)
			{
				return null;
			}
			return element;
		}
	}
}