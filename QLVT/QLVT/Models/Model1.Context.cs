﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLVT.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyVeTauContextEntities : DbContext
    {
        public QuanLyVeTauContextEntities()
            : base("name=QuanLyVeTauContextEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<BCDoanhThuThang> BCDoanhThuThangs { get; set; }
        public virtual DbSet<CT_GaTrungGian> CT_GaTrungGian { get; set; }
        public virtual DbSet<CT_LichTau_VeTau> CT_LichTau_VeTau { get; set; }
        public virtual DbSet<DSTau> DSTaus { get; set; }
        public virtual DbSet<GaTau> GaTaus { get; set; }
        public virtual DbSet<HangVe> HangVes { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhoangNam> KhoangNams { get; set; }
        public virtual DbSet<LichTau> LichTaus { get; set; }
        public virtual DbSet<QuanLyGheTau> QuanLyGheTaus { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThamSo> ThamSoes { get; set; }
        public virtual DbSet<ToaTau> ToaTaus { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VeTau> VeTaus { get; set; }
    }
}
