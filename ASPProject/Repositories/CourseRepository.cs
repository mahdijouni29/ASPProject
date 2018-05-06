using ASPProject.Models;

namespace ASPProject.Repositories
{
	public class CourseRepository
	{
		private MJDbContext db;

		public CourseRepository(MJDbContext db)
		{
			this.db = db;
		}
	}
}