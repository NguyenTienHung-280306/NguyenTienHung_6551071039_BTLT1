using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Nhập vào họ tên đầy đủ của bạn: ");
string hoTen = Console.ReadLine();

if (string.IsNullOrEmpty(hoTen))
{
    Console.WriteLine("Bạn chưa nhập dữ liệu!");
    Console.ReadLine();
    return;
}

Console.WriteLine("\n--- KẾT QUẢ XỬ LÝ CHUỖI ---");

Console.WriteLine($"- Độ dài chuỗi: {hoTen.Length}");

Console.WriteLine($"- Chuỗi chữ HOA: {hoTen.ToUpper()}");
Console.WriteLine($"- Chuỗi chữ thường: {hoTen.ToLower()}");

string chuoiTrim = hoTen.Trim();
Console.WriteLine($"- Chuỗi sau khi Trim: \"{chuoiTrim}\"");

bool chuaNguyen = hoTen.Contains("Nguyễn");
Console.WriteLine($"- Có chứa từ \"Nguyễn\" không: {(chuaNguyen ? "Có" : "Không")}");

string[] mangTu = chuoiTrim.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine("- Các từ trong chuỗi sau khi tách (Split):");
foreach (string tu in mangTu)
{
    Console.WriteLine($"  + {tu}");
}

string chuoiGhep = string.Join("-", mangTu);
Console.WriteLine($"- Chuỗi sau khi ghép lại (String.Join): {chuoiGhep}");
Console.WriteLine("Mssv: 6551071039");
Console.ReadLine();