using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/tiendo", ApiEndpoints.GiaoTrinh)]
    public class tbTienDo
    {
        public int idTienDo { get; set; }
        public string? tenTienDo { get; set; }
        public DateOnly? ngayDuKien { get; set; }
        public DateOnly? ngayHoanThanhThucTe { get; set; }
        public int? idTrangThai { get; set; }
    }
}
