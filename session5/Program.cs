using System.Runtime.CompilerServices;
using System.Security.Cryptography;

internal class Program
{
    // Khai báo hàm kiểm tra số đối xứng
    private static int getReverseNumber(int number)
    {
        int originalNumber = number;
        int reverseNumber = 0;
        while(number > 0)
        {
            int lastDigit = number % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            number = number / 10;
        }
        return reverseNumber;
    }
    
    // Khai báo hàm kiểm tra số nguyên tố
    private static bool isPrime(int number)
    {
        if(number < 2) 
        {
            return false;
        }
        for (int count = 2; count <= Math.Sqrt(number); count++)
        {
            if(number % count == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    // Khai báo hàm
    private static int tinhTong(int number1, int number2)
    {
        return number1 + number2;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        // Bài tập 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n
        // Gọi hàm

        Console.WriteLine("Mời bạn nhập số: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int count = 2; count <= number; count++)
        {
            bool checkPrime = isPrime(count);
            
            if(checkPrime == true)
            {
                Console.WriteLine($"{count} ");
            }
        }
        Console.WriteLine();

        // Gọi hàm
        int ketQua = tinhTong(10, 11);

        Console.WriteLine($"Tổng 2 số là {ketQua}");
        
        // Tách hàm lấy ra số nghịch đảo

        Console.WriteLine("Mời bạn nhập một số: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number3;
        int reverseNumber = getReverseNumber(number3);
        
        if (reverseNumber == originalNumber){
            Console.WriteLine($"Số {originalNumber} là số đối xứng");
        } else {
            Console.WriteLine($"Số {originalNumber} không là số đối xứng");
        }
    }
}


        