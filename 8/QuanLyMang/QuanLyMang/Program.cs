int[] arr = new int[10];

Console.WriteLine("--- NHAP DU LIEU CHO MANG ---");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Nhap phan tu thu arr[{i}]: ");

    while (!int.TryParse(Console.ReadLine(), out arr[i]))
    {
        Console.Write($"Loi kieu du lieu! Vui long nhap lai arr[{i}]: ");
    }
}

Console.WriteLine("\n--- TOAN BO MANG VUA NHAP ---");
foreach (int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();

int tong = 0;
foreach (int item in arr)
{
    tong += item;
}
double trungBinh = (double)tong / arr.Length;

Console.WriteLine($"\nTong cac phan tu: {tong}");
Console.WriteLine($"Trung binh cac phan tu: {trungBinh}");

int max = arr[0];
int min = arr[0];
int viTriMax = 0;
int viTriMin = 0;

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        viTriMax = i;
    }

    if (arr[i] < min)
    {
        min = arr[i];
        viTriMin = i;
    }
}
Console.WriteLine($"Gia tri lon nhat la: {max}, nam o vi tri index: {viTriMax}");
Console.WriteLine($"Gia tri nho nhat la: {min}, nam o vi tri index: {viTriMin}");
int soChan = 0;
int soLe = 0;
foreach (int item in arr)
{
    if (item % 2 == 0)
        soChan++;
    else
        soLe++;
}
Console.WriteLine($"\nSo luong phan tu chan: {soChan}");
Console.WriteLine($"So luong phan tu le: {soLe}");

for (int i = 0; i < arr.Length / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}
Console.WriteLine("\n--- MANG SAU KHI DAO NGUOC THU TU ---");
foreach (int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine("\nMssv: 6551071039");
Console.ReadLine();