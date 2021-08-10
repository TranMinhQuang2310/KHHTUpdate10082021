namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _31072021V5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountLopHocs", "TenGiaoVien", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AccountLopHocs", "TenGiaoVien");
        }
    }
}
