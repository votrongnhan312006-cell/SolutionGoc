using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/bachocgttl", ApiEndpoints.GiaoTrinh)]
public partial class tbBacHocGTTL
{
    public int IdBacHocGTTL { get; set; }

    public int IdGTTL { get; set; }

    public int IdBacHoc { get; set; }

    public string? GhiChu { get; set; }
}
}