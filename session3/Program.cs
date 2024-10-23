// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region Bài tập 1: Tính số ngày trong tuần và số ngày lẻ
// // Input
// // B1: Người dùng nhập số ngày
// Console.WriteLine("Nhập số ngày:");
// string songay = Console.ReadLine();
// // B2: Convert dữ liệu số ngày thành double cho số ngày
// double formatsongay = Convert.ToDouble(songay);

// // Process
// // Tính toán số tuần và số ngày lẻ còn lại.
// // Ví dụ: người dùng nhập 10 ngày thì số tuần là 1 và ngày lẻ là 3.


// // Output
// // Số tuần và số ngày lẻ.

#endregion

#region Bài tập 2: Tính giá tiền sản phẩm trà sữa sau khi giảm giá
// Input
// Nhập giá tiền trà sữa
// Nhập % giảm giá
Console.WriteLine("Mời bạn nhập số tiền trà sữa:");
string? giatien = Console.ReadLine();
Console.WriteLine("Mời bạn nhập phần trăm giảm giá");
string? phantramgiamgia = Console.ReadLine();

// Output
// Số tiền giảm
// Số tiền phải trả sau khi giảm
int tiengiam = 0;
int tienphaitra = 0;

// Process
int formatgiatien = Convert.ToInt32(giatien);
int formatphantramgiam = Convert.ToInt32(phantramgiamgia);
tiengiam = formatgiatien * formatphantramgiam / 100;
tienphaitra = formatgiatien - tiengiam;

Console.WriteLine($"Tiền phải trả là: {tienphaitra}");

#endregion

#region If-else statement
// // Nhập số nguyên từ bàn phím, in ra số đó là số lẻ hay số chẵn
// // Input
// Console.WriteLine("Mời bạn nhập số nguyên:");
// string? number = Console.ReadLine();
// int formatnumber = Convert.ToInt32(number); 
// if(formatnumber%2 == 0) 
// {
//     Console.WriteLine($"Số {formatnumber} là số chẵn.");
// }
// else
// {
//     Console.WriteLine($"Số {formatnumber} là số lẻ.");
// }    

// Output
// Process

// Truthy:
// int day = 5;
// if(day != 0)
// {
//     // >, <, >=, <=, ==, !=
//     Console.WriteLine("Truthy");
// }

// // Nhập điểm trung bình của học sinh, xuất ra học lực của học sinh đó.
// // >= 9: xuất sắc.
// // 8 <= điểm < 9: giỏi.
// // 6.5 <= điểm < 8: khá.
// // 5 <= điểm < 6.5: trung bình.
// // 3.5 <= điểm < 5: yếu
// // điểm < 3.5: quá kém.

// Console.WriteLine("Mời bạn nhập điểm số");
// string? diem = Console.ReadLine();
// double formatdiem = Convert.ToDouble(diem);

// if (formatdiem >= 9)
// {
//     Console.WriteLine("Xuất sắc");
// }
// else if (8 <= formatdiem && formatdiem < 9)
// {
//     // Ngôn ngữ thực tế: 8 <= diem < 9.
//     // Ngôn ngữ lập trình: 8 <= diem && diem <9.
//     // Kết hợp 2 hoặc nhiều điều kiện:
//         // && là điều kiện và
//         // || là điều kiện hoặc
//     Console.WriteLine("Giỏi");
// }
// else if (6.5 <= formatdiem && formatdiem < 8)
// {
//     Console.WriteLine("Khá");
// }
// else if (5 <= formatdiem && formatdiem < 6.5)
// {
//     Console.WriteLine("Trung Bình");
// }
// else if (3.5 <= formatdiem && formatdiem < 5)
// {
//     Console.WriteLine("Yếu");
// }
// else 
// {
//     Console.WriteLine("Quá Kém");
// }

#endregion

#region Bài tập nhập 1 số có 3 chữ số và tính tổng 3 chữ số đố

// Cách 1
Console.WriteLine("Nhập số có 3 chữ số:");

string? sobachuso = Console.ReadLine();
int formatsobachuso = Convert.ToInt32(sobachuso);
int sohaichuso = 0;
int tongbachuso = 0;
int sohangtram = 0;
int sohangchuc = 0;
int sohangdonvi = 0;

if(100 > formatsobachuso || formatsobachuso >= 1000)
{
    Console.WriteLine("Bạn nhập lỗi, nhập lại số ba chữ số:");
} 
else
{
    sohangtram = formatsobachuso / 100;
    sohaichuso = formatsobachuso - sohangtram * 100;
    sohangchuc = sohaichuso /10;
    sohangdonvi = sohaichuso %10;
    tongbachuso = sohangtram + sohangchuc + sohangdonvi;
    Console.WriteLine($"Tổng ba chứ số là: {tongbachuso}");
}

// Nhập ngày (dd/mm/yyyy), in ra thứ mấy trong tuần.
// VD: 23/10/2024 => thứ tư
// Lưu ý: không dùng thư viện

// 2 -> thứ 2
// 3 -> thứ 3 
// 4 -> thứ 4

// khi mà điều kiện nó độc lập với nhau, không có liên quan đến nhau:
// if(){}
// if(){}
// if()

// khi mà điều kiện nó có liên quan đến nhau:
// if(){}
// else (){}

// switch...case
// C1: dùng switch...case
// nhập số có trong khoảng từ 1 đến 10. Đọc số
string? number2 = Console.ReadLine();
int formatnumber2 = Convert.ToInt32(number2);
switch (formatnumber2)
{
    case 1:
        Console.WriteLine("Số 1");
        break;
    case 2:
        Console.WriteLine("Số 2");
        break;
    case 3:
        Console.WriteLine("Số 3");
        break;
    case 4:
        Console.WriteLine("Số 4");
        break;
    default:
        Console.WriteLine("Số khác")
        break;
}

// C2: dùng switch...expression

#endregion