using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NHNT_G08.Models;

public partial class BtlNhntG08Context : DbContext
{
    public BtlNhntG08Context()
    {
    }

    public BtlNhntG08Context(DbContextOptions<BtlNhntG08Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TblDanhGiaPhong> TblDanhGiaPhongs { get; set; }

    public virtual DbSet<TblDmTaiKhoan> TblDmTaiKhoans { get; set; }

    public virtual DbSet<TblHinhAnh> TblHinhAnhs { get; set; }

    public virtual DbSet<TblPhong> TblPhongs { get; set; }

    public virtual DbSet<TblTaiKhoan> TblTaiKhoans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=PVQUANG1989\\PVQUANG;Initial Catalog=BTL_NHNT_G08;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblDanhGiaPhong>(entity =>
        {
            entity.HasKey(e => e.MaDanhGia).HasName("PK__tblDanhG__6B15DD9ADE027197");

            entity.ToTable("tblDanhGiaPhong");

            entity.Property(e => e.MaDanhGia).HasColumnName("maDanhGia");
            entity.Property(e => e.MaPhong).HasColumnName("maPhong");
            entity.Property(e => e.MaTaiKhoan).HasColumnName("maTaiKhoan");
            entity.Property(e => e.SoSao).HasColumnName("soSao");

            entity.HasOne(d => d.MaPhongNavigation).WithMany(p => p.TblDanhGiaPhongs)
                .HasForeignKey(d => d.MaPhong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblDanhGi__maPho__52593CB8");

            entity.HasOne(d => d.MaTaiKhoanNavigation).WithMany(p => p.TblDanhGiaPhongs)
                .HasForeignKey(d => d.MaTaiKhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblDanhGi__maTai__534D60F1");
        });

        modelBuilder.Entity<TblDmTaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaDmTaiKhoan).HasName("PK__tblDmTai__7CAB5CC3D09EDB99");

            entity.ToTable("tblDmTaiKhoan");

            entity.Property(e => e.MaDmTaiKhoan).HasColumnName("maDmTaiKhoan");
            entity.Property(e => e.TenLoaiTk)
                .HasMaxLength(50)
                .HasColumnName("tenLoaiTK");
        });

        modelBuilder.Entity<TblHinhAnh>(entity =>
        {
            entity.HasKey(e => e.MaAnh).HasName("PK__tblHinhA__184D7736F9F7B43F");

            entity.ToTable("tblHinhAnh");

            entity.Property(e => e.MaAnh).HasColumnName("maAnh");
            entity.Property(e => e.DuongDan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("duongDan");
            entity.Property(e => e.MaPhong).HasColumnName("maPhong");

            entity.HasOne(d => d.MaPhongNavigation).WithMany(p => p.TblHinhAnhs)
                .HasForeignKey(d => d.MaPhong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblHinhAn__maPho__5441852A");
        });

        modelBuilder.Entity<TblPhong>(entity =>
        {
            entity.HasKey(e => e.MaPhong).HasName("PK__tblPhong__4CD55E10F264203B");

            entity.ToTable("tblPhong");

            entity.Property(e => e.MaPhong).HasColumnName("maPhong");
            entity.Property(e => e.ChiTietPhong)
                .HasMaxLength(1000)
                .HasColumnName("chiTietPhong");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(500)
                .HasColumnName("diaChi");
            entity.Property(e => e.DienTich).HasColumnName("dienTich");
            entity.Property(e => e.GiaDien).HasColumnName("giaDien");
            entity.Property(e => e.GiaNuoc).HasColumnName("giaNuoc");
            entity.Property(e => e.GiaPhong).HasColumnName("giaPhong");
            entity.Property(e => e.MaTaiKhoan).HasColumnName("maTaiKhoan");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("soDienThoai");
            entity.Property(e => e.TenPhong)
                .HasMaxLength(200)
                .HasColumnName("tenPhong");
            entity.Property(e => e.TrangThaiBaiDang)
                .HasMaxLength(50)
                .HasColumnName("trangThaiBaiDang");
            entity.Property(e => e.TrangThaiPhong)
                .HasMaxLength(50)
                .HasColumnName("trangThaiPhong");

            entity.HasOne(d => d.MaTaiKhoanNavigation).WithMany(p => p.TblPhongs)
                .HasForeignKey(d => d.MaTaiKhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblPhong__maTaiK__5535A963");
        });

        modelBuilder.Entity<TblTaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTaiKhoan).HasName("PK__tblTaiKh__8FFF6A9DE1B7B93D");

            entity.ToTable("tblTaiKhoan");

            entity.Property(e => e.MaTaiKhoan).HasColumnName("maTaiKhoan");
            entity.Property(e => e.AnhDaiDien)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("anhDaiDien");
            entity.Property(e => e.GioiTinh)
                .HasDefaultValue(false)
                .HasColumnName("gioiTinh");
            entity.Property(e => e.HoTenNguoiDung)
                .HasMaxLength(50)
                .HasColumnName("hoTenNguoiDung");
            entity.Property(e => e.MaDmTaiKhoan).HasColumnName("maDmTaiKhoan");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("matKhau");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("soDienThoai");
            entity.Property(e => e.SoLanSai).HasColumnName("soLanSai");
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tenDangNhap");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .HasColumnName("trangThai");

            entity.HasOne(d => d.MaDmTaiKhoanNavigation).WithMany(p => p.TblTaiKhoans)
                .HasForeignKey(d => d.MaDmTaiKhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblTaiKho__maDmT__5629CD9C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
