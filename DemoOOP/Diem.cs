using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
	public class Diem
	{
		//Automatic Property
		public int Hoanh { get; set; }
		public int Tung { get; set; }
		public Diem(int xx=0, int yy=0)
		{
			Hoanh = xx; Tung = yy;
		}

		public void Xuat()
		{
			Console.WriteLine($"({Hoanh}, {Tung})");
		}
		public override string ToString()
		{
			return $"({Hoanh}, {Tung})";
		}
	}
}
