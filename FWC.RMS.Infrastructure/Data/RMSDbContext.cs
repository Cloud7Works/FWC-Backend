using FWC.RMS.ApplicationCore.Data;
using FWC.RMS.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace FWC.RMS.Infrastructure.Data
{

    public class RMSDbContext : DbContext
    {
        public RMSDbContext(DbContextOptions<RMSDbContext> options) : base(options)
        {
        }

        public DbSet<Transmittal> Transmittals { get; set; }
        public DbSet<DepartmentDocument> DepartmentDocuments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<Transmittal>()
             .HasMany(t => t.DepartmentDocuments)
            .WithOne();

            builder.Entity<DepartmentDocument>()
            .HasOne(d => d.Transmittal)
            .WithMany(t => t.DepartmentDocuments)
            .HasForeignKey(d => d.TransmittalNumber);

            builder.Entity<Transmittal>()
                .Navigation(t => t.DepartmentDocuments)
                    .UsePropertyAccessMode(PropertyAccessMode.Property);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ChangeTracker.DetectChanges();

            var modified = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);
            var added = ChangeTracker.Entries().Where(x => x.State == EntityState.Added);

            foreach (var item in modified)
            {
                if (item.Entity is IAuditable entity )
                {
                    item.CurrentValues[nameof(IAuditable.ModifiedBy)] = "AppUser";//Replace it with authenticated user
                    item.CurrentValues[nameof(IAuditable.ModifiedOn)] = System.DateTime.Now;
                }
            }

            foreach (var item in added)
            {
                if (item.Entity is IAuditable entity)
                {
                    item.CurrentValues[nameof(IAuditable.CreatedBy)] = "AppUser";//Replace it with authenticated user
                    item.CurrentValues[nameof(IAuditable.CreatedOn)] = System.DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
