using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTH.Entities.Entities
{
    public class LopHoc
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int MaKhoaHoc { get; set; }
        public int MaGV { get; set; }
        public string LichHoc { get; set; }

        // hiển thị
        public string TenKhoaHoc { get; set; }
        public string TenGV { get; set; }
    }

}
