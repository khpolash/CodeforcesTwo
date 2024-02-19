// See https://aka.ms/new-console-template for more information
Console.WriteLine("1520B Ordinary Numbers!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);

    int result = n > 9 ? TotalOrdinaryNumbers(n) : n;
    Console.WriteLine(result);
}


static int TotalOrdinaryNumbers(int n)
{
    string subOne = n.ToString()[1..];
    int x = n - int.Parse(subOne);
    int start = Convert.ToInt32(x.ToString()[..1]);
    int ext = (int)Math.Log10(x);
    bool isGreater = false;
    bool isEqual = false;
    for (int j = 0; j < subOne.Length; j++)
    {
        char[] ch = subOne.ToCharArray();
        if (int.Parse(ch[j].ToString()) > start)
        {
            isGreater = true;
            isEqual = false;
            break;
        }
        else if (int.Parse(ch[j].ToString()) < start)
        {
            isGreater = false;
            isEqual = false;
            break;
        }
        else
        {
            if (int.Parse(ch[j].ToString()) == start)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }

        }
    }
    int result = isGreater || isEqual ? (9 * ext) + (start - 1) + 1 : (9 * ext) + (start - 1);
    return result;
}