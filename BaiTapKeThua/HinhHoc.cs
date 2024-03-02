using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapKeThua
{
	public class HinhHoc
	{
		//Automatic property
		public double DienTich { get; set; }
		public double ChuVi { get; set; }
		public virtual void TinhDienTiChChuVi() { }
	}

	public class HinhTron : HinhHoc
	{
		//Feild + Property ==> Automatic Property
		//Field
		private double _BanKinh;
		//Property
		public double BanKinh
		{
			get { return _BanKinh; }
			set
			{
				if (value < 0) throw new Exception("Ban kinh am");
				_BanKinh = value;
			}
		}

		public override void TinhDienTiChChuVi()
		{
			DienTich = BanKinh * BanKinh * Math.PI;
			ChuVi = 2 * BanKinh * Math.PI;
		}

		public override string ToString()
		{
			return $"Tron R={BanKinh}, S={DienTich}, P={ChuVi}";
		}
	}

	public class HinhChuNhat : HinhHoc
	{
		//SV tự check Dai, Rong >= 0
		public double Dai { get; set; }
		public double Rong { get; set; }

		public override void TinhDienTiChChuVi()
		{
			DienTich = Dai * Rong;
			ChuVi = (Dai + Rong) * 2;
		}

		public override string ToString()
		{
			return $"HCN D={Dai}, R={Rong}, S={DienTich}, P={ChuVi}";
		}
	}
}
