using Application.DTO.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface INhanVienRepository
    {
        Task AddAsync(CreateNhanVienDTO createNhanVienDTO);

    }
}
