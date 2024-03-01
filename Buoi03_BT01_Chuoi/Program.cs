using System.Text;

Console.OutputEncoding = Encoding.UTF8;

/*Viết hàm tạo mã ngẫu nhiên có N kí tự
Input: N - số kí tự
Output: Chuỗi ngẫu nhiên có N kí tự
*/
string TaoChuoiNgauNhien(int N = 5)
{
	string pattern = @"qazwsxedcrfvtgbyhnujmikolpQAZWSXEDCRFVTGBYHNUJMIKOLP!~@#$%^&*[]{}?<>";
	var sb = new StringBuilder();
	var rd = new Random();
	for (int i = 0; i < N; i++)
	{
		sb.Append(pattern[rd.Next(0, pattern.Length)]);
	}
	return sb.ToString();
}

//Demo sinh 5 chuỗi ngẫu nhiên
for(int i = 0; i < 5; i++)
{
	Console.WriteLine(TaoChuoiNgauNhien(7));
}