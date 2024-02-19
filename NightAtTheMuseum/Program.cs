// See https://aka.ms/new-console-template for more information
Console.WriteLine("731A Night at the Museum!\n");

string input = Console.ReadLine()!.ToLower()!;

char start = 'a';
long sum = 0;

for (int i = 0; i < input.Length; i++)
{
    long x = Math.Abs(input[i] - start);
    long y = (26 - x);
    sum += Math.Min(x, y);
    start = input[i];
}

Console.WriteLine(sum);