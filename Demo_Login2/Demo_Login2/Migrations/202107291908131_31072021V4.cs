namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _31072021V4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhanLoaiTaiKhoans",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LoaiTaiKhoan = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhanLoaiTaiKhoans");
        }
    }
}
