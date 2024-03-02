// Viết trong hàm Main (Program.cs)
using DemoOOP;

var A = new Diem();
var B = new Diem(7);
var C = new Diem(7, 9);
A.Xuat(); B.Xuat(); C.Xuat();
Console.WriteLine(A);
Console.WriteLine(B);

var A3D = new Diem3D(1, 3, 7);
Console.WriteLine(A3D);