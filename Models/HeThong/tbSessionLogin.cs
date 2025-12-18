using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using IDC.Frontend.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using QLCongViec.Services;

#nullable disable

namespace QLCongViec.Models.HeThong;

[ApiEndpoint("api/systelogin", ApiEndpoints.CongViec)]

public partial class tbSessionLogin
{

[Key]
public string Token { get; set; }
public string Value { get; set; }
public DateTime CreatedAt { get; set; }
public DateTime ExpireAt { get; set; }
}
