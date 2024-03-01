/*Nhập vào chuỗi ký tự. Đếm số lần xuất hiện từng từ trong chuỗi đó.
 * HINT: Sử dụng Dictionary<string, int>, key=string: từ cần đếm, value=int: số lần xuất hiện
 * Có thể nâng cấp đọc từ file, sử dụng: File.ReadAllText(path)
 */
using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.Write("Nhập chuỗi cần đếm: ");
var chuoi = Console.ReadLine().Trim();

//remove dấu câu
//chuoi = chuoi.Replace(",", "");
chuoi = Regex.Replace(chuoi, "[,?:!]", "");

//tách mảng các từ
var words = chuoi.Split(' ');

var thongke = new Dictionary<string, int>();
foreach (var word in words)
{
	if(thongke.ContainsKey(word))
	{
		thongke[word] += 1;
	}
	else
	{
		thongke[word] = 1;
	}
}

foreach(var word in thongke.Keys)
{
	Console.WriteLine($"{word}: {thongke[word]} lần");
}