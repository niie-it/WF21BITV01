/* Nhập điểm Toán, Lý, Hóa (số thực trong khoảng [0,10]
 * Tính điểm trung bình DTB = (toan*2 + Ly + Hoa) /4 lấy  1 số lẻ (Math.Round)
 * Xếp loại dựa theo DTB
*/
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
double Toan, Ly, Hoa;

void NhapDiem(string tenMon, out double monHoc)
{
	while (true)
	{
		Console.Write($"Nhập điểm {tenMon}: ");
		if (double.TryParse(Console.ReadLine(), out monHoc) && monHoc >= 0 && monHoc <= 10)
		{
			Console.WriteLine($"{tenMon}: {monHoc}");
			break;
		}
		Console.WriteLine("Sai rồi, nhập lại....");
	}

}
NhapDiem("Toán", out Toan);
NhapDiem("Lý", out Ly);
NhapDiem("Hóa", out Hoa);

double DTB = Math.Round((Toan * 2 + Ly + Hoa) / 4, 1);
string XepLoai = string.Empty;
if (DTB >= 9) { XepLoai = "Xuất sắc"; }
else if (DTB >= 8) { XepLoai = "Giỏi"; }
else if (DTB >= 6.5) { XepLoai = "Khá"; }
else if (DTB >= 5) { XepLoai = "Trung Bình"; }
else { XepLoai = "Yếu"; }

Console.WriteLine($"Điểm TB: {DTB},  Loại: {XepLoai}");