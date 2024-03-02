using BaiTapKeThua;

List<HinhHoc> dsHinh = new List<HinhHoc>();

dsHinh.Add(new HinhTron { BanKinh = 11 });
dsHinh.Add(new HinhTron { BanKinh = 13 });
dsHinh.Add(new HinhChuNhat { Dai = 22, Rong=12 });
dsHinh.Add(new HinhTron { BanKinh = 14 });
dsHinh.Add(new HinhChuNhat { Dai = 14, Rong=12 });
dsHinh.Add(new HinhChuNhat { Dai = 34, Rong=12 });

foreach(var hh in dsHinh)
{
	hh.TinhDienTiChChuVi();
	Console.WriteLine(hh);
}