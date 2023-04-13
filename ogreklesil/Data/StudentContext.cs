using Microsoft.EntityFrameworkCore;
using ogreklesil.Models.Repositories;

namespace ogreklesil.Data
{
    public class StudentContext : DbContext
	{
		public StudentContext(DbContextOptions<StudentContext> options)
		: base(options)
		{
		}

		public DbSet<Student> Students { get; set; }
	}
}
