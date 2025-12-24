using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/kehoach", ApiEndpoints.GiaoTrinh)]
    public class tbKeHoach
    {
        public int idKeHoachBienSoan { get; set; }
        public DateOnly? ngayBatDau { get; set; }
        public DateOnly? ngayDuKienHoanThanh { get; set; }
        public string? idCacMocCongViec { get; set; }
        public string? fileDeCuongChiTiet { get; set; }
        public string? nhanXet { get; set; }
    }


}
