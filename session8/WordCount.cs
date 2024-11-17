using System.Security.AccessControl;

class WordCount
{
    public static Dictionary<string, int> wordCount(List<string> words)
    {
        Dictionary<string, int> count = new Dictionary<string, int>();
        for(int i = 0; i < words.Count; i++)
        {
            if(count.ContainsKey(words[i]))
            {
                count[words[i]]++; // từ này xuất hiện nhiều lần
            }
            else
            {
                count[words[i]]=1; // từ này xuất hiện lần đầu
            }
        }
        // c2: duyệt for theo từng item
        foreach(string word in words)
        {
            if(count.ContainsKey(word))
            {
                count[word]++;
            }
            else
            {
                count[word] = 1;
            }
        }
        return count;
    }
}