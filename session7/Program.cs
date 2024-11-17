internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Nhập số phần tử từ bàn phím: ");

        #region function trong List của Collection
        // // khởi tạo danh sách
        // List<int> numbers = new List<int>();
        // // nhập n từ bàn phím với n là số lượng phần tử của mảng
        // string? n = Console.ReadLine();
        // int format = Convert.ToInt32(n);
        // for(int i = 0; i < format; i++)
        // {
        //     Console.WriteLine($"Mời bạn nhập số thứ (i + 1)");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     numbers.Add(number);
        // }

        // Console.WriteLine("Danh sách phần tử đã nhập là: ");
        // foreach(int number in numbers)
        // {
        //     Console.Write(number);
        // }
        // Console.WriteLine();
        // //C1: dùng Join
        // Console.WriteLine(String.Join(",",numbers));
        
        // //C2: dùng Function sort để sắp xếp phần tử của mảng
        // numbers.Sort();
        // Console.WriteLine("Danh sách phần tử đã sắp xếp: ");
        // Console.Write(String.Join(",", numbers));

        // // dùng function Reverse()
        // numbers.Reverse();
        // Console.WriteLine();
        // Console.WriteLine("Danh sách phần tử sau khi dùng hàm Reverse: ");
        // Console.Write(String.Join(",", numbers));

        #endregion

        #region Bài 1: tính tổng các số lớn hơn hoặc bằng 50 trong dãy số
        // khai báo list phần tử
        List<int>number = new List<int>{20, 50, 31, 75, 20, 65, 20, 100};
        // kết quả của hàm tinTongSoLon50 sẽ gắn cho biến sum
        int sum = Bai1.tinhTongSoLon50(number);
        Console.WriteLine($"Tổng các số lớn hơn 50 của mảng là: {sum}");

        #endregion

        #region Bài 2: tìm số lớn nhất của mảng
        // giải thuật
        // B1: tìm 1 số bất kỳ trong mảng làm số lớn (số đầu tiên của mảng)
        // B2: duyệt mảng từ phần tử thứ 2 và so sánh với số đại diện
        // B3: nếu số đại diện nhỏ hơn phần tử đang xét ==> gán lại
        // B4: ngược lại thì duyệt tiếp

        // int max = Bai2.findMaxNumber(number);
        // Console.WriteLine($"Số lớn nhất của mảng là: {max}");

        #endregion

        #region Bài 3: tìm các từ có chữ "m"
        // List<string> tuCochum = new List<string>{"mango", "manga", "apple"};

        // List<string> danhSachtucochum = Bai3.findAllstartM(tuCochum);
        // Console.WriteLine($"chữ có chữ m là: {String.Join(",", danhSachtucochum)}");
        
        #endregion

        #region Bài 4: liệt kê các phần tử không trùng nhau
        // List<int> lstNumber = new List<int>{1,1,2,2,3,3,4,4,5,5,5};
        // List<int> lstResults = Bai4.uquieNumbers(lstNumber);
        // Console.WriteLine($"dãy số là: {String.Join(",", lstResults)}");
        
        #endregion
    
        #region Tìm hiểu về dictionary trong Collection
        Dictionary<string, string> dic = new Dictionary<string, string>();

        // thêm key-value vào dic
        dic.Add("Alice", "test");
        dic["Do"] = "Nam Trung";
        // duyệt dic
        foreach(KeyValuePair<string, string> pointer in dic)
        {
            // pointer: key-value
            Console.WriteLine($"Họ: {pointer.Key}, Tên:{pointer.Value}");

        }
        // chỉ duyệt mỗi key hoặc value => y chang như bên list
        // chỉ duyệt key
        Console.WriteLine("danh sách các key là: ");
        foreach(string str in dic.Keys)
        {
            Console.WriteLine(str);
        }
        for(int i = 0; i < dic.Keys.Count; i++)
        {
            Console.WriteLine(dic.Keys.ElementAt(i));
        }

        // update value cho dic
        dic["Alice"] = "Johnson";
        Console.WriteLine("Dic sau khi update");
        foreach(KeyValuePair<string, string> pointer in dic)
        {
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }

        // xóa key-value trong dic
        dic.Remove("Alice");
        Console.WriteLine("Dic sau khi remove keyvalue");
        foreach(KeyValuePair<string, string> pointer in dic)
        {
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }

        #endregion
    }
}