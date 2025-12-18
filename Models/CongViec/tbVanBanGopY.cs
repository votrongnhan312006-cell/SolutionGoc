using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCongViec.Models
{
[ApiEndpoint("api/vanbangopy", ApiEndpoints.CongViec)]

public class tbVanBanGopY
{
[Key]
public int IdVanBanGopY { get; set; } 
public int? IdCongViec { get; set; }
public DateTime? NgayYeuCau { get; set; }
public string? TenVanBanGopY { get; set; }
public string? LoaiVanBan { get; set; }
public string? SoVBDeNghi { get; set; }
public DateTime? NgayVBDeNghi { get; set; }
public string? DonViDeNghi { get; set; }
public int? SoTrangVanBanGopY { get; set; }

}
}
