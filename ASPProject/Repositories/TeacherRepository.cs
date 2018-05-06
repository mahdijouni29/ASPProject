using ASPProject.Models;

namespace ASPProject.Repositories
{
	public class TeacherRepository
	{
		private MJDbContext db;

		public TeacherRepository(MJDbContext db)
		{
			this.db = db;
		}
	}
}