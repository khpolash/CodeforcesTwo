// See https://aka.ms/new-console-template for more information
Console.WriteLine("1399B Gifts Fixing!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string[] strCandies = Console.ReadLine()!.Split();
    string[] strOranges = Console.ReadLine()!.Split();

    long[] candies = new long[n];
    long[] oranges = new long[n];

    for (int j = 0; j < n; j++)
    {
        candies[j] = int.Parse(strCandies[j]);
        oranges[j] = int.Parse(strOranges[j]);
    }

    long minCandy = candies.Min();
    long minOrange = oranges.Min();

    long moves = 0;

    for (int k = 0; k < n; k++)
    {
        moves += Math.Max(candies[k] - minCandy, oranges[k] - minOrange);
    }

    Console.WriteLine(moves);
}