using Microsoft.EntityFrameworkCore;

namespace ASPProject.Models
{
	public class MJDbContext : DbContext
	{
		public MJDbContext() : base()
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentID, sc.CourseID });

			modelBuilder.Entity<StudentCourse>()
				.HasOne<Student>(sc => sc.Student)
				.WithMany(s => s.StudentCourses)
				.HasForeignKey(sc => sc.StudentID);

			modelBuilder.Entity<StudentCourse>()
				.HasOne<Course>(sc => sc.Course)
				.WithMany(s => s.StudentCourses)
				.HasForeignKey(sc => sc.CourseID);

			modelBuilder.Entity<Course>()
				.HasOne<Teacher>(c => c.Teacher)
				.WithMany(t => t.Courses)
				.HasForeignKey(c => c.TeacherID);
		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Student> Teacher { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<StudentCourse> StudentCourses { get; set; }
	}
}