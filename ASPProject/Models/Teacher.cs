using System.Collections.Generic;

namespace ASPProject.Models
{
	public class Teacher
	{
		public int ID { get; set; }
		public string FName { get; set; }
		public string MName { get; set; }
		public string LName { get; set; }
		public ICollection<Course> Courses { get; set; }
	}
}