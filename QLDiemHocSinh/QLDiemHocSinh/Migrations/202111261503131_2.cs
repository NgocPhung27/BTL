namespace QLDiemHocSinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Giaoviens", "MaLop", c => c.String(maxLength: 128));
            CreateIndex("dbo.Giaoviens", "MaLop");
            AddForeignKey("dbo.Giaoviens", "MaLop", "dbo.Lops", "MaLop");
            DropColumn("dbo.Giaoviens", "Lop");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Giaoviens", "Lop", c => c.String());
            DropForeignKey("dbo.Giaoviens", "MaLop", "dbo.Lops");
            DropIndex("dbo.Giaoviens", new[] { "MaLop" });
            DropColumn("dbo.Giaoviens", "MaLop");
        }
    }
}
