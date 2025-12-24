using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/dutoan", ApiEndpoints.GiaoTrinh)]
    public class tbDuToan
    {
        public int idDuToan { get; set; }
        public long? thuLaoViet { get; set; }
        public long? chiPhiHoiThao { get; set; }
        public long? chiPhiThamDinh { get; set; }
        public long? chiPhiInAn { get; set; }
        public string? nhanXet { get; set; }
    }
}
