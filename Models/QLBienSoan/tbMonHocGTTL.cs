using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/monhocgttl", ApiEndpoints.GiaoTrinh)]

    public partial class tbMonHocGTTL
    {
        public int IdMonHocGTTL { get; set; }

        public int IdGTTL { get; set; }

        public int IdMonHoc { get; set; }

        public string? GhiChu { get; set; }
    }
}