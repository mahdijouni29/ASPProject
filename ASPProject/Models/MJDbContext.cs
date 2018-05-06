using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPProject.Models
{
	public class MJDbContext : IdentityDbContext<AppUser>
	{
		public MJDbContext(DbContextOptions options) : base(options)
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

		public DbSet<Admin> Admins { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<StudentCourse> StudentCourses { get; set; }
	}
}