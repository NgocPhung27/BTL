using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDiemHocSinh.Models
{
    [Table("HocSinhs")]
    public class QLHocSinh
    {
        [Key]
        public string MaHS { get; set; }

        public string TenHS { get; set; }

        public string GioiTinh { get; set; }

        public string NgaySinh { get; set; }

        public string SoDienThoai { get; set; }

        public string DiaChi { get; set; }
        public string Lop { get; set; }
        [AllowHtml]
        public string AnhHS { get; set; }
    }

}