using Application.DTO.NhanVien;
using Application.IRepositories;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {

        public readonly AppDbContext _context;

        public NhanVienRepository(AppDbContext context)
        {
            _context = context;
        }

        //                                     request
        public async Task AddAsync(CreateNhanVienDTO request)
        {
            try
            {
                // mapp requet -> model
                var entity = new NhanVien
                {
                    Ma = request.Ma,
                    Ten = request.Ten,
                    HoatDong = true,
                    ChucVu = request.ChucVu,
                    Address = request.Address,
                    Email = request.Email,
                    PhongBanId = request.PhongBan.Id
                };

                await _context.nhanViens.AddAsync(entity);
                await _context.SaveChangesAsync();   
            }
            catch (System.Exception)
            {
                throw;
            }

        }
    }
}
