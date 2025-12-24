using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/hoidong", ApiEndpoints.GiaoTrinh)]

    public partial class tbHoiDong
    {
        public int IdHoiDong { get; set; }

        public int? IdDeTai { get; set; }

        public int? IdCanBo { get; set; }

        public string? VaiTro { get; set; }

        public string? GhiChu { get; set; }

        public int LoaiHoiDong { get; set; }
    }
}