namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _03082021 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonHocKhoaDaoTaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDMonHoc = c.Int(),
                        IDKhoaDaoTao = c.Int(),
                        IDHocKi = c.Int(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.HocKis", t => t.IDHocKi)
                .ForeignKey("dbo.KhoaDaoTaos", t => t.IDKhoaDaoTao)
                .ForeignKey("dbo.MonHocs", t => t.IDMonHoc)
                .Index(t => t.IDMonHoc)
                .Index(t => t.IDKhoaDaoTao)
                .Index(t => t.IDHocKi);
            
            AlterColumn("dbo.MonHocs", "IDKhoaBoMon", c => c.Int());
            CreateIndex("dbo.MonHocs", "IDKhoaBoMon");
            AddForeignKey("dbo.MonHocs", "IDKhoaBoMon", "dbo.KhoaBoMons", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonHocKhoaDaoTaos", "IDMonHoc", "dbo.MonHocs");
            DropForeignKey("dbo.MonHocs", "IDKhoaBoMon", "dbo.KhoaBoMons");
            DropForeignKey("dbo.MonHocKhoaDaoTaos", "IDKhoaDaoTao", "dbo.KhoaDaoTaos");
            DropForeignKey("dbo.MonHocKhoaDaoTaos", "IDHocKi", "dbo.HocKis");
            DropIndex("dbo.MonHocs", new[] { "IDKhoaBoMon" });
            DropIndex("dbo.MonHocKhoaDaoTaos", new[] { "IDHocKi" });
            DropIndex("dbo.MonHocKhoaDaoTaos", new[] { "IDKhoaDaoTao" });
            DropIndex("dbo.MonHocKhoaDaoTaos", new[] { "IDMonHoc" });
            AlterColumn("dbo.MonHocs", "IDKhoaBoMon", c => c.Int(nullable: false));
            DropTable("dbo.MonHocKhoaDaoTaos");
        }
    }
}
