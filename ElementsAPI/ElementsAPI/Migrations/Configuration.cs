namespace ElementsAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using ElementsAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ElementsAPI.Models.ElementDBEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

		protected override void Seed(ElementsAPI.Models.ElementDBEntities context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//

			context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Your_Database_Name].[dbo].[Elements]");

			// thanks to https://www.science.co.il/elements/  
			context.Elements.AddOrUpdate(e => e.ID,
				new Element { AtomicNumber = 1, AtomicWeight = 1.008f,	Name = "Hydrogen",		Symbol = "H",	MeltingPoint = -259.0f,		BoilingPoint = +253.0f,		Density = 0.09f,	EarthCrustPerCentage = 0.14f,	Discovered = "1776",	Group = 1,	ElectronConfiguration = "1s1",				IonizationEnergy = 13.60f },
				new Element { AtomicNumber = 2, AtomicWeight = 4.003f,	Name = "Helium",		Symbol = "He",	MeltingPoint = -272.0f,		BoilingPoint = -269.0f,		Density = 0.18f,	EarthCrustPerCentage = 0.0f,	Discovered = "1895",	Group = 18,	ElectronConfiguration = "1s2",				IonizationEnergy = 24.59f },
				new Element { AtomicNumber = 3, AtomicWeight = 6.941f,	Name = "Lithium",		Symbol = "Li",	MeltingPoint = +180.0f,		BoilingPoint = +1347.0f,	Density = 0.53f,	EarthCrustPerCentage = 0.0f,	Discovered = "1817",	Group = 1,	ElectronConfiguration = "[He]2s1",			IonizationEnergy = 5.39f },
				new Element { AtomicNumber = 4, AtomicWeight = 9.012f,	Name = "Beryllium",		Symbol = "Be",	MeltingPoint = +1278.0f,	BoilingPoint = +2970.0f,	Density = 1.85f,	EarthCrustPerCentage = 0.0f,	Discovered = "1797",	Group = 2,	ElectronConfiguration = "[He]2s2",			IonizationEnergy = 9.32f },
				new Element { AtomicNumber = 5, AtomicWeight = 10.811f, Name = "Boron",			Symbol = "B",	MeltingPoint = +2300.0f,	BoilingPoint = +2550.0f,	Density = 2.34f,	EarthCrustPerCentage = 0.0f,	Discovered = "1808",	Group = 13,	ElectronConfiguration = "[He]2s22p1",		IonizationEnergy = 8.30f },
				new Element { AtomicNumber = 6, AtomicWeight = 12.011f, Name = "Carbon",		Symbol = "C",	MeltingPoint = +3500.0f,	BoilingPoint = +4827.0f,	Density = 2.26f,	EarthCrustPerCentage = 0.09f,	Discovered = "ancient", Group = 14,	ElectronConfiguration = "[He]2s22p2",		IonizationEnergy = 11.26f },
				new Element { AtomicNumber = 7, AtomicWeight = 14.007f, Name = "Nitrogen",		Symbol = "N",	MeltingPoint = -210,		BoilingPoint = -196f,		Density = 1.25f,	EarthCrustPerCentage = 0.0f,	Discovered = "1772",	Group = 15,	ElectronConfiguration = "[He]2s22p3",		IonizationEnergy = 14.53f },
				new Element { AtomicNumber = 8, AtomicWeight = 15.999f, Name = "Oxygen",		Symbol = "O",	MeltingPoint = -218,		BoilingPoint = -183f,		Density = 1.43f,	EarthCrustPerCentage = 46.71f,	Discovered = "1774",	Group = 16,	ElectronConfiguration = "[He]2s22p4",		IonizationEnergy = 13.62f },
				new Element { AtomicNumber = 9, AtomicWeight = 18.998f, Name = "Fluorine",		Symbol = "F",	MeltingPoint = -220.0f,		BoilingPoint = -188f,		Density = 1.70f,	EarthCrustPerCentage = 0.03f,	Discovered = "1886",	Group = 17,	ElectronConfiguration = "[He]2s22p5",		IonizationEnergy = 17.42f },
				new Element { AtomicNumber = 10, AtomicWeight = 20.180f, Name = "Neon",			Symbol = "Ne",	MeltingPoint = -249.0f,		BoilingPoint = -246f,		Density = 0.90f,	EarthCrustPerCentage = 0.0f,	Discovered = "1898",	Group = 18,	ElectronConfiguration = "[He]2s22p6",		IonizationEnergy = 21.56f },
				new Element { AtomicNumber = 11, AtomicWeight = 22.990f, Name = "Sodium",		Symbol = "Na",	MeltingPoint = 98.0f,		BoilingPoint = 883f,		Density = 0.97f,	EarthCrustPerCentage = 2.75f,	Discovered = "1807",	Group = 1,	ElectronConfiguration = "[Ne]3s1",			IonizationEnergy = 5.14f },
				new Element { AtomicNumber = 12, AtomicWeight = 24.305f, Name = "Magnesium",	Symbol = "Mg",	MeltingPoint = 639.0f,		BoilingPoint = 1090f,		Density = 1.74f,	EarthCrustPerCentage = 2.08f,	Discovered = "1755",	Group = 2,	ElectronConfiguration = "[Ne]3s2",			IonizationEnergy = 7.65f },
				new Element { AtomicNumber = 13, AtomicWeight = 26.982f, Name = "Aluminum",		Symbol = "Al",	MeltingPoint = 660.0f,		BoilingPoint = 2467f,		Density = 2.70f,	EarthCrustPerCentage = 8.07f,	Discovered = "1825",	Group = 13,	ElectronConfiguration = "[Ne]3s23p1",		IonizationEnergy = 5.99f },
				new Element { AtomicNumber = 14, AtomicWeight = 28.086f, Name = "Silicon",		Symbol = "Si",	MeltingPoint = 1410.0f,		BoilingPoint = 2355f,		Density = 2.33f,	EarthCrustPerCentage = 27.69f,	Discovered = "1824",	Group = 14,	ElectronConfiguration = "[Ne]3s23p2",		IonizationEnergy = 8.15f },
				new Element { AtomicNumber = 15, AtomicWeight = 30.974f, Name = "Phosphorus",	Symbol = "P",	MeltingPoint = 44.0f,		BoilingPoint = 280f,		Density = 1.82f,	EarthCrustPerCentage = 0.13f,	Discovered = "1669",	Group = 15,	ElectronConfiguration = "[Ne]3s23p3",		IonizationEnergy = 10.49f },
				new Element { AtomicNumber = 16, AtomicWeight = 32.065f, Name = "Sulfur",		Symbol = "S",	MeltingPoint = 113.0f,		BoilingPoint = 445f,		Density = 2.07f,	EarthCrustPerCentage = 0.05f,	Discovered = "ancient",	Group = 16,	ElectronConfiguration = "[Ne]3s23p4",		IonizationEnergy = 10.36f },
				new Element { AtomicNumber = 17, AtomicWeight = 35.453f, Name = "Chlorine",		Symbol = "Cl",	MeltingPoint = -101.0f,		BoilingPoint = -35f,		Density = 3.21f,	EarthCrustPerCentage = 0.05f,	Discovered = "1774",	Group = 17,	ElectronConfiguration = "[Ne]3s23p5",		IonizationEnergy = 12.97f },
				new Element { AtomicNumber = 18, AtomicWeight = 39.948f, Name = "Argon",		Symbol = "Ar",	MeltingPoint = -189.0f,		BoilingPoint = -186f,		Density = 1.78f,	EarthCrustPerCentage = 0.0f,	Discovered = "1894",	Group = 18,	ElectronConfiguration = "[Ne]3s23p6",		IonizationEnergy = 15.76f },
				new Element { AtomicNumber = 19, AtomicWeight = 39.098f, Name = "Potassium",	Symbol = "K",	MeltingPoint = 64.0f,		BoilingPoint = 0.86f,		Density = 2.58f,	EarthCrustPerCentage = 0.0f,	Discovered = "1807",	Group = 1,	ElectronConfiguration = "[Ar]4s1",			IonizationEnergy = 4.34f },
				new Element { AtomicNumber = 20, AtomicWeight = 40.078f, Name = "Calcium",		Symbol = "Ca",	MeltingPoint = 839.0f,		BoilingPoint = 1484f,		Density = 1.55f,	EarthCrustPerCentage = 3.65f,	Discovered = "1808",	Group = 2,	ElectronConfiguration = "[Ar]4s2",			IonizationEnergy = 6.11f },
				new Element { AtomicNumber = 21, AtomicWeight = 44.956f, Name = "Scandium",		Symbol = "Sc",	MeltingPoint = 1539.0f,		BoilingPoint = 2832f,		Density = 2.99f,	EarthCrustPerCentage = 0.0f,	Discovered = "1879",	Group = 3,	ElectronConfiguration = "[Ar]3d14s2",		IonizationEnergy = 6.56f },
				new Element { AtomicNumber = 22, AtomicWeight = 47.867f, Name = "Titanium",		Symbol = "Ti",	MeltingPoint = 1660.0f,		BoilingPoint = 3287f,		Density = 4.54f,	EarthCrustPerCentage = 0.62f,	Discovered = "1791",	Group = 4,	ElectronConfiguration = "[Ar]3d24s2",		IonizationEnergy = 6.83f },
				new Element { AtomicNumber = 23, AtomicWeight = 50.942f, Name = "Vanadium",		Symbol = "V",	MeltingPoint = 1890.0f,		BoilingPoint = 3380f,		Density = 6.11f,	EarthCrustPerCentage = 0.00f,	Discovered = "1830",	Group = 5,	ElectronConfiguration = "[Ar]3d34s2",		IonizationEnergy = 6.75f },
				new Element { AtomicNumber = 24, AtomicWeight = 51.996f, Name = "Chromium",		Symbol = "Cr",	MeltingPoint = 1857.0f,		BoilingPoint = 2672f,		Density = 7.19f,	EarthCrustPerCentage = 0.04f,	Discovered = "1797",	Group = 6,	ElectronConfiguration = "[Ar]3d54s1",		IonizationEnergy = 6.77f },
				new Element { AtomicNumber = 25, AtomicWeight = 54.938f, Name = "Manganese",	Symbol = "Mn",	MeltingPoint = 1245.0f,		BoilingPoint = 1962f,		Density = 7.43f,	EarthCrustPerCentage = 0.09f,	Discovered = "1774",	Group = 7,	ElectronConfiguration = "[Ar]3d54s2",		IonizationEnergy = 7.43f },
				new Element { AtomicNumber = 26, AtomicWeight = 55.845f, Name = "Iron",			Symbol = "Fe",	MeltingPoint = 1535.0f,		BoilingPoint = 2750f,		Density = 7.87f,	EarthCrustPerCentage = 5.05f,	Discovered = "ancient",	Group = 8,	ElectronConfiguration = "[Ar]3d64s2",		IonizationEnergy = 7.90f },
				new Element { AtomicNumber = 27, AtomicWeight = 58.933f, Name = "Cobalt",		Symbol = "Co",	MeltingPoint = 1495.0f,		BoilingPoint = 2870f,		Density = 8.90f,	EarthCrustPerCentage = 0.00f,	Discovered = "1735",	Group = 9,	ElectronConfiguration = "[Ar]3d74s2",		IonizationEnergy = 7.88f },
				new Element { AtomicNumber = 28, AtomicWeight = 58.693f, Name = "Nickel",		Symbol = "Ni",	MeltingPoint = 1453.0f,		BoilingPoint = 2732f,		Density = 8.90f,	EarthCrustPerCentage = 0.02f,	Discovered = "1751",	Group = 10,	ElectronConfiguration = "[Ar]3d84s2",		IonizationEnergy = 7.64f },
				new Element { AtomicNumber = 29, AtomicWeight = 63.546f, Name = "Copper",		Symbol = "Cu",	MeltingPoint = 1083.0f,		BoilingPoint = 2567f,		Density = 8.96f,	EarthCrustPerCentage = 0.00f,	Discovered = "ancient",	Group = 11,	ElectronConfiguration = "[Ar]3d104s1",		IonizationEnergy = 7.73f },
				new Element { AtomicNumber = 30, AtomicWeight = 65.390f, Name = "Zinc",			Symbol = "Zn",	MeltingPoint = 420.0f,		BoilingPoint = 907f,		Density = 7.13f,	EarthCrustPerCentage = 0.00f,	Discovered = "ancient",	Group = 12,	ElectronConfiguration = "[Ar]3d104s2",		IonizationEnergy = 9.39f },
				new Element { AtomicNumber = 31, AtomicWeight = 69.723f, Name = "Gallium",		Symbol = "Ga",	MeltingPoint = 30.0f,		BoilingPoint = 2403f,		Density = 5.91f,	EarthCrustPerCentage = 0.00f,	Discovered = "1875",	Group = 13,	ElectronConfiguration = "[Ar]3d104s24p1",	IonizationEnergy = 6.00f },
				/* 31                                           69.723 Gallium Ga                                              30                          2403         5.91                                                              1875              13                           [Ar] 3d10 4s2 4p1 6.00 */
				new Element { AtomicNumber = 32, AtomicWeight = 72.640f, Name = "Germanium",	Symbol = "Ge",	MeltingPoint = 937.0f,		BoilingPoint = 2830f,		Density = 5.32f,	EarthCrustPerCentage = 0.00f,	Discovered = "1886",	Group = 14,	ElectronConfiguration = "[Ar]3d104s24p2",	IonizationEnergy = 7.90f },
				new Element { AtomicNumber = 33, AtomicWeight = 74.922f, Name = "Arsenic",		Symbol = "As",	MeltingPoint = 81.0f,		BoilingPoint = 613f,		Density = 5.72f,	EarthCrustPerCentage = 0.00f,	Discovered = "ancient",	Group = 15,	ElectronConfiguration = "[Ar]3d104s24p3",	IonizationEnergy = 9.79f },
				new Element { AtomicNumber = 34, AtomicWeight = 78.960f, Name = "Selenium",		Symbol = "Se",	MeltingPoint = 217.0f,		BoilingPoint = 685f,		Density = 4.79f,	EarthCrustPerCentage = 0.00f,	Discovered = "1817",	Group = 16,	ElectronConfiguration = "[Ar]3d104s24p4",	IonizationEnergy = 9.75f },
				new Element { AtomicNumber = 35, AtomicWeight = 79.904f, Name = "Bromine",		Symbol = "Br",	MeltingPoint = -7.0f,		BoilingPoint = 59f,			Density = 3.12f,	EarthCrustPerCentage = 0.00f,	Discovered = "1826",	Group = 17,	ElectronConfiguration = "[Ar]3d104s24p5",	IonizationEnergy = 11.81f },
				new Element { AtomicNumber = 36, AtomicWeight = 83.800f, Name = "Krypton",		Symbol = "Kr",	MeltingPoint = -157.0f,		BoilingPoint = -153f,		Density = 3.75f,	EarthCrustPerCentage = 0.00f,	Discovered = "1898",	Group = 18,	ElectronConfiguration = "[Ar]3d104s24p6",	IonizationEnergy = 14.00f },
				new Element { AtomicNumber = 37, AtomicWeight = 85.468f, Name = "Rubidium",		Symbol = "Rb",	MeltingPoint = 39.0f,		BoilingPoint = 688f,		Density = 1.63f,	EarthCrustPerCentage = 0.00f,	Discovered = "1861",	Group = 1,	ElectronConfiguration = "[Kr]5s1",			IonizationEnergy = 4.18f },
				new Element { AtomicNumber = 38, AtomicWeight = 87.620f, Name = "Strontium",	Symbol = "Sr",	MeltingPoint = 769.0f,		BoilingPoint = 1384f,		Density = 2.54f,	EarthCrustPerCentage = 0.00f,	Discovered = "1790",	Group = 2,	ElectronConfiguration = "[Kr]5s2",			IonizationEnergy = 5.69f },
				new Element { AtomicNumber = 39, AtomicWeight = 88.906f, Name = "Yttrium",		Symbol = "Y",	MeltingPoint = 1523.0f,		BoilingPoint = 3337f,		Density = 4.47f,	EarthCrustPerCentage = 0.00f,	Discovered = "1794",	Group = 3,	ElectronConfiguration = "[Kr]4d15s2",		IonizationEnergy = 6.22f },
				new Element { AtomicNumber = 40, AtomicWeight = 91.224f, Name = "Zirconium",	Symbol = "Zr",	MeltingPoint = 1852.0f,		BoilingPoint = 4377f,		Density = 6.51f,	EarthCrustPerCentage = 0.03f,	Discovered = "1789",	Group = 4,	ElectronConfiguration = "[Kr]4d25s2",		IonizationEnergy = 6.63f },
				new Element { AtomicNumber = 41, AtomicWeight = 92.906f, Name = "Niobium",		Symbol = "Nb",	MeltingPoint = 2468.0f,		BoilingPoint = 4927f,		Density = 8.57f,	EarthCrustPerCentage = 0.00f,	Discovered = "1801",	Group = 5,	ElectronConfiguration = "[Kr]4d45s1",		IonizationEnergy = 6.76f },
				new Element { AtomicNumber = 42, AtomicWeight = 95.940f, Name = "Molybdenum",	Symbol = "Mo",	MeltingPoint = 2617.0f,		BoilingPoint = 4612f,		Density = 10.22f,	EarthCrustPerCentage = 0.00f,	Discovered = "1781",	Group = 6,	ElectronConfiguration = "[Kr]4d55s1",		IonizationEnergy = 7.09f },
				new Element { AtomicNumber = 43, AtomicWeight = 98.000f, Name = "Technetium",	Symbol = "Tc",	MeltingPoint = 2200.0f,		BoilingPoint = 4877f,		Density = 11.50f,	EarthCrustPerCentage = 0.00f,	Discovered = "1937",	Group = 7,	ElectronConfiguration = "[Kr]4d55s2",		IonizationEnergy = 7.28f },
				new Element { AtomicNumber = 44, AtomicWeight = 101.070f, Name = "Ruthenium",	Symbol = "Ru",	MeltingPoint = 2250.0f,		BoilingPoint = 3900f,		Density = 12.37f,	EarthCrustPerCentage = 0.00f,	Discovered = "1844",	Group = 8,	ElectronConfiguration = "[Kr]4d75s1",		IonizationEnergy = 7.36f },
				new Element { AtomicNumber = 45, AtomicWeight = 102.906f, Name = "Rhodium",		Symbol = "Rh",	MeltingPoint = 1966.0f,		BoilingPoint = 3727f,		Density = 12.41f,	EarthCrustPerCentage = 0.00f,	Discovered = "1803",	Group = 9,	ElectronConfiguration = "[Kr]4d85s1",		IonizationEnergy = 7.46f },
				/*                           45                 102.906           Rhodium Rh                                   1966                        3727                   12.41                          0                        1803              9                            [Kr]4d85s1                            7.46 */
				new Element { AtomicNumber = 46, AtomicWeight = 106.420f, Name = "Palladium",	Symbol = "Pd",	MeltingPoint = 1552.0f,		BoilingPoint = 2927f,		Density = 12.02f,	EarthCrustPerCentage = 0.00f,	Discovered = "1803",	Group = 10,	ElectronConfiguration = "[Kr]4d10",			IonizationEnergy = 8.34f },
				new Element { AtomicNumber = 47, AtomicWeight = 107.868f, Name = "Silver",		Symbol = "Ag",	MeltingPoint = 962.0f,		BoilingPoint = 2212f,		Density = 10.50f,	EarthCrustPerCentage = 0.00f,	Discovered = "ancient",	Group = 11,	ElectronConfiguration = "[Kr]4d105s1",		IonizationEnergy = 7.58f },
				new Element { AtomicNumber = 48, AtomicWeight = 112.411f, Name = "Cadmium",		Symbol = "Cd",	MeltingPoint = 321.0f,		BoilingPoint = 765f,		Density = 8.65f,	EarthCrustPerCentage = 0.00f,	Discovered = "1817",	Group = 12,	ElectronConfiguration = "[Kr]4d105s2",		IonizationEnergy = 8.99f },
				new Element { AtomicNumber = 49, AtomicWeight = 114.818f, Name = "Indium",		Symbol = "In",	MeltingPoint = 157.0f,		BoilingPoint = 2000f,		Density = 7.31f,	EarthCrustPerCentage = 0.00f,	Discovered = "1863",	Group = 13,	ElectronConfiguration = "[Kr]4d105s2 5p1",	IonizationEnergy = 5.79f },
				new Element { AtomicNumber = 50, AtomicWeight = 118.710f, Name = "Tin",			Symbol = "Sn",	MeltingPoint = 232.0f,		BoilingPoint = 2270f,		Density = 7.31f,	EarthCrustPerCentage = 0.00f,	Discovered = "ancient", Group = 14,	ElectronConfiguration = "[Kr]4d105s2 5p2",	IonizationEnergy = 7.34f }
				/* remaining elements will be added in future version */
				);
		}
	}
}
