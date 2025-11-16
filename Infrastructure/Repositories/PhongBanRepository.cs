using Application.IRepositories;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PhongBanRepository : IPhongBanRepository
    {
        public readonly AppDbContext _context;

        public PhongBanRepository (AppDbContext context)
        {
            _context = context;
        }


        public async Task<bool> Exist(int id)
        { 
            var pb = await _context.phongBans.FindAsync(id);
            if( pb != null)
            {
                return true;
            }
            return false;
            

        }
    }
}
