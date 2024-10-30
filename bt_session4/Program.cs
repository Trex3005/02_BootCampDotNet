// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");

// Console.WriteLine("Bài 2: Nhập chiều cao tam giác. In ra tam giác cân rỗng");
// __*
// _* *
// __*   *
// _*     *
// *******

// Console.WriteLine("Bài 3: Nhập vào số n từ bàn phím. Kiểm tra số đó có phải là số đôi xứng không");
// Console.WriteLine("VD: Số 121, 1221, 12321,... là những số đối xứng");

#region 
// Bài tập 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n

Console.WriteLine("Mời bạn nhập số: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int count = 2; count <= number; count++)
{
    bool isPrime = true;
    for(int j = 2; j <= Math.Sqrt(count); j++)
    {
        if(count % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if(isPrime == true)
    {
        Console.WriteLine($"{count} ");
    }
}
Console.WriteLine();

// Console.WriteLine("Bài 3: Nhập vào số n từ bàn phím. Kiểm tra số đó có phải là số đôi xứng không");
// Console.WriteLine("VD: Số 121, 1221, 12321,... là những số đối xứng");

int number3 = Convert.ToInt32(Console.ReadLine());
int originalNumber = number3;
int reverseNumber = 0;

while(number3 > 0)
{
    int lastDigit = number3 % 10;
    reverseNumber = reverseNumber * 10 + lastDigit;
    number3 = number3 /10;
}
if(reverseNumber == originalNumber)
{
    Console.WriteLine($"Số {originalNumber} là số đối xứng");
}
else
{
    Console.WriteLine($"Số {originalNumber} không là số đối xứng");
}
#endregion