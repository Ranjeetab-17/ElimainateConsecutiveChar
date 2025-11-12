using System.Text;

public static class SplitStrings
{
    public static List<string> SplitStringByComma(this string data)
    {
        List<string> result = new List<string>();

        for (int i = 0; i < data.ToCharArray().Length; i++)
        {
            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < data.ToCharArray().Length; j++)
            {
                if (data[i] == data[j])
                {
                    sb.Append(data[j]);
                    continue;
                }
                break;
            }

            data = data.Remove(0, sb.Length);
            i = -1;
            result.Add(sb.ToString());
            sb.Clear();

            continue;
        }
        
        return result;
    }
}