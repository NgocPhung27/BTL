using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDiemHocSinh.Models
{
    [Table("Giaoviens")]
    public class QLGiaoVien
    {
        [Key]
        public string MaGV { get; set; }
        public string TenGV { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        [AllowHtml]
        public string AnhGV { get; set; }
    }
}