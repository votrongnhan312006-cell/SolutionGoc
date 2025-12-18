using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCongViec.Models
{
[ApiEndpoint("api/congviechistory", ApiEndpoints.CongViec)]

public class tbCongViecHistory
{
[Key]
public int IdCongViecHistory { get; set; }
public int? IdCongViec { get; set; }
public DateTime? ThoiGian { get; set; }
public string? NguoiGui { get; set; }
public string? NguoiNhan { get; set; }
public string? NoiDung { get; set; }

}
}
