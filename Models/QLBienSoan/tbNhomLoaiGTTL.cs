using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/nhomloaigttl", ApiEndpoints.GiaoTrinh)]

    public partial class tbNhomLoaiGTTL
    {
        public int IdNhomLoaiGTTL { get; set; }

        public int? IdNhomGTTL { get; set; }

        public string? LoaiGTTL { get; set; }
    }
}