using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace QLCongViec.Models.SangKienCaiTien
{
    [ApiEndpoint("api/sangkiencaitien", ApiEndpoints.CanBo)]
    public class tbSangKienCaiTien
    {
        public int idSangKienCaiTien { get; set; }
        public int? idCanBo { get; set; }
        public string? tenSangKienCaiTien { get; set; }
        public int? idCap { get; set; }
        public string? namHoc { get; set; }
        public string? moTa { get; set; }
        public string? ketQua { get; set; }
        public string? tenTacGia { get; set; }
        public string? tenDongTacGia { get; set; }
        public string? capBacTacGia { get; set; }
        public string? capBacDongTacGia { get; set; }
        public DateOnly? ngayThucHien { get; set; }
        public string? diaDiemThucHien { get; set; }
        public string? phamViThucHien { get; set; }
        public int? idTrangThai { get; set; }
        public string? fileDangKy { get; set; }
        public string? fileKetQua { get; set; }
        public string? filePhieuDanhGia { get; set; }
        public string? filePhieuChamDiem { get; set; }
        public string? fileBienBan { get; set; }
        public string? fileQuyetDinh { get; set; }
    }
}
