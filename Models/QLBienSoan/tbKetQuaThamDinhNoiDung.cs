using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/ketquathamdinhnoidung", ApiEndpoints.GiaoTrinh)]
    public class tbKetQuaThamDinhNoiDung
    {
        public int idKetQua { get; set; }
        public DateOnly? ngayThamDinh { get; set; }
        public string? ketLuan { get; set; }
        public string? nhanXet { get; set; }
        public string? fileBienBanThamDinh { get; set; }
        public string? filePhieuNhanXet { get; set; }
    }
}
