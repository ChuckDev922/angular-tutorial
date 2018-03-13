using System.Data.Entity;

namespace ElementsAPI.Models
{
	public partial class ElementDBEntities : DbContext
	{
		public ElementDBEntities()
		{
		}

		public virtual DbSet<Element> Elements { get; set; }
	}
}