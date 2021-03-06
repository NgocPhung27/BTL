namespace QLDiemHocSinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_accounts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UseName = c.String(nullable: false, maxLength: 128),
                        PassWord = c.String(nullable: false),
                        RoleID = c.String(nullable: false, maxLength: 10),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UseName);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.String(nullable: false, maxLength: 10),
                        RoleName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RoleID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Roles");
            DropTable("dbo.Accounts");
        }
    }
}
