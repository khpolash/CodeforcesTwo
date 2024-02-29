// See https://aka.ms/new-console-template for more information
Console.WriteLine("1311A Add Odd or Subtract Even!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string[] str = Console.ReadLine()!.Split();
    long x = long.Parse(str[0]);
    long y = long.Parse(str[1]);

    Console.WriteLine(x == y ? 0 : ((x > y && (x - y) % 2 == 0) || (y > x && (y - x) % 2 != 0)) ? 1 : 2);
}

