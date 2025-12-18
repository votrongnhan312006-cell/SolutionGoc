using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCongViec.Models
{
[ApiEndpoint("api/giaymoivietbai", ApiEndpoints.CongViec)]
public class tbGiayMoiVietBai
{
[Key]
public int IdGiayMoiVietBai { get; set; }
public int? IdCongViec { get; set; }
public string? SoKyHieu { get; set; }
public DateTime? Ngay { get; set; }
public string? ChuDeBaiViet { get; set; }
public string? TenHoiThao_ToaDam { get; set; }
public int? Cap { get; set; }
public string? NguoiMoi { get; set; }
public string? ChucVu { get; set; }
}
}
