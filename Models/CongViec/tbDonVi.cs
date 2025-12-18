using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace QLCongViec.Models;
[ApiEndpoint("api/donvi", ApiEndpoints.CongViec)]
public partial class tbDonVi
{
    [Key]
    public int IdDonVi { get; set; }
    public string DonVi { get; set; }
}

