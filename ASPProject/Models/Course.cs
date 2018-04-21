using System.Collections.Generic;

namespace ASPProject.Models
{
	public class Course
	{
		public string Code { get; set; }
		public int Credits { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int TeacherID { get; set; }
		public Teacher Teacher { get; set; }
		public IList<StudentCourse> StudentCourses { get; set; }
	}
}