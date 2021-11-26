namespace QLDiemHocSinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HocSinhs", "TenHS", c => c.String(nullable: false));
            AlterColumn("dbo.Giaoviens", "TenGV", c => c.String(nullable: false));
            AlterColumn("dbo.Lops", "TenLop", c => c.String(nullable: false));
            AlterColumn("dbo.MonHocs", "TenMH", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MonHocs", "TenMH", c => c.String());
            AlterColumn("dbo.Lops", "TenLop", c => c.String());
            AlterColumn("dbo.Giaoviens", "TenGV", c => c.String());
            AlterColumn("dbo.HocSinhs", "TenHS", c => c.String());
        }
    }
}
