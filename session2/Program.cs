// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

Console.WriteLine("Hello, World!");

#region Hoc phep toan co ban
// hoc +, -, *, / (chia lay phan nguyen), % (chia lay phan du)
// khai bao bien
// int add = 5 + 10;
// Console.WriteLine($"Ket qua cong hai so 5 va 10 la: {add}");

// int minus = 12 - 5;
// Console.WriteLine($"Ket qua tru hai so 12 va 5 la: {minus}");

// double dividea = 15 / 4;
// Console.WriteLine($"Ket qua chia hai so 15 va 4 la: {dividea}");

// double divideb = 15%4;
// Console.WriteLine($"Ket qua chia hai so 15 va 4 lay phan du la: {divideb}");
#endregion

#region Numberic toan tu
// int cong = 0; //Dinh nghia bien cong co gia tri mac dinh 0
// cong += 10;
// Console.WriteLine($"Numberic toan tu cong la: {cong}");

// int nhan = 1; //Dinh nghia bien nhan co gia tri mac dinh 1
// nhan *= 100;
// Console.WriteLine($"Numberic toantu nhan la: {nhan}");

#endregion

#region Ep kieu du lieu C1: Dung Convert
// // Convert
// // Nhap du lieu tu ban phim => Readline (string)
// string number = Console.ReadLine();
// int convertNumber = Convert.ToInt32(number);
// Console.WriteLine($"value number: {convertNumber}");
#endregion

#region Tinh chi so BMI

// // Input
// // Chieu ca va can nang duoc nhap tu ban phim
// Console.WriteLine("Moi ban nhap chieu cao (m)");
// string chieucao = Console.ReadLine();
// // Convert string -> double
// double formatchieucao = Convert.ToDouble(chieucao);

// Console.WriteLine("Moi ban nhap can nang (kg)");
// string cannang = Console.ReadLine();
// // Convert string -> double
// double formatcannang = Convert.ToDouble(cannang);

// // Output
// // In ra chi so BMI
// // Khoi tao bien BMI de luu gia tri BMI
// double bmi = 0.0;
// bmi = formatcannang / (formatchieucao * formatchieucao);
// Console.WriteLine($"Chi so BMI cua ban la: {bmi}");

// // Process
// // BMI = (can nang) / (chieu cao) * (chieu cao)
#endregion 

#region Tinh chu vi va dien tich hinh trong
// // Input
// // B1: Nhap ban kinh tu ban phim
// Console.WriteLine("Moi ban nhap ban kinh hinh tron");
// string bankinh = Console.ReadLine();

// // B2: Convert kieu du lieu string -> double cho ban kinh
// double formatbankinh = Convert.ToDouble(bankinh);

// // Output
// double chuvi = 0.0;
// double dientich = 0.0;

// // Process
// // Chu vi = 2*pi*bankinh
// // Dientich = pi*bankinh*bankinh
// double Pi = Math.PI; // Hang so Pi co san cua thu vien Math trong C#
// chuvi = 2 * Pi * formatbankinh;
// dientich = Pi * formatbankinh * formatbankinh;
// Console.WriteLine($"Chu vi hinh tron la: {chuvi}");
// Console.WriteLine($"Dien tich hinh trong la: {dientich}");

#endregion