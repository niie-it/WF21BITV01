using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
	public class Diem3D : Diem
	{
		public int Cao { get; set; }
		public Diem3D(int xx = 0, int yy = 0, int zz = 0) : base(xx, yy)
		{
			Cao = zz;
		}
		public override string ToString()
		{
			return $"({Hoanh}, {Tung}, {Cao})";
		}
	}
}
