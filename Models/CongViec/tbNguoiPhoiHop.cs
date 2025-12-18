using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace QLCongViec.Models
{
[ApiEndpoint("api/nguoiphoihop", ApiEndpoints.CongViec)]
public partial class tbNguoiPhoiHop
{
[Key]
public int IdNguoiPhoiHop { get; set; }
public string? HoTen { get; set; }
public string? NoiDungPhoiHop { get; set; }
public string? NguoiGiao { get; set; }
public DateTime? NgayGiao { get; set; }
public string NguoiPhoiHop { get; set; }
public DateTime? NgayHoanThanh { get; set; }
public int? IdNguoi { get; set; }
[ForeignKey(nameof(CongViec))]
public int IdCongViec { get; set; }
public virtual tbCongViec CongViec { get; set; }
}
}
