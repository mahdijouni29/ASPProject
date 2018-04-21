using System.Collections.Generic;

namespace ASPProject.Models
{
	public class Student
	{
		public int ID { get; set; }
		public string Pass { get; set; }
		public string FName { get; set; }
		public string MName { get; set; }
		public string LName { get; set; }
		public IList<StudentCourse> StudentCourses { get; set; }
	}
}