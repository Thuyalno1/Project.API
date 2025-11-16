using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CongViec:BaseCode
    {
        public string DoUuTien {  get; set; }
        public string MoTa {  get; set; }


        public int NhanVienId { get; set; }
        public NhanVien nhanVien { get; set; }
    }
}
