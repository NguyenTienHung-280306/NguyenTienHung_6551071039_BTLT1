string hoTen;
int tuoi;
double chieuCao;
float canNang;
bool daTotNghiep;

Console.Write("Nhap ho ten: ");
hoTen = Console.ReadLine();
Console.Write("Nhap tuoi: ");
tuoi = int.Parse(Console.ReadLine());
Console.Write("Chieu cao(m): ");
chieuCao = double.Parse(Console.ReadLine());
Console.Write("Can nang(Kg): ");
canNang = float.Parse(Console.ReadLine());
Console.Write("Da tot nghiep (True/False): ");
daTotNghiep = bool.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Ho ten: " + hoTen);
Console.WriteLine("Tuoi " + tuoi);
Console.WriteLine("Chieu cao: " + chieuCao + " m");
Console.WriteLine("Can nang: " + canNang + " kg");
Console.WriteLine("Da tot nghiep: " + daTotNghiep);

Console.WriteLine("\nMssv: 6551071039");
Console.ReadLine();