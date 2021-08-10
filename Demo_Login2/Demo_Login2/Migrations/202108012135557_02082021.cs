namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02082021 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountLopHocs", "Name", c => c.Int(nullable: false));
            DropColumn("dbo.AccountLopHocs", "TenGiaoVien");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AccountLopHocs", "TenGiaoVien", c => c.Int(nullable: false));
            DropColumn("dbo.AccountLopHocs", "Name");
        }
    }
}
