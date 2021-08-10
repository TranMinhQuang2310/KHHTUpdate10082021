namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02082021V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SinhVienLopHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        IDAccount = c.Int(),
                        IDLopHoc = c.Int(),
                        IsDisable = c.Boolean(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.IDAccount)
                .ForeignKey("dbo.LopHocs", t => t.IDLopHoc)
                .Index(t => t.IDAccount)
                .Index(t => t.IDLopHoc);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhVienLopHocs", "IDLopHoc", "dbo.LopHocs");
            DropForeignKey("dbo.SinhVienLopHocs", "IDAccount", "dbo.Accounts");
            DropIndex("dbo.SinhVienLopHocs", new[] { "IDLopHoc" });
            DropIndex("dbo.SinhVienLopHocs", new[] { "IDAccount" });
            DropTable("dbo.SinhVienLopHocs");
        }
    }
}
