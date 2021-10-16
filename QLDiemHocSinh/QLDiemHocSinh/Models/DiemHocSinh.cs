using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLDiemHocSinh.Models
{
    public class DiemHocSinh : QLHocSinh
    {
        public string DiemMieng { get; set; }
        public string Diem15Phut { get; set; }
        public string Diem1Tiet { get; set; }
        public string DiemHK{ get; set; }
        public string DiemTBHK{ get; set; }
        public string GhiChu { get; set; }
    }
}