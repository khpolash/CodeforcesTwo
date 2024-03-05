// See https://aka.ms/new-console-template for more information
Console.WriteLine("1669B Triple!\n");

int t = int.Parse(Console.ReadLine()!);
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] numArr = new int[n];
    string[] str = Console.ReadLine()!.Split();

    for (int j = 0; j < n; j++)
    {
        numArr[j] = int.Parse(str[j]);
    }

    var result = numArr.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
    var maxCount = result.FirstOrDefault(x => x.Value >= 3).Key;
    Console.WriteLine(maxCount > 0 ? maxCount : -1);
}