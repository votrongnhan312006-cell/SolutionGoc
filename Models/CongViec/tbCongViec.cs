using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace QLCongViec.Models
{
[ApiEndpoint("api/congviec", ApiEndpoints.CongViec)]
public partial class tbCongViec
{
[Key]
public int IdCongViec { get; set; }
public int? IdLoaiCongViec { get; set; }
public string? CanCuGiaoViec { get; set; }
public string? TenCongViec { get; set; }
public DateTime? NgayTao { get; set; }
public string? NguoiTao { get; set; }
public DateTime? NgayGiao { get; set; }
public string? NguoiGiao { get; set; }
public string? NguoiChiDao { get; set; }
public string? NguoiChuTri { get; set; }
public bool? HasNguoiPhoiHop { get; set; }
// public string? NguoiPhoiHop { get; set; }
// [NotMapped]
// public List<string>? NguoiPhoiHopList
// {
// get => string.IsNullOrEmpty(NguoiPhoiHop) ? new List<string>() : NguoiPhoiHop.Split(',').ToList();
// set => NguoiPhoiHop = string.Join(",", value);
// }
public DateTime? NgayHT { get; set; }
public DateTime? NgayBaoCao { get; set; }
public string? NoiDungBaoCao { get; set; }
public string? IdFileBaoCao { get; set;}
public string TrangThai { get; set; }
public string IdTaiLieu { get; set; }
public string GhiChu { get; set; }
public string DataKey { get; set; }
public int? IdCongViecCha { get; set; }
public string? KetQuaDanhGia { get; set; }
public int? IdDonViChuTri { get; set; }
public string? IdDonViPhoiHop { get; set; }

}
}
