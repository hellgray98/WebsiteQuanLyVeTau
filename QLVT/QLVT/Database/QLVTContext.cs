using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using QLVT.Models;

namespace QLVT.Database
{
    public class QLVTContext:DbContext
    {
        public QLVTContext() : base("QuanLyVeTauContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
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