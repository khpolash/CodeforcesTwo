// See https://aka.ms/new-console-template for more information
Console.WriteLine("1676B Equal Candies!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);

    int[] candies = new int[n];
    string[] inputs = Console.ReadLine()!.Split();

    for (int j = 0; j < n; j++)
    {
        candies[j] = int.Parse(inputs[j]);
    }

    int min = candies.Min();

    int sum = candies.Sum(element => element - min);

    Console.WriteLine(sum);
}