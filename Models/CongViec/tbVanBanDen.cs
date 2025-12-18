using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCongViec.Models
{
[ApiEndpoint("api/vanbanden", ApiEndpoints.CongViec)]

public class tbVanBanDen
{
[Key]
public int IdVanBanDen { get; set; }
public string? SoKiHieuVanBan { get; set; }
public int? IdLoaiVanBan { get; set; }
public DateTime? NgayBanHanh { get; set; }
public int? IdCoQuanBanHanh { get; set; }
public string? TrichYeuNoiDung { get; set; }
public int? SoTrang { get; set; }
public string? SoDen { get; set; }
public string? NoiNhan { get; set; }
public int? DoMat { get; set; }
public int? DoKhan { get; set; }
//Sổ văn bản
public int? IdSoVanBan { get; set; }
//Ngày tiếp nhận
public DateTime? NgayDen { get; set; }
public string? HoTenNguoiKy { get; set; }
public string? IdFileDinhKem { get; set; }
public string? NguoiNhap { get; set; }
public DateTime? ThoiHanGiaiQuyet { get; set; }
public int? IdPhuongThucNhan { get; set; }
}
}
