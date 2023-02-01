using Microsoft.EntityFrameworkCore;
using Template.Domain.Models;

namespace Template.Persistence
{
	public class QueryDatabaseContext :DbContext
	{
		public QueryDatabaseContext
			(DbContextOptions<QueryDatabaseContext> options) : base(options: options)
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
