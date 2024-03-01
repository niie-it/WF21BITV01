/*Thông tin một mặt hàng bao gồm: Mã mặt hàng (MaMH - số nguyên), tên mặt hàng (TenMH - chuỗi), số lượng (SoLuong - số nguyên), đơn giá (DonGia - số thực).
	Khai báo lớp mặt hàng nói trên, bao gồm cả hàm tạo và hàm tính thành tiền.
	Viết hàm thêm một mặt hàng vào trong danh sách.
	Viết hàm tìm một mặt hàng dựa vào mã mặt hàng, trả về kiểu bool (có hay không).
	Viết hàm xuất danh sách các mặt hàng.
	viết hàm xóa mặt hàng dựa vào mã mặt hàng.
	Viết hàm main thực hiện các chức năng sau:
o	nhập vào danh sách các mặt hàng. Nhập xong mỗi mặt hàng hỏi người dùng có tiếp tục nhập hay không? 
o	xuất danh sách các mặt hàng.
o	nhập vào mã mặt hàng, tiến hành tìm kiếm mặt hàng nói trên. Nếu tìm thấy, xóa mặt hàng và xuất danh sách các mặt hàng (sau khi xóa).
*/
public class HangHoa
{
	public string MaHh { get; set; }
	public string TenHh { get; set; }
	public int SoLuong { get; set; }
	public double DonGia { get; set; }
	public double ThanhTien => DonGia * SoLuong;
}
class Program
{
	static void Main(string[] args)
	{
		List<HangHoa> dsHangHoa = new List<HangHoa>();
	}
}
