// See https://aka.ms/new-console-template for more information
using System.Text;

// string[] data = { "abcbacbb", "bbbbbabcdef", "aaaaa" };
// foreach (var item in data)
// {
//      Console.WriteLine($"Input: {item} => Output: {item.ExcludeConsecutiveDuplicates()}");
// }

// var _data = "bbbbbabcdef";

var _data = "bbbbbabcdef";

var result = _data.SplitStringByComma();

StringBuilder sb = new StringBuilder();

for (int i = 0; i < result.Count; i++)
{
    if (result[i].ToCharArray().Length > 1)
    {
        _data = _data.Remove(i, result[i].ToCharArray().Length);
    }
}

Console.WriteLine(_data.ExcludeConsecutiveDuplicates());


