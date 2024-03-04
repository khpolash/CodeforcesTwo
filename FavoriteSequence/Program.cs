// See https://aka.ms/new-console-template for more information
Console.WriteLine("1462A Favorite Sequence!\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    long n = long.Parse(Console.ReadLine()!);
    string[] str = Console.ReadLine()!.Split();

    long[] numArr = new long[n];
    long[] resultArr = new long[n];

    for (int j = 0; j < n; j++)
    {
        numArr[j] = int.Parse(str[j]);
    }

    for (int k = 0; k < n; k++)
    {
        if (k % 2 == 0)
        {
            resultArr[k] = numArr.First();
            numArr = numArr.Skip(1).ToArray();
        }
        else
        {
            resultArr[k] = numArr.Last();
            numArr = numArr.SkipLast(1).ToArray();
        }

    }
    Console.WriteLine(string.Join(" ", resultArr));
}