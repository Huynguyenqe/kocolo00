namespace QLTV.Models
{
    public class TacGia
    {
        public int Id { get; set; }

        public string HoTen { get; set; } = string.Empty;

        public int NamSinh { get; set; }

        // Một tác giả có nhiều sách
        public ICollection<Sach> DanhSachSach { get; set; }
            = new List<Sach>();
    }
}
