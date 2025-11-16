
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // --- Schema TiepNhan ---
		public DbSet<CongViec> congViecs { get; set; }
		public DbSet<NhanVien> nhanViens { get; set; }
		public DbSet<PhongBan> phongBans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

		}
	}
}
