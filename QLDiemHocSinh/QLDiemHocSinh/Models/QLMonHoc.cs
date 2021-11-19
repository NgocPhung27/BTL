using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDiemHocSinh.Models
{
    [Table("MonHocs")]
    public class QLMonHoc
    {
        [Key]
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        [AllowHtml]
        public string GhiChu { get; set; }
    }
}