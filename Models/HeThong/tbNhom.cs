using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using IDC.Frontend.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using QLCongViec.Services;

#nullable disable

namespace QLCongViec.Models.HeThong
{
[ApiEndpoint("api/nhom", ApiEndpoints.CongViec)]
public partial class tbNhom
{

[Key]
public int IdNhom { get; set; }
[StringLength(500)]
public string MoTa { get; set; }
[StringLength(500)]
public string TenNhom { get; set; }
public string DataKey { get; set; }
public int? LinkedDataKey { get; set; }
public int? IdParent { get; set; }
public int? CoDataKey { get; set; }
}
}
