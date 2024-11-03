using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        #region kiểm tra số nguyên tố
        // Console.Write("Mời bạn nhập số nguyên tố:");
        // string? number = Console.ReadLine();
        // int formatNumber = Convert.ToInt32(number);
        
        // if (Method.checkPrime(formatNumber))
        // {
        //     Console.WriteLine($"Số {number} là số nguyên tố.");
        // }
        // else
        // {
        //     Console.WriteLine($"Số {number} không là số nguyen tố");
        // }
        #endregion

        #region in ra tam giác vuông có chiều cao n nhập từ bàn phím
        // Console.WriteLine("Mời bạn nhập chiều cao: ");
        // string? height = Console.ReadLine();
        // int formatHeight = Convert.ToInt32(height);
        // Method.printSquareTriangle(formatHeight);
        #endregion
    
        #region Collection trong C#
        // Data structure
        // List
        List <int> numbers = new List<int>();

        // Define giá trị ban đầu
        List<string> names = new List<string> {"Phương", "Duc", "Linh", "Hung", "Tri"};
        Console.WriteLine($"Phần tử thứ 2 là: {names[2]}");
        Console.WriteLine($"Phần tử nghịch đảo là : {names[^3]}");
        
        // Console.WriteLine(names);
        // Lưu ý: WriteLine chỉ in được giá trị cho những kiểu dữ liệu nguyên thủy: int, float, double, string,...
        // Còn kiểu dữ liệu Collection thì chỉ in ra đại chỉ vùng nhớ của biến đó
        Console.WriteLine(String.Join (", ", names));
        
        // Bài tập làm quen: nhập n từ bàn phím. Sau đó nhập n phần tử và xuất ra n phần tử.
        Console.WriteLine("Mời bạn nhập số lượng phần tử: ");
        string? number = Console.ReadLine();
        int formatNumber = Convert.ToInt32(number);
        // Tạo biến chứa danh sách phần từ
        List<int> listNumbers = new List<int>();
        Console.WriteLine("Danh sách phần tử sau khi nhập là: ");
        for (int i = 0; i < formatNumber; i++)
        {
            // C1: dùng insert
            string? item = Console.ReadLine();
            int formatItem = Convert.ToInt32(item);
            listNumbers.Insert(i, formatItem);
        }
        // in list phần tử ra ngoài màn hình
        // sẽ có 2 cách duyệt phần tử: for hoặc foreach
        // C1: for
        for(int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }
        // C2: dùng foreach
        Console.WriteLine("Danh sách phần tử dùng trong foreach: ");
        foreach(int item in listNumbers)
        {
            Console.WriteLine(item);
        }

        #endregion
    }

}