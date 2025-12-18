using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace QLCongViec.Models.HeThong
{
[ApiEndpoint("api/nguoidung_nhom", ApiEndpoints.CongViec)]
public partial class tbNguoiDung_Nhom
{

[Key]
public int IdNguoiDung_Nhom { get; set; }
public int IdNhom { get; set; }
public int IdNguoiDung { get; set; }
}
}
