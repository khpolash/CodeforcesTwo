// See https://aka.ms/new-console-template for more information
Console.WriteLine("1829B Blank Space!\n");

int t = int.Parse(Console.ReadLine()!);
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string[] str = Console.ReadLine()!.Split();
    int current = 0, ans = 0;

    for (int j = 0; j < n; j++)
    {
        if (int.Parse(str[j]) == 0)
        {
            current++;
        }
        else
        {
            ans = Math.Max(ans, current);
            current = 0;
        }
    }
    Console.WriteLine(Math.Max(ans, current));
}