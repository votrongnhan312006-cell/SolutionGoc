namespace QLCongViec.Models
{
    public class DeXuatModel
    {
        public string SoQuyetDinh { get; set; } = "123/QĐ-ĐHBK";
        public string TenTaiLieu { get; set; } = "";
        public string LoaiHinh { get; set; } = "";
        public string ChuBien { get; set; } = "";
        public DateTime NgayGui { get; set; }
        public string MonHoc { get; set; } = "IT301 - Lập trình Web";
        public string TrinhDo { get; set; } = "Đại học";
        public string DonVi { get; set; } = "Khoa Công nghệ Thông tin";
        public TrangThaiDeXuat TrangThai { get; set; }
        public string? GhiChu { get; set; }
    }

    public enum TrangThaiDeXuat
    {
        DaPheDuyet,
        ChoXetDuyet,
        KhongPheDuyet
    }
}
