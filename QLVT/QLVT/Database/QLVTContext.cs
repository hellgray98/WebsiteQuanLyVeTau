using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using QLVT.Models;

namespace QLVT.Database
{
    public class QLVTContext:DbContext
    {
        public QLVTContext() : base()
        {
            string databasename = "QuanLyVeTau";
            this.Database.Connection.ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=" + databasename + ";Trusted_Connection=Yes";

        }
        public DbSet<DSTau> TbDSTau { get; set; }
        public DbSet<GaTau> TbGaTau { get; set; }
        public DbSet<HangVe> TbHangVe { get; set; }
        public DbSet<KhachHang> TbKhachHang { get; set; }
        public DbSet<KhoangNam> TbKhoangNam { get; set; }
        public DbSet<LichTau> TbLichTau { get; set; }
        public DbSet<VeTau> TbVeTau { get; set; }
        public DbSet<CT_GaTrungGian> TbCt_GaTrungGian { get; set; }
        public DbSet<CT_LichTau_VeTau> TbCt_LichTau_Vetau { get; set; }
        public DbSet<ThamSo> TbThamso { get; set; }
        public DbSet<QuanLyGheTau> TbQuanLyGheTau { get; set; }
        public DbSet<User> TbUser { get; set; }
        public DbSet<ToaTau> TbToaTau { get; set; }
    }
}