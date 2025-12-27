using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/cacmoccongviec", ApiEndpoints.GiaoTrinh)]
    public class tbCacMocCongViec
    {
        public int idMocCongViec { get; set; }
        public int? idKeHoach{ get; set; }
        public string? tenMocCongViec { get; set; }
        public DateOnly? ngayDuKien { get; set; }

    }
}

