using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.NhanVien
{
    public class NhanVienDTO
    {

        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public bool HoatDong { get; set; }
        public string ChucVu { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;


    }
}
