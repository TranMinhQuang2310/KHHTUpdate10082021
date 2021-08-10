namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _31072021V2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountLopHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDLopHoc = c.Int(),
                        IDAccount = c.Int(),
                        IsDisabled = c.Boolean(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.IDAccount)
                .ForeignKey("dbo.LopHocs", t => t.IDLopHoc)
                .Index(t => t.IDLopHoc)
                .Index(t => t.IDAccount);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ma = c.String(maxLength: 10),
                        HoVaTen = c.String(),
                        MailVL = c.String(),
                        PhanLoai = c.Int(nullable: false),
                        DaXem = c.Boolean(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDKhoaDaoTao = c.Int(),
                        TenLop = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.KhoaDaoTaos", t => t.IDKhoaDaoTao)
                .Index(t => t.IDKhoaDaoTao);
            
            CreateTable(
                "dbo.KhoaDaoTaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenKhoaDaoTao = c.String(),
                        NienKhoa = c.String(),
                        IDLoaiHinhDaoTao = c.Int(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LoaiHinhDaoTaos", t => t.IDLoaiHinhDaoTao)
                .Index(t => t.IDLoaiHinhDaoTao);
            
            CreateTable(
                "dbo.LoaiHinhDaoTaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenLoaiHinh = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DaoTaoHocKis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDKeHoachDaoTao = c.Int(nullable: false),
                        IDHocKi = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
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
            
            CreateTable(
                "dbo.HocKis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenHocKi = c.String(),
                        IDPhanLoaiHocKi = c.Int(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PhanLoaiHocKis", t => t.IDPhanLoaiHocKi)
                .Index(t => t.IDPhanLoaiHocKi);
            
            CreateTable(
                "dbo.PhanLoaiHocKis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LoaiHocKi = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HocPhanTienQuyets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDMonHoc = c.Int(),
                        IDMonHocTienQuyet = c.Int(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KeHoachDaoTaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDKhoaDaoTao = c.Int(nullable: false),
                        TenKeHoachDaoTao = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KeHoachHocTaps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDKeHoachDaoTao = c.Int(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                        HocLai = c.Boolean(nullable: false),
                        HocVuot = c.Boolean(nullable: false),
                        CaiThien = c.Boolean(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KhoaBoMons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenKhoaBoMon = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
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
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDKhoaBoMon = c.Int(nullable: false),
                        MaMonHoc = c.String(),
                        TenMonHoc = c.String(),
                        HocPhanTienQuyet = c.Boolean(nullable: false),
                        HocPhanHocTruoc = c.Boolean(nullable: false),
                        SoTiet = c.Int(nullable: false),
                        SoTietLyThuyet = c.Int(nullable: false),
                        SoTietThucHanh = c.Int(nullable: false),
                        LoaiMonHoc = c.Int(nullable: false),
                        SoTinChi = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SinhVienKeHoachHocTaps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDSinhVien = c.Int(nullable: false),
                        IDKeHoachHocTap = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HocKis", "IDPhanLoaiHocKi", "dbo.PhanLoaiHocKis");
            DropForeignKey("dbo.LopHocs", "IDKhoaDaoTao", "dbo.KhoaDaoTaos");
            DropForeignKey("dbo.KhoaDaoTaos", "IDLoaiHinhDaoTao", "dbo.LoaiHinhDaoTaos");
            DropForeignKey("dbo.AccountLopHocs", "IDLopHoc", "dbo.LopHocs");
            DropForeignKey("dbo.AccountLopHocs", "IDAccount", "dbo.Accounts");
            DropIndex("dbo.HocKis", new[] { "IDPhanLoaiHocKi" });
            DropIndex("dbo.KhoaDaoTaos", new[] { "IDLoaiHinhDaoTao" });
            DropIndex("dbo.LopHocs", new[] { "IDKhoaDaoTao" });
            DropIndex("dbo.AccountLopHocs", new[] { "IDAccount" });
            DropIndex("dbo.AccountLopHocs", new[] { "IDLopHoc" });
            DropTable("dbo.SinhVienKeHoachHocTaps");
            DropTable("dbo.MonHocs");
            DropTable("dbo.MonHocHocKis");
            DropTable("dbo.KhoaBoMons");
            DropTable("dbo.KeHoachHocTaps");
            DropTable("dbo.KeHoachDaoTaos");
            DropTable("dbo.HocPhanTienQuyets");
            DropTable("dbo.PhanLoaiHocKis");
            DropTable("dbo.HocKis");
            DropTable("dbo.GiangVienMonHocs");
            DropTable("dbo.DaoTaoHocKis");
            DropTable("dbo.LoaiHinhDaoTaos");
            DropTable("dbo.KhoaDaoTaos");
            DropTable("dbo.LopHocs");
            DropTable("dbo.Accounts");
            DropTable("dbo.AccountLopHocs");
        }
    }
}
