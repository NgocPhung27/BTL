namespace QLDiemHocSinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_giaovien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Giaoviens",
                c => new
                    {
                        MaGV = c.String(nullable: false, maxLength: 128),
                        TenGV = c.String(),
                        GioiTinh = c.String(),
                        NgaySinh = c.String(),
                        SoDienThoai = c.String(),
                        DiaChi = c.String(),
                        Lop = c.String(),
                    })
                .PrimaryKey(t => t.MaGV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Giaoviens");
        }
    }
}
