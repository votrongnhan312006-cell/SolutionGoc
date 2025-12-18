using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IDC.Frontend.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using QLCongViec.Services;

#nullable disable

namespace QLCongViec.Models.HeThong;

[ApiEndpoint("api/chucnang_nguoidung", ApiEndpoints.CongViec)]
public partial class tbChucNang_NguoiDung
{
[Key]
public int IdChucNang_NguoiDung { get; set; }
public int? IdNguoiDung { get; set; }
public int? IdChucNang { get; set; }
public bool? C { get; set; }
public bool? R { get; set; }
public bool? U { get; set; }
public bool? D { get; set; }
}
