using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/gttl", ApiEndpoints.GiaoTrinh)]
    public partial class tbGTTL
    {
        public int IdGTTL { get; set; }

        public string? TenGTTL { get; set; } = null!;

        public int IdNhomLoaiGTTL { get; set; }

        public int? IdNhomGTTL { get; set; }

        public int? IdBacHocSuDungGTTL { get; set; }

        public int? IdMonHoc { get; set; }

        public int? SoTinChi { get; set; }

        public int? IdDonVi { get; set; }

        public string? SqdGiaoNV { get; set; }

        public DateOnly? NgayGiaoNV { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        public DateOnly? HanHoanThanh { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        public string? SqdThamDinh { get; set; }

        public DateOnly? NgayThamDinh { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        public string? SqdBanHanh { get; set; }

        public DateOnly? NgayBanHanh { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        public int? SoTrangA4 { get; set; }

        public int? SoBanIn { get; set; }

        public string? GhiChu { get; set; }

        public int? IdTinhTrang { get; set; } = 0;
        public string? FileBanThao { get; set; }
        public string? FileDeCuongChiTiet { get; set; }

        public string? MaTaiLieu { get; set; }

        public string? ChuBien { get; set; }

        public string? ThanhVien { get; set; }

        public int? IdTienDo { get; set; }

        public int? IdketQuaThamDinh { get; set; }

        public int? IdDuToan { get; set; } = 0;

        public int? IdKeHoach { get; set; }

        public int? IdThongTinBanHanh { get; set; }

        public string? FileDangKy { get; set; }

        public string? FileDaTailen { get; set; }
    }
}