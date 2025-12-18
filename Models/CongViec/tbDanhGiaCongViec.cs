using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCongViec.Models
{
[ApiEndpoint("api/danhgiacongviec", ApiEndpoints.CongViec)]

public class tbDanhGiaCongViec
{
[Key]
public int IdDanhGiaCongViec { get; set; }
public int? IdCongViec { get; set; }
public string? TieuChi { get; set; }
public int? Diem { get; set; }
public string? GiaTriTieuChi { get; set; }
public string? DanhGia { get; set; }

}
}
