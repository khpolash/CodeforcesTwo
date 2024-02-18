// See https://aka.ms/new-console-template for more information
Console.WriteLine("1829A Love Story!\n");

int t = int.Parse(Console.ReadLine()!);

char[] s = "codeforces".ToCharArray();

for (int i = 0; i < t; i++)
{
    char[] input = Console.ReadLine()!.ToLower().ToCharArray();
    int differences = s.Zip(input, (a, b) => a != b ? 1 : 0).Sum();
    Console.WriteLine(differences);
}