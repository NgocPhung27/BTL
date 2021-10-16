namespace QLDiemHocSinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_diemhocsinh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HocSinhs", "DiemMieng", c => c.String());
            AddColumn("dbo.HocSinhs", "Diem15Phut", c => c.String());
            AddColumn("dbo.HocSinhs", "Diem1Tiet", c => c.String());
            AddColumn("dbo.HocSinhs", "DiemHK", c => c.String());
            AddColumn("dbo.HocSinhs", "DiemTBHK", c => c.String());
            AddColumn("dbo.HocSinhs", "GhiChu", c => c.String());
            AddColumn("dbo.HocSinhs", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HocSinhs", "Discriminator");
            DropColumn("dbo.HocSinhs", "GhiChu");
            DropColumn("dbo.HocSinhs", "DiemTBHK");
            DropColumn("dbo.HocSinhs", "DiemHK");
            DropColumn("dbo.HocSinhs", "Diem1Tiet");
            DropColumn("dbo.HocSinhs", "Diem15Phut");
            DropColumn("dbo.HocSinhs", "DiemMieng");
        }
    }
}
