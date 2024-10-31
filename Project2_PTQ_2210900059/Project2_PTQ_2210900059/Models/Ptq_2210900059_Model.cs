using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Project2_PTQ_2210900059.Models
{
    public partial class Ptq_2210900059_Model : DbContext
    {
        public Ptq_2210900059_Model()
            : base("name=Ptq_2210900059_Model")
        {
        }

        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<VAITRO_QUYEN> VAITRO_QUYEN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.Ten_CV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.Luong_CB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIENs)
                .WithOptional(e => e.CHUCVU)
                .HasForeignKey(e => e.Ma_chuc_vu);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Ma_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Ho_Ten)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Ma_Phong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Dia_Chi)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.Ma_phong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.Ten_Phong)
                .IsFixedLength();

            modelBuilder.Entity<PHONGBAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.PHONGBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.Ten_Dang_Nhap)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.Mat_Khau)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.Ma_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VAITRO_QUYEN>()
                .Property(e => e.Ten_VT)
                .IsUnicode(false);

            modelBuilder.Entity<VAITRO_QUYEN>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.VAITRO_QUYEN)
                .WillCascadeOnDelete(false);
        }
    }
}
