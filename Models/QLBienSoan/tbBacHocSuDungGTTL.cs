using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/bachocsudunggttl", ApiEndpoints.GiaoTrinh)]
    public partial class tbBacHocSuDungGTTL
    {
        public int IdBacHocSuDungGTTL { get; set; }

        public string BacHocSuDungGTTL { get; set; } = null!;

        public string? GhiChu { get; set; }
    }
}