using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace QLCongViec.Models.HeThong
{
[ApiEndpoint("api/nguoidunghethong", ApiEndpoints.CongViec)]

public partial class vNguoiDungHeThong
{
[Key]
public int IdUser { get; set; }
public string UserName { get; set; }
public string FullName { get; set; }
}
}

