using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLDiemHocSinh.Models
{
    public partial class QLDiemHocSinhDbContext : DbContext
    {
        public QLDiemHocSinhDbContext()
            : base("name=QLDiemHocSinhDbContext")
        {
        }
        public virtual DbSet<QLGiaoVien> GiaoViens { get; set; }
        public virtual DbSet<QLHocSinh> HocSinhs { get; set; }
        public virtual DbSet<DiemHocSinh> DiemHocSinhs { get; set; }
        public virtual DbSet<QLMonHoc> MonHocs { get; set; }
        public virtual DbSet<QLLop> Lops { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
