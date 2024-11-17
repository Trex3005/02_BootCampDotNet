internal class Program
{
    private static void Main(string[] args)
    {   
        #region Bài 1: Tìm hai số sao cho tổng chúng bằng target
        // Console.WriteLine("Hello, World!");
        // List<int> lst = new List<int>{2, 5, 7, 9, 11, 15};
        // int target = 26;
        // Console.WriteLine("Bài 1: Tìm hai số sao cho tổng chúng bằng target");
        // if(TwoSum.twoSum(lst, target) == null)
        // {
        //     Console.WriteLine("Không có hai số nào có tổng bằng target.");
        // }
        // else 
        // {
        //     List<int> indexes = TwoSum.twoSum(lst, target);
        //     Console.WriteLine($"Hai số có tổng bằng target là: {string.Join(',', indexes)}");
        // }
        #endregion

        #region Cách 2: Tìm hai số sao cho tổng chúng bằng target
        List<int> lst = new List<int>{2, 5, 7, 9, 11, 15};
        int target = 26;
        Console.WriteLine("Cách 2: Tìm hai số sao cho tổng chúng bằng target");
        if(TwoSum.twoSumDictionary(lst, target) == null)
        {
            Console.WriteLine("Không có hai số nào có tổng bằng target.");
        }
        else 
        {
            List<int> indexes = TwoSum.twoSumDictionary(lst, target);
            Console.WriteLine($"Hai số có tổng bằng target là: {string.Join(',', indexes)}");
        }
        #endregion
    }
}