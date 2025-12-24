using System;
using System.Collections.Generic;

namespace api.Models.QLBienSoan
{
    [ApiEndpoint("api/gttl", ApiEndpoints.GiaoTrinh)]
    public partial class tbGTTL
    {
        public int idGTTL { get; set; }

        public string? maTaiLieu { get; set; }

        public string tenGTTL { get; set; } = null!;

        public int idNhomLoaiGTTL { get; set; }

        public int? idNhomGTTL { get; set; }

        public int? idBacHocSuDungGTTL { get; set; }

        public short? idMonHoc { get; set; }

        public string? chuBien { get; set; }

        public string? thanhVien { get; set; }

        public int? soTinChi { get; set; }

        //chưa có api lưu data đơn vị
        public int? idDonVi { get; set; }

        public int? idTienDo { get; set; }

        public int? idketQuaThamDinh { get; set; }

        public int? idDuToan { get; set; }

        public int? idKeHoach { get; set; }

        public int? idThongTinBanHanh { get; set; }

        public string? sQDGiaoNV { get; set; }

        public DateOnly? ngayGuiDeXuat { get; set; }

        public DateOnly? ngayGiaoNV { get; set; }

        public DateOnly? hanHoanThanh { get; set; }

        public string? sqdThamDinh { get; set; }

        public DateOnly? ngayThamDinh { get; set; }

        public string? sqdBanHanh { get; set; }

        public DateOnly? ngayBanHanh { get; set; }

        public int? soTrangA4 { get; set; }

        public int? soBanIn { get; set; }

        public string? ghiChu { get; set; }

        public byte idTinhTrang { get; set; }

        public string? fileDangKy { get; set; }

        public string? fileBanThao { get; set; }

        public string? fileDeCuongChiTiet { get; set; }
        
        public string? fileDaTailen { get; set; }
    }
}