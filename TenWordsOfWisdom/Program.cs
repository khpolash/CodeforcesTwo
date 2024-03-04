// See https://aka.ms/new-console-template for more information
Console.WriteLine("1850B Ten Words of Wisdom!\n");

int t = int.Parse(Console.ReadLine()!);
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int bestQuality = 0, winner = -1;
    for (int j = 1; j <= n; j++)
    {
        int[] numArr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        if (numArr[1] > bestQuality && numArr[0] <= 10)
        {
            winner = j;
            bestQuality = numArr[1];
        }
    }
    Console.WriteLine(winner);
}