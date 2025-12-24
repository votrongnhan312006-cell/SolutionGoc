using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/nhomgttl", ApiEndpoints.GiaoTrinh)]

    public partial class tbNhomGTTL
    {
        public int IdNhomGTTL { get; set; }

        public string NhomGTTL { get; set; } = null!;
    }
}