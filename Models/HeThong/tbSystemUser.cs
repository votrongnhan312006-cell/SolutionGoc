using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IDC.Frontend.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using QLCongViec.Services;

#nullable disable

namespace QLCongViec.Models.HeThong;

[ApiEndpoint("api/systemuser", ApiEndpoints.CongViec)]

public partial class tbSystemUser
{
[Key]
public int IdUser { get; set; }
public string UserName { get; set; }
public string FullName { get; set; }
public string PasswordHash { get; set; }
public int? IdCanBo { get; set; }
public bool? IsLDAPAccount { get; set; }
[NotMapped]
public string Password { get; set; }
[NotMapped]
public string ConfirmPassword { get; set; }
public string token { set; get; }
}

