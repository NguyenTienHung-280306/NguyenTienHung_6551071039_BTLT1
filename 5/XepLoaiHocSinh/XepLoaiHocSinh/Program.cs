double diem;
Console.Write("Nhap diem trung binh: ");
diem = double.Parse(Console.ReadLine());
Console.WriteLine();

if (diem < 0 || diem > 10)
{
    Console.WriteLine("Diem khong hop le!");
}
else if (diem >= 9.0)
{
    Console.WriteLine("Xep loai: Xuat sac");
}
else if (diem >= 8.0)
{
    Console.WriteLine("Xep loai: Gioi");
}
else if (diem >= 6.5)
{
    Console.WriteLine("Xep loai: Kha");
}
else if (diem >= 5.0)
{
    Console.WriteLine("Xep loai: Trung binh");
}
else
{
    Console.WriteLine("Xep loai: Yeu");
}
Console.WriteLine();
Console.WriteLine("MSSV: 6551071039");