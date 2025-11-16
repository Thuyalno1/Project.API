using Application.DTO.NhanVien;
using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface INhanVienService
    {
        Task<bool> CreateAsync(BaseRequestDTO<CreateNhanVienDTO> model);


    }
}
