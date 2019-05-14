namespace QLVT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CT_GaTrungGian",
                c => new
                    {
                        MaGaTrungGian = c.Int(nullable: false, identity: true),
                        MaLichTau = c.Int(),
                        MaGa = c.Int(),
                        ThoiGianDung = c.String(),
                    })
                .PrimaryKey(t => t.MaGaTrungGian)
                .ForeignKey("dbo.GaTau", t => t.MaGa)
                .ForeignKey("dbo.LichTau", t => t.MaLichTau)
                .Index(t => t.MaLichTau)
                .Index(t => t.MaGa);
            
            CreateTable(
                "dbo.GaTau",
                c => new
                    {
                        MaGaTau = c.Int(nullable: false, identity: true),
                        TenGa = c.String(),
                        Loai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaGaTau);

            CreateTable(
                "dbo.LichTau",
                c => new
                {
                    MaLichTau = c.Int(nullable: false, identity: true),
                    MaTau = c.Int(),
                    MaGaDi = c.Int(),
                    MaGaDen = c.Int(),
                    NgayDi = c.DateTime(nullable: false),
                    ThoiGianDi = c.String(),
                    ThoiGianDen = c.String(),
                })
                .PrimaryKey(t => t.MaLichTau)
                .ForeignKey("dbo.GaTau", t => t.MaGaDen)
                .ForeignKey("dbo.GaTau", t => t.MaGaDi)
                .ForeignKey("dbo.DSTau", t => t.MaTau)
                .Index(t => t.MaTau)
                .Index(t => t.MaGaDi)
                .Index(t => t.MaGaDen);

            CreateTable(
                "dbo.CT_LichTau_VeTau",
                c => new
                {
                    MaViTri = c.Int(nullable: false, identity: true),
                    MaLichTau = c.Int(),
                    DaDat = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.MaViTri)
                .ForeignKey("dbo.LichTau", t => t.MaLichTau)
                .Index(t => t.MaLichTau);

            CreateTable(
                "dbo.VeTau",
                c => new
                {
                    MaVeTau = c.Int(nullable: false, identity: true),
                    MaLichTau = c.Int(),
                    MaKhachHang = c.Int(),
                    MaHangVe = c.Int(),
                    MaToa = c.Int(),
                    MaViTri = c.Int(),
                    GiaTien = c.String(),
                    SoLuongKhach = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.MaVeTau)
                .ForeignKey("dbo.HangVe", t => t.MaHangVe)
                .ForeignKey("dbo.KhachHang", t => t.MaKhachHang)
                .ForeignKey("dbo.LichTau", t => t.MaLichTau)
                .ForeignKey("dbo.ToaTau", t => t.MaToa)
                .ForeignKey("dbo.CT_LichTau_VeTau", t => t.MaViTri)
                .Index(t => t.MaLichTau)
                .Index(t => t.MaKhachHang)
                .Index(t => t.MaHangVe)
                .Index(t => t.MaToa)
                .Index(t => t.MaViTri);
            
            CreateTable(
                "dbo.HangVe",
                c => new
                    {
                        MaHangVe = c.Int(nullable: false, identity: true),
                        TenHangVeset = c.String(),
                        MaKhoangNam = c.Int(),
                    })
                .PrimaryKey(t => t.MaHangVe)
                .ForeignKey("dbo.KhoangNam", t => t.MaKhoangNam)
                .Index(t => t.MaKhoangNam);
            
            CreateTable(
                "dbo.KhoangNam",
                c => new
                    {
                        MaKhoangNam = c.Int(nullable: false, identity: true),
                        ViTriKhoang_4 = c.String(),
                        ViTriKhoang_6 = c.String(),
                    })
                .PrimaryKey(t => t.MaKhoangNam);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKhachHang = c.Int(nullable: false, identity: true),
                        TenKhachHang = c.String(),
                        CMND = c.String(),
                        SoDienThoai = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaKhachHang);

            CreateTable(
                "dbo.ToaTau",
                c => new
                {
                    MaToaTau = c.Int(nullable: false, identity: true),
                    TenToaTau = c.Int(nullable: false),
                    MaTau = c.Int(),
                    MaHV = c.Int(),
                    SoGhe = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.MaToaTau)
                .ForeignKey("dbo.HangVe", t => t.MaHV)
                .ForeignKey("dbo.DSTau", t => t.MaTau)
                .Index(t => t.MaTau)
                .Index(t => t.MaHV);
            
            CreateTable(
                "dbo.DSTau",
                c => new
                    {
                        MaDSTau = c.Int(nullable: false, identity: true),
                        TenTau = c.String(),
                        SoLuongKhoang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaDSTau);
            
            CreateTable(
                "dbo.QuanLyGheTau",
                c => new
                    {
                        MaQLGhe = c.Int(nullable: false, identity: true),
                        MaTau = c.Int(),
                        MaToa = c.Int(),
                        TenViTri = c.String(),
                    })
                .PrimaryKey(t => t.MaQLGhe)
                .ForeignKey("dbo.DSTau", t => t.MaTau)
                .ForeignKey("dbo.ToaTau", t => t.MaToa)
                .Index(t => t.MaTau)
                .Index(t => t.MaToa);
            
            CreateTable(
                "dbo.ThamSo",
                c => new
                    {
                        MaThamSo = c.Int(nullable: false, identity: true),
                        GiaTri = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.MaThamSo);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CT_GaTrungGian", "MaLichTau", "dbo.LichTau");
            DropForeignKey("dbo.CT_GaTrungGian", "MaGa", "dbo.GaTau");
            DropForeignKey("dbo.LichTau", "MaTau", "dbo.DSTau");
            DropForeignKey("dbo.LichTau", "MaGaDi", "dbo.GaTau");
            DropForeignKey("dbo.LichTau", "MaGaDen", "dbo.GaTau");
            DropForeignKey("dbo.VeTau", "MaViTri", "dbo.CT_LichTau_VeTau");
            DropForeignKey("dbo.VeTau", "MaToa", "dbo.ToaTau");
            DropForeignKey("dbo.ToaTau", "MaTau", "dbo.DSTau");
            DropForeignKey("dbo.QuanLyGheTau", "MaToa", "dbo.ToaTau");
            DropForeignKey("dbo.QuanLyGheTau", "MaTau", "dbo.DSTau");
            DropForeignKey("dbo.ToaTau", "MaHV", "dbo.HangVe");
            DropForeignKey("dbo.VeTau", "MaLichTau", "dbo.LichTau");
            DropForeignKey("dbo.VeTau", "MaKhachHang", "dbo.KhachHang");
            DropForeignKey("dbo.VeTau", "MaHangVe", "dbo.HangVe");
            DropForeignKey("dbo.HangVe", "MaKhoangNam", "dbo.KhoangNam");
            DropForeignKey("dbo.CT_LichTau_VeTau", "MaLichTau", "dbo.LichTau");
            DropIndex("dbo.QuanLyGheTau", new[] { "MaToa" });
            DropIndex("dbo.QuanLyGheTau", new[] { "MaTau" });
            DropIndex("dbo.ToaTau", new[] { "MaHV" });
            DropIndex("dbo.ToaTau", new[] { "MaTau" });
            DropIndex("dbo.HangVe", new[] { "MaKhoangNam" });
            DropIndex("dbo.VeTau", new[] { "MaViTri" });
            DropIndex("dbo.VeTau", new[] { "MaToa" });
            DropIndex("dbo.VeTau", new[] { "MaHangVe" });
            DropIndex("dbo.VeTau", new[] { "MaKhachHang" });
            DropIndex("dbo.VeTau", new[] { "MaLichTau" });
            DropIndex("dbo.CT_LichTau_VeTau", new[] { "MaLichTau" });
            DropIndex("dbo.LichTau", new[] { "MaGaDen" });
            DropIndex("dbo.LichTau", new[] { "MaGaDi" });
            DropIndex("dbo.LichTau", new[] { "MaTau" });
            DropIndex("dbo.CT_GaTrungGian", new[] { "MaGa" });
            DropIndex("dbo.CT_GaTrungGian", new[] { "MaLichTau" });
            DropTable("dbo.User");
            DropTable("dbo.ThamSo");
            DropTable("dbo.QuanLyGheTau");
            DropTable("dbo.DSTau");
            DropTable("dbo.ToaTau");
            DropTable("dbo.KhachHang");
            DropTable("dbo.KhoangNam");
            DropTable("dbo.HangVe");
            DropTable("dbo.VeTau");
            DropTable("dbo.CT_LichTau_VeTau");
            DropTable("dbo.LichTau");
            DropTable("dbo.GaTau");
            DropTable("dbo.CT_GaTrungGian");
        }
    }
}
