using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IDC.Frontend.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using QLCongViec.Services;

#nullable disable

namespace QLCongViec.Models.HeThong;

[ApiEndpoint("api/chucnang_nhom", ApiEndpoints.CongViec)]
public partial class tbChucNang_Nhom
{
[Key]
public int IdChucNang_Nhom { get; set; }
public int? IdNhom { get; set; }
public int? IdChucNang { get; set; }
public bool? C { get; set; }
public bool? R { get; set; }
public bool? U { get; set; }
public bool? D { get; set; }

[ForeignKey(nameof(IdChucNang))]
[InverseProperty(nameof(tbChucNang.tbChucNang_Nhoms))]
public virtual tbChucNang IdChucNangNavigation { get; set; }
}
