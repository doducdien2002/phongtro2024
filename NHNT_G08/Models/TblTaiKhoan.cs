using System;
using System.Collections.Generic;

namespace NHNT_G08.Models;

public partial class TblTaiKhoan
{
    public int MaTaiKhoan { get; set; }

    public string TenDangNhap { get; set; }

    public string SoDienThoai { get; set; }

    public string HoTenNguoiDung { get; set; }

    public string MatKhau { get; set; }

    public int MaDmTaiKhoan { get; set; }

    public string AnhDaiDien { get; set; }

    public string TrangThai { get; set; }

    public bool? GioiTinh { get; set; }

    public int? SoLanSai { get; set; }

    public virtual TblDmTaiKhoan MaDmTaiKhoanNavigation { get; set; }

    public virtual ICollection<TblDanhGiaPhong> TblDanhGiaPhongs { get; set; } = new List<TblDanhGiaPhong>();

    public virtual ICollection<TblPhong> TblPhongs { get; set; } = new List<TblPhong>();
}
