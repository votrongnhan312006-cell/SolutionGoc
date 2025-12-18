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
[ApiEndpoint("api/loaicongviec", ApiEndpoints.CongViec)]
public partial class tbLoaiCongViec
{

[Key]
public int IdLoaiCongViec { get; set; }
public string TenLoaiCongViec { get; set; }
}
}
