using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class NhanVien:BaseCode
    {
        public string ChucVu { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty;

        // Noi moi quan he nhan vien 1 - 1pb

        public int? PhongBanId { get; set; }
        public PhongBan PhongBan { get; set; }

        List<CongViec> congViecs { get; set; }

    }
}
