using System.Text;

public class Helper
{
    public static string updateString(ref string data, ref StringBuilder sb, ref List<string> strList, bool isAdd = true)
    {
        data = data.Remove(0, sb.Length);
        
        if (isAdd)
            strList.Add(sb.ToString());

        return data;
    }
}