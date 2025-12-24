using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/thongtinbanhanh", ApiEndpoints.GiaoTrinh)]
    public class tbThongTinBanHanh
    {
        public int idThongTinBanHanh { get; set; }
        public string? soQuyetDinh { get; set; }
        public DateOnly? MyProperty { get; set; }
        public string? donViBanHanh { get; set; } = "Học viện";
        public string? nguoiKi { get; set; }
        public int? soLuongXuatBan { get; set; }
        public string donViInAn { get; set; }
        public DateOnly? ngayDuKienCoSach { get; set; }
        public string? fileQuyetDinhBanHanh { get; set; }
    }
}
