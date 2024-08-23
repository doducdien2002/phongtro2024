using System;
using System.Collections.Generic;

namespace NHNT_G08.Models;

public partial class TblPhong
{
    public int MaPhong { get; set; }

    public int MaTaiKhoan { get; set; }

    public string TenPhong { get; set; }

    public string DiaChi { get; set; }

    public int? GiaPhong { get; set; }

    public int? GiaDien { get; set; }

    public int? GiaNuoc { get; set; }

    public string ChiTietPhong { get; set; }

    public string TrangThaiBaiDang { get; set; }

    public string TrangThaiPhong { get; set; }

    public double? DienTich { get; set; }

    public string SoDienThoai { get; set; }

    public virtual TblTaiKhoan MaTaiKhoanNavigation { get; set; }

    public virtual ICollection<TblDanhGiaPhong> TblDanhGiaPhongs { get; set; } = new List<TblDanhGiaPhong>();

    public virtual ICollection<TblHinhAnh> TblHinhAnhs { get; set; } = new List<TblHinhAnh>();
}
