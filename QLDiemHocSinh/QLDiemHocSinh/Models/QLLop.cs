using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDiemHocSinh.Models
{
    [Table("Lops")]
    public class QLLop
    {     
        [Key]
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string NienKhoa { get; set; }
        public string SiSo { get; set; }
        [AllowHtml]
        public string GhiChu { get; set; }
    }
}