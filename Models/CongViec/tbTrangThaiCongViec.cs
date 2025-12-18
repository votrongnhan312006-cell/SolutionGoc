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
[ApiEndpoint("api/trangthaicongviec", ApiEndpoints.CongViec)]
public partial class tbTrangThaiCongViec
{

[Key]
public int IdTrangThaiCongViec { get; set; }
public string TenTrangThaiCongViec { get; set; }
}
}
