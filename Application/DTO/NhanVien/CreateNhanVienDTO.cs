using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.NhanVien
{
    public class CreateNhanVienDTO
    {

        public string? Ma { get; set; }
        public string? Ten { get; set; }
        public string ChucVu { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Noi moi quan he nhan vien 1 - 1pb

        public PhongBan? PhongBan { get; set; }


    }
}
