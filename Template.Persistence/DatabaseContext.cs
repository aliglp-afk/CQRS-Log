using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Template.Domain.Models;

namespace Template.Persistence
{

	public class DatabaseContext : DbContext
	{
		
		public DatabaseContext
			(DbContextOptions<DatabaseContext> options) : base(options: options)
		{
			// TODO
			Database.EnsureCreated();
		}

		

		
		// **********
		public DbSet<Log> Logs { get; set; }
		// **********


		protected override void OnModelCreating
			(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}