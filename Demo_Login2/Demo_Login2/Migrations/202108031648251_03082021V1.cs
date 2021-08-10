namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _03082021V1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.MonHocHocKis");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MonHocHocKis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDMonHoc = c.Int(nullable: false),
                        IDHocKi = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
