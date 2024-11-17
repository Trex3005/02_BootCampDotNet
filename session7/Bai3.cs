class Bai3
{
    public static List<string> findAllstartM(List<string> lstString)
    {
        List<string> results = new List<string>();
        foreach (string str in lstString)
        {
            if (str.Contains("m") == true)
            {
                results.Add(str);
            }
        }
        return results;
    }








}