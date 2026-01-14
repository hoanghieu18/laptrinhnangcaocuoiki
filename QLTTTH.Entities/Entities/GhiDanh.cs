using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTH.Entities.Entities
{
    public class GhiDanh
    {
        public int MaHV { get; set; }
        public int MaLop { get; set; }
        public DateTime NgayDangKy { get; set; }

        // dùng để hiển thị
        public string TenHV { get; set; }
        public string TenLop { get; set; }
    }

}
