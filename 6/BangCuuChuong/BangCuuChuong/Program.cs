int n;

do
{
    Console.Write("Nhap vao mot so nguyen n (1 <= n <= 9): ");

    if (!int.TryParse(Console.ReadLine(), out n))
    {
        n = 0;
    }

    if (n < 1 || n > 9)
    {
        Console.WriteLine("Loi: n phai nam trong khoang 1-9. Vui long nhap lai!");
    }

} while (n < 1 || n > 9);

Console.WriteLine($"\nBang cuu chuong cua {n}:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}
Console.WriteLine("\nMssv: 6551071039");
Console.ReadLine();