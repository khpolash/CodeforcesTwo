// See https://aka.ms/new-console-template for more information
Console.WriteLine("1791C Prepend and Append!\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string s = Console.ReadLine()!;
    int l = 0, r = n - 1, ans = n;

    while (s[l] != s[r] && ans > 0)
    {
        l++; r--; ans -= 2;
    }

    Console.WriteLine(ans);
}
