using System;
using System.Collections.Generic;

namespace NHNT_G08.Models;

public partial class TblDmTaiKhoan
{
    public int MaDmTaiKhoan { get; set; }

    public string TenLoaiTk { get; set; }

    public virtual ICollection<TblTaiKhoan> TblTaiKhoans { get; set; } = new List<TblTaiKhoan>();
}
