// See https://aka.ms/new-console-template for more information
Console.WriteLine("1472A Cards for Friends!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string[] str = Console.ReadLine()!.Split();
    int w = int.Parse(str[0]);
    int h = int.Parse(str[1]);
    long n = long.Parse(str[2]);

    long result = 1;

    while (w % 2 == 0)
    {
        w /= 2;
        result *= 2;
    }
    while (h % 2 == 0)
    {
        h /= 2;
        result *= 2;
    }

    Console.WriteLine(result >= n ? "YES" : "NO");
}
