namespace QLDiemHocSinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_hocsinh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HocSinhs",
                c => new
                    {
                        MaHS = c.String(nullable: false, maxLength: 128),
                        TenHS = c.String(),
                        GioiTinh = c.String(),
                        NgaySinh = c.String(),
                        SoDienThoai = c.String(),
                        DiaChi = c.String(),
                        Lop = c.String(),
                        AnhHS = c.String(),
                    })
                .PrimaryKey(t => t.MaHS);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HocSinhs");
        }
    }
}
