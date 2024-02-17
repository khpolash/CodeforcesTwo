// See https://aka.ms/new-console-template for more information
Console.WriteLine("1371A Magical Sticks!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    long n = long.Parse(Console.ReadLine()!);
    long result = n % 2 == 0 ? (n / 2) : 1 + ((n - 1) / 2);
    Console.WriteLine(result);
}
