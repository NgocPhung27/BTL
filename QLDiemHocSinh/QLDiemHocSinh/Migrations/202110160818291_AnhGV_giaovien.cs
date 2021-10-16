namespace QLDiemHocSinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnhGV_giaovien : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Giaoviens", "AnhGV", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Giaoviens", "AnhGV");
        }
    }
}
