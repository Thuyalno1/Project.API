using Application.DTO.NhanVien;
using Application.DTOs.Common;
using Application.IRepositories;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<NhanVienDTO>> GetAllAsync(QueryDTO model)
        {
            String keyword = model.Keyword?.Trim().ToLower() ?? string.Empty;
            var query = _context.nhanViens
                .Where(x => x.HoatDong && (string.IsNullOrEmpty(keyword) || x.Ma.ToLower().Contains(keyword) || x.Ten.ToLower().Contains(keyword)));

            model.Total = await query.CountAsync();

            return await query
                .Select(x => new NhanVienDTO
                {
                    Id = x.Id,
                    Ma = x.Ma,
                    Ten = x.Ten,
                    ChucVu = x.ChucVu,
                    Address = x.Address,
                    Email = x.Email
                })
                .OrderByDescending(x => x.Id)
                .OrderByDescending(x => x.Ma)
                .Skip((model.Page - 1) * model.PageSize)
                .Take(model.PageSize)
                .ToListAsync();

        } 
    }
}

