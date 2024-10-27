// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

Console.WriteLine("Hello, World!");

// while: khi không biết rõ lặp bao nhiêu lần.
// for: khi đã biết được số phần tử để lặp.
// do...while: làm 1 lần trước khi vô vòng lặp.
// quan trọng nhất vẫn là xác định điều kiện dừng

// #region While Statement
// in ra các số từ 1 đến n với n là số được nhập từ bàn phím
// B1: khởi tạo giá trị lặp
// B2: xác định điều kiện lặp (tính tới trường hợp dừng)
// B3: thay đổi điều kiện lặp
// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);

// int count = 1; //B1
// while(count <= formatNumber) //B2
// {
//     Console.WriteLine(count);
//     count++; // count = count + 1 //B3
// }

// Nhập số n từ bàn phím, in ra tổng số từ 1->n
// S = 1 + 2 + 3 + ... + n;
// Console.WriteLine("Mời bạn nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int sum = 0;
// while(count <= number)
// {
//     sum += count; //sum = sum + count
//     count ++; // count = count + 1 hoặc count = 1
// }
// Console.WriteLine($"Tổng các số từ 1 đến n là: {sum}");

// Tính giai thừa của 1 số
// Console.WriteLine("Mời bạn nhập số giai thừa: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int factorial = 1;

// while(count <= number)
// {
//     factorial *= count; // factorial = factorial * count
//     count ++;
// }
// Console.WriteLine($"Tổng giai thừa từ 1 đến n là: {factorial}");
// 5! = 5*4*3*2*1
// Loop 1: count = 1 => factorial = factorial * count = 1 * 1
// Loop 2: count = 2 => factorial = factorial * count = 2 * 1 * 1
// Loop 3: count = 3 => factorial = factorial * count = 3 * 2 * 1 * 1
// Loop 4: count = 4 => factorial = factorial * count = 4 * 3 * 2 * 1 *1
// Loop 5: count = 5 => factorial = factorial * count = 5 * 4 * 3 * 2 * 1 *1 = 120

// In ra bảng cửu chương của n với n nhập từ bàn phím
// Console.WriteLine("Mời bạn nhập bảng cửu chương: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int count1 = 1;
// int bangCuuchuong;

// while(count1 <= 10)
// {
//     bangCuuchuong = count1 * number1;
//     Console.WriteLine($"{number1} * {count1} = {bangCuuchuong}");
//     count1 ++;
// }

// Nhập số nguyên tố và kiểm tra xem nó có phải số nguyên tố hay không.
// Console.WriteLine("Mời bạn nhập số nguyên tố: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int count2 = 2;
// while(count2 < number2)
// {
//     if(number2 % count2 == 0){
//         Console.WriteLine($"Số {number2} không phải là số nguyên tố");
//         break;
//     }

//     count2++;
// }
// if (count2 == number2)
// {
//     Console.WriteLine($"Số {number2} là số nguyên tố");
// }
//  #endregion

 #region For Statement

// in bảng cửu chương
//  int number3 = Convert.ToInt32(Console.ReadLine());
//  for (int count3 = 1; count3 <= 10; count3++)
//  {
//     Console.WriteLine($"{count3} x {number3} = {count3*number3}");
//  }
 
// Kiểm tra số nguyên tố
// int number4 = Convert.ToInt32(Console.ReadLine());
// int count4;
// for (int count4 = 2; count4 < number4; count4++)
//     {
//         if(number4 % count4 = 0)
//         {
//         Console.WriteLine($"Số {number4} không là số nguyên tố");
//         }
//         break;
//     }
// if(number4 == count4)
//     {
//         Console.WriteLine($"Số {number4} không là số nguyên tố");
//     }

// For ma trận chiều rộng x chiều dài

// Console.WriteLine("Mời bạn nhập chiều rộng");
// int chieuRong = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Mời bạn nhập chiều dài: ");
// int chieuDai = Convert.ToInt32(Console.ReadLine());
// for(int i = 0; i < chieuRong; i++)
// {
//     for(int j = 0; j < chieuDai; j++)
//     {
//         Console.Write("*");
//     }
//     Console.Write("\n"); //Console.WriteLine()
// }

// In ra tam giá cân
// j => 2*i+1
// i = 0: ___*
// i = 1: __***
// i = 2: _*****
// i = 3: *******
Console.WriteLine("Mời bạn nhập chiều cao tam giá: ");
int height = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < height; i++)
{
    // in khoảng trắng space trước dấu *
    for(int j = 0; j < height - i - 1; j++)
    {
        Console.Write(" ");
    }
    // in dấu *
    for(int k = 0; k < (2*i+1); k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// *************
// *           *
// *           *
// *           *
// *************
 #endregion