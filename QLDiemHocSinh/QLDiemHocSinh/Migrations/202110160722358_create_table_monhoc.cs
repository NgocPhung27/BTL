namespace QLDiemHocSinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_monhoc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        MaMH = c.String(nullable: false, maxLength: 128),
                        TenMH = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.MaMH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MonHocs");
        }
    }
}
