// See https://aka.ms/new-console-template for more information
Console.WriteLine("1294A Collecting Coins!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int[] ints = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    bool result = CanDistributeCoinsEqually(ints[0], ints[1], ints[2], ints[3]);

    Console.WriteLine(result ? "YES" : "NO");
}

static bool CanDistributeCoinsEqually(int a, int b, int c, int n)
{
    int maxCoins = Math.Max(Math.Max(a, b), c);
    int remainingCoins = n - (maxCoins - a + maxCoins - b + maxCoins - c);
    return (remainingCoins >= 0) && (remainingCoins % 3 == 0);
}