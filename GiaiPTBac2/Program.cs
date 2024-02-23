using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Giải PT bậc 2");
// Nhập hệ số A, B, C
double A, B, C;
Console.Write("Nhập hệ số A: ");
A = double.Parse(Console.ReadLine());
Console.Write("Nhập hệ số B: ");
B = double.Parse(Console.ReadLine());
Console.Write("Nhập hệ số C: ");
C = double.Parse(Console.ReadLine());
// Tính Delta
double Delta = Math.Pow(B, 2) - 4 * A * C;
// if ... else
if (Delta < 0)
{
	Console.WriteLine("PT vô nghiệm");
}
else if (Delta == 0)
{
	Console.WriteLine($"PT có nghiệm kép x={-B / (2 * A)}");
}
else
{
	Console.WriteLine($"PT có 2 nghiệm phân biệt x1={(-B-Math.Sqrt(Delta)) / (2 * A)}, x2={(-B + Math.Sqrt(Delta)) / (2 * A)}");
}