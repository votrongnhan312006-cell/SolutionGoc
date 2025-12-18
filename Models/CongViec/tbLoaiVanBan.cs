using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using IDC.Frontend.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using QLCongViec.Services;

#nullable disable

namespace QLCongViec.Models
{
[ApiEndpoint("api/loaivanban", ApiEndpoints.CongViec)]
public partial class tbLoaiVanBan
{

[Key]
public int IdLoaiVanBan { get; set; }
public string? TenVietTat { get; set; }
public string? TenDayDu { get; set; }
public string? GhiChu { get; set; }
}
}
