using System;
using System.Collections.Generic;

namespace NHNT_G08.Models;

public partial class TblDanhGiaPhong
{
    public int MaDanhGia { get; set; }

    public int MaPhong { get; set; }

    public int MaTaiKhoan { get; set; }

    public int? SoSao { get; set; }

    public virtual TblPhong MaPhongNavigation { get; set; }

    public virtual TblTaiKhoan MaTaiKhoanNavigation { get; set; }
}
