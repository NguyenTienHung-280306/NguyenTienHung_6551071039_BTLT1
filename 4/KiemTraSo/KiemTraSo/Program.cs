int a;
Console.Write("Nhap so nguyen:: ");
a=int.Parse(Console.ReadLine());
Console.WriteLine();
if (a < 0)
{
    Console.WriteLine(a + "la so am");
}
else if(a > 0)
{
    Console.WriteLine(a + "la so duong");
}
else
{
    Console.WriteLine(a + "la so bang 0");
}
if (a % 2 == 0) {
    Console.WriteLine(a + " la so chan");    
}
else
{
    Console.WriteLine(a + " la so le");
}
if (a % 3 == 0)
{
    Console.WriteLine(a + " chia het cho 3");
}
else
{
    Console.WriteLine(a + " khong chia het cho 3");
}
if (a % 2 == 0 && a % 3 == 0)
{
    Console.WriteLine("So " + a + " chia het cho ca 2 va 3");
}
else
{
    Console.WriteLine("So " + a + " khong chia het cho ca 2 va 3");
}
Console.WriteLine();
Console.WriteLine("MSSV: 6551071039");

