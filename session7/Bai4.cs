class Bai4
{
    public static List<int> uquieNumbers(List<int> numbers)
    {
        List<int> results = new List<int>();
        results.Add(numbers.ElementAt(0));
        for(int i = 1; i < numbers.Count; i++)
        {
            // c1: kiểm tra mảng hiện tại đã có phần tử numbers[i] chưa
            if(results.Contains(numbers[i]) == false)
            {
                results.Add(numbers[i]);
            }
            // c2: so sánh phần tử đằng trước, chỉ áp dụng khi list đã được sort rồi.
            // if(numbers[i] != numbers[i-1])
            // {
            //     results.Add(numbers[i]);
            // }
        }
        return results;

    }
}