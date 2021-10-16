namespace QLDiemHocSinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_lop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        MaLop = c.String(nullable: false, maxLength: 128),
                        TenLop = c.String(),
                        NienKhoa = c.String(),
                        SiSo = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lops");
        }
    }
}
