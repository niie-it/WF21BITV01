using System;

static double Tinh(double x, double y)
{
	double ketQua = 0;
	try
	{
		if (2 * x - y == 0) throw new DevideByZeroException("Lỗi chia 0");
		ketQua = (3 * x + 2 * y) / (2 * x - y);
		if (ketQua < 0) throw new NotNegativeException("Lỗi lấy căn số âm");
	}
	catch (DevideByZeroException ex)
	{
		Console.WriteLine(ex.Message);
	}
	catch (NotNegativeException ex)
	{
		Console.WriteLine(ex.Message);
	}
	return ketQua;
}


Console.WriteLine(Tinh(1, 2));
Console.WriteLine("END");