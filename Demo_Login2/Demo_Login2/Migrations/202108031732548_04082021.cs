namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _04082021 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.GiangVienMonHocs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GiangVienMonHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDMonHoc = c.Int(nullable: false),
                        IDGiangVien = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
