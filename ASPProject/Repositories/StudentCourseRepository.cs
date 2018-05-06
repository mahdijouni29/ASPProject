using ASPProject.Models;

namespace ASPProject.Repositories
{
	public class StudentCourseRepository
	{
		private MJDbContext db;

		public StudentCourseRepository(MJDbContext db)
		{
			this.db = db;
		}
	}
}