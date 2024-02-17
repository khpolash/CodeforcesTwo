// See https://aka.ms/new-console-template for more information
Console.WriteLine("1703B ICPC Balloons!");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    char[] str = new char[n];
    string input = Console.ReadLine()!;
    for (int j = 0; j < n; j++)
    {
        str[j] = input[j];
    }
    int totalPoint = 0;
    var elementCounts = str.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
    foreach (var item in elementCounts)
    {
        totalPoint += item.Value + 1;
    }

    Console.WriteLine(totalPoint);
}