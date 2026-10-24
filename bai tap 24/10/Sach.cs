namespace QLTV.Models
{
    public class Sach
    {
        public int Id { get; set; }

        public string TenSach { get; set; } = string.Empty;

        public int NamXuatBan { get; set; }

        // Khóa ngoại
        public int TacGiaId { get; set; }

        // Thuộc tính điều hướng
        public TacGia TacGia { get; set; } = null!;
    }
}
