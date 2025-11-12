using System.Text;

public static class ExcludeConsecutive
{
    public static int ExcludeConsecutiveDuplicates(this string data)
    {
        StringBuilder sb = new StringBuilder();
        List<string> _strList = new List<string>();

        for (int i = 0; i < data.Length; i++)
        {
            if (data.Length > 1)
            {
                if (data[0].ToString() == data.Substring(1, 1))
                {
                    sb.Append(data[i]);
                    sb.Append(data[i + 1]);
                    Helper.updateString(ref data, ref sb, ref _strList, false);
                    sb.Clear();
                    i = -1;
                    continue;
                }
            }

            if (!sb.ToString().Contains(data[i]))
            {
                sb.Append(data[i]);
                if (i == data.Length - 1)
                {
                    Helper.updateString(ref data, ref sb, ref _strList);
                }
            }
            else
            {
                Helper.updateString(ref data, ref sb, ref _strList);

                sb.Clear();
                if (data.ToCharArray().Length != 0)
                {
                    i = -1;
                }
                else
                {
                    break;
                }
                continue;
            }
        }

        return _strList.Select(x => x.Length).OrderByDescending(x => x).FirstOrDefault();
    }
}