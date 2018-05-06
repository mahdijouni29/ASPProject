using ASPProject.Models;

namespace ASPProject.Repositories
{
    public class StudentRepository
	{
		private MJDbContext db;

		public StudentRepository(MJDbContext db)
		{
			this.db = db;
		}
	}
}
