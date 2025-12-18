using IDC.Frontend.Services.Abstraction;

namespace QLCongViec.Models;

[ApiEndpoint("api/file", ApiEndpoints.CongViec)]
public partial class tbFile : IFileModel
{

    [Key]
    [StringLength(36)]
    public string uid { get; set; } = null!;
    [Required]
    public string filename { get; set; }

    [StringLength(10)]
    public string? bucket { get; set; }

    [StringLength(32)]
    public string hash { get; set; }
    public int? pageCount { get; set; }
    [Required]
    public string loaiFile { get; set; }
    public string? fileContent { get; set; }
    // public string? fileSize { get; set; }
}
