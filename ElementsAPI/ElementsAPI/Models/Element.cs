using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElementsAPI.Models
{
	public class Element
	{
			public int ID { get; set; }
			public int AtomicNumber { get; set; }
			public float AtomicWeight { get; set; }

			[StringLength(128)]
			[Index(IsUnique = true)]
			public string Name { get; set; }

			public string Symbol { get; set; }
			public float MeltingPoint { get; set; }
			public float BoilingPoint { get; set; }
			public float Density { get; set; }
			public float EarthCrustPerCentage { get; set; }
			public string Discovered { get; set; }
			public int Group { get; set; }
			public string ElectronConfiguration { get; set; }
			public float IonizationEnergy { get; set; }
	}
}