using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/kehoach", ApiEndpoints.GiaoTrinh)]
    public class tbKeHoach
    {
        public int IdKeHoachBienSoan { get; set; }
        public DateOnly? NgayBatDau { get; set; }
        public DateOnly? NgayDuKienHoanThanh { get; set; }
        public int? IdCacMocCongViec { get; set; }
        public string? FileDeCuongChiTiet { get; set; }
        public string? NhanXet { get; set; }
    }


}
