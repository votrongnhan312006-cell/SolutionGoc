namespace QLCongViec.Models.QLBienSoan
{
    [ApiEndpoint("api/tinhtrangdetai", ApiEndpoints.DanhMuc)]
    public class tbTrangThai
    {
        public int idTinhTrangDeTai { get; set; }
        public string? tenTinhTrangDeTai { get; set; }
        public int? stt { get; set; }
        public int? idDonVi { get; set; }
        public bool tonTai { get; set; }
    }
}
