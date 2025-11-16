using Application.IRepositories;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<AppDbContext>(opt => opt.UseSqlServer(connectionString));

            // Danh mục thủ tục hành chính
            services.AddScoped<INhanVienRepository,NhanVienRepository>();
            services.AddScoped<IPhongBanRepository,PhongBanRepository>();
      
            // Thao Tac

            return services;
        }
    }
}
