﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLDiemHocSinh.Models
{
    public class DiemHocSinh : QLHocSinh
    {
        [Key]
        [Display(Name = "Điểm miệng")]
        public string DiemMieng { get; set; }
        [Display(Name = "Điểm 15 phút")]
        public string Diem15Phut { get; set; }
        [Display(Name = "Điểm 1 tiết")]
        public string Diem1Tiet { get; set; }
        [Display(Name = "Điểm học kỳ")]
        public string DiemHK{ get; set; }
        [Display(Name = "Điểm TB học kỳ")]
        public string DiemTBHK{ get; set; }
        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }
    }
}