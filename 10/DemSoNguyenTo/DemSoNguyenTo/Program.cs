int n = 0;
bool nhapHopLe = false;

while (!nhapHopLe)
{
    Console.Write("Nhap vao so nguyen duong n (n <= 1000): ");
    try
    {
        n = int.Parse(Console.ReadLine());

        if (n <= 0 || n > 1000)
        {
            Console.WriteLine("Loi: n phai la so nguyen duong va <= 1000. Vui long nhap lai!\n");
        }
        else
        {
            nhapHopLe = true;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Loi FormatException: Du lieu nhap vao khong phai la so nguyen. Vui long nhap lai!\n");
    }
}

int demSoNguyenTo = 0;
Console.WriteLine($"\n--- Danh sach cac so nguyen to tu 2 den {n} ---");

for (int i = 2; i <= n; i++)
{
    bool laSoNguyenTo = true;

    for (int j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            laSoNguyenTo = false;
            break; 
        }
    }

    if (laSoNguyenTo)
    {
        Console.Write(i + " ");
        demSoNguyenTo++;
    }
}

Console.WriteLine($"\n\n=> Tong so luong so nguyen to tim duoc: {demSoNguyenTo}");
Console.WriteLine("\nMssv: 6551071039");
Console.ReadLine();