using Microsoft.EntityFrameworkCore;
using System;

namespace Questions2.Models
{
    public class BridgeContext : DbContext
    {
        public BridgeContext(DbContextOptions<BridgeContext> options) : base(options)
        {
        }
        public DbSet<BridgeTable> BridgeTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BridgeTable>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }
    }
}
