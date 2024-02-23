using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.UTF8;
			Console.WriteLine("HELLO NIIE - Chào bạn");
			Console.Write("Tên bạn là: ");
			string TenBan = Console.ReadLine();
			Console.WriteLine($"Chào bạn {TenBan}");

			Console.Write("Year of birth: ");
			int YOB = int.Parse(Console.ReadLine());
			int yearOld = DateTime.Now.Year - YOB;
			Console.WriteLine($"Bạn sinh năm {YOB}, {yearOld} tuổi");

			Console.ReadLine();
		}
	}
}
