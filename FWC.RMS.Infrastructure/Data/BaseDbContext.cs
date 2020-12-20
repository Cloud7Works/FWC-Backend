using Microsoft.EntityFrameworkCore;

namespace FWC.RMS.Infrastructure.Data
{
    public abstract class BaseDbContext<TDbContext> : DbContext where TDbContext : DbContext
    {
        protected BaseDbContext(DbContextOptions<TDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			ApplyConfigurations(modelBuilder);
        }

		protected virtual void ApplyConfigurations(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(TDbContext).Assembly);
		}
	}
}
