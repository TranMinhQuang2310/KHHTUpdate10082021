namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _07082021 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhanLoaiMonHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LoaiMonHoc = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhanLoaiMonHocs");
        }
    }
}
