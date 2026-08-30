int n;

do
{
    Console.Write("Nhap vao so nguyen duong n: ");

    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.WriteLine("Loi: n phai la so nguyen duong (n > 0). Vui long nhap lai!");
        n = 0; 
    }
} while (n <= 0);

long tongToanBo = 0;
long tongChan = 0;
long tongLe = 0;
long giaiThua = 1;

for (int i = 1; i <= n; i++)
{
    tongToanBo += i;

    if (i % 2 == 0)
    {
        tongChan += i;
    }
    else
    {
        tongLe += i; 
    }
}

int j = 1;
while (j <= n)
{
    giaiThua *= j;
    j++;
}

Console.WriteLine("\n--- KET QUA ---");
Console.WriteLine($"Tong 1 + 2 + ... + {n} = {tongToanBo}");
Console.WriteLine($"Tong cac so chan tu 1 den {n} = {tongChan}");
Console.WriteLine($"Tong cac so le tu 1 den {n} = {tongLe}");
Console.WriteLine($"Tich 1 * 2 * ... * {n} ({n}!) = {giaiThua}");
Console.WriteLine("Mssv: 6551071039");
Console.ReadLine();