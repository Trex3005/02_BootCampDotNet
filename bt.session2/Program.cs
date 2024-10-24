// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Bài tập 1: Tính số ngày trong tuần và số ngày lẻ
// Input
// B1: Người dùng nhập số ngày
Console.WriteLine("Bài tập 1: Tính số ngày trong tuần và số ngày lẻ.");
Console.WriteLine("Nhập số ngày:");
string? songay = Console.ReadLine();

// Output
// Số tuần và số ngày lẻ.
int sotuan = 0;
int songayle = 0;

// Process
// Tính toán số tuần và số ngày lẻ còn lại.
// Ví dụ: người dùng nhập 10 ngày thì số tuần là 1 và ngày lẻ là 3.
int formatsongay = Convert.ToInt32(songay);
sotuan = formatsongay / 7;
songayle = formatsongay % 7;
Console.WriteLine($"Số tuần là: {sotuan}");
Console.WriteLine($"Số ngày lẻ là: {songayle}");

#endregion

#region Bài tập 2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
// Input
// Nhập giá trị của đơn hàng là 1 ly trà sữa
Console.WriteLine("Bài tập 2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá.");
Console.WriteLine("Nhập giá trị ly trà sữa: ");
string? sotienlytra = Console.ReadLine();
Console.WriteLine("Nhập phần trăm giảm giá: ");
string? phantramgiam = Console.ReadLine(); 

// Output
// Tổng giá tiền cần phải thanh toán
int sotiengiam = 0;
int tonggiatien = 0;

// Process
// Tính toán số tiền giảm giá và tổng số tiền phải thanh toán sau khi áp dụng giảm giá
int formatsotienlytra = Convert.ToInt32(sotienlytra);
int formatphantramgiam = Convert.ToInt32(phantramgiam);
sotiengiam = formatsotienlytra * formatphantramgiam / 100;
tonggiatien = formatsotienlytra - sotiengiam;
Console.WriteLine($"Tổng giá tiền ly trà sữa sau giảm giá là: {tonggiatien}");

#endregion

#region Bài tập 3: Chuyển đổi thời gian từ phút sang giờ và phút
// Input: Nhập vào tổng số phút
Console.WriteLine("Bài tập 3: Chuyển đổi thời gian từ phút sang giờ và phút.");
Console.WriteLine("Mời bạn nhập tổng số phút: ");
string? tongsophut = Console.ReadLine();

// Output: Số giờ và số phút
int sophut = 0;
int sogio = 0;

// Process: Chuyển đổi tổng số phút thành số giờ và số phút
int formattongsophut = Convert.ToInt32(tongsophut);
sogio = formattongsophut / 60;
sophut = formattongsophut % 60;
Console.WriteLine($"Số giờ là: {sogio} giờ");
Console.WriteLine($"Số phút là: {sophut} phút");

#endregion

#region Bài tập 4: Tính tổng số tiền sau khi cộng thêm thuế VAT
// Input
// Nhập số tiền gốc và nhập tỷ lệ thuế VAT (ví dụ 10%)
Console.WriteLine("Bài tập 4: Tính tổng số tiền sau khi cộng thêm thuế VAT.");
Console.WriteLine("Nhập số tiền gốc: ");
string? sotiengoc = Console.ReadLine();
Console.WriteLine("Nhập phần trăm thuế VAT: ");
string? thuevat = Console.ReadLine();

// Output
// Tiền thuế
// Tổng tiền sau khi đã cộng thêm thuế
int tienthue = 0;
int tongtiensauthue = 0;

// Process
// Tính số tiền thuế và tổng tiền sau thuế
int formatsotiengoc = Convert.ToInt32(sotiengoc);
int formatthuevat = Convert.ToInt32(thuevat);
tienthue = formatsotiengoc * formatthuevat / 100;
tongtiensauthue = formatsotiengoc + tienthue;
Console.WriteLine($"Tổng tiền sau thuế là: {tongtiensauthue}");

#endregion

#region Bài tập 5: Chuyển đổi đơn vị tiền tệ
// Input
// Nhập số tiền bằng USD
// Nhập tỷ giá vnd/usd
Console.WriteLine("Bài tập 5: Chuyển đổi đơn vị tiền tệ.");
Console.WriteLine("Nhập số tiền bằng USD: ");
string? sotienusd = Console.ReadLine();
Console.WriteLine("Nhập tỷ giá vnd/usd: ");
string? tygiavndusd = Console.ReadLine();

// Output
// Tỷ giá usd
// Số tiền bằng VND
float sotienvnd = 0;

// Process
// Dựa theo tỷ giá tính số tiền VND tương ứng.
float formatsotienusd = Convert.ToDouble(sotienusd);
float formattygiavndusd = Convert.ToDouble(tygiavndusd);
sotienvnd = formatsotienusd * formattygiavndusd;
Console.WriteLine($"Số tiền VND là {sotienvnd} VND");

#endregion