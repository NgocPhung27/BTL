namespace QLDiemHocSinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kingkong : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Accounts", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "UserName", c => c.String());
        }
    }
}
