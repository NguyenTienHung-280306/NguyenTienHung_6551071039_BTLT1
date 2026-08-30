using System.Transactions;

double a, b;
Console.Write("Nhap so a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Nhap so b: ");
b = double.Parse(Console.ReadLine());
double tong = a + b;
double hieu = a - b;
double tich = a * b;
double thuong = a / b;
int chiaNguyen = (int)a / (int)b;
int chiaDu= (int)a % (int)b;
double luyThua = Math.Pow(a, b);

Console.WriteLine();
Console.WriteLine("Tong (a + b) = " + tong);
Console.WriteLine("Hieu (a - b) = " + hieu);
Console.WriteLine("Tich (a * b) = " + tich);
Console.WriteLine("Thuong (a / b) = " + thuong);
Console.WriteLine("Chia lay phan nguyen (a / b) = " + chiaNguyen);
Console.WriteLine("Chia lay phan du (a % b) = " + chiaDu);
Console.WriteLine("Luy thua (a  ^ b) = " + luyThua);
Console.WriteLine("\nMssv: 6551071039");
Console.ReadLine();
