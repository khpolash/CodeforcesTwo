// See https://aka.ms/new-console-template for more information
Console.WriteLine("1296A Array with Odd Sum!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string[] str = Console.ReadLine()!.Split();
    int sum = 0; bool odd = false; bool even = false;

    for (int j = 0; j < n; j++)
    {
        sum += int.Parse(str[j]);
        odd |= int.Parse(str[j]) % 2 != 0;
        even |= int.Parse(str[j]) % 2 == 0;
    }
    Console.WriteLine((sum % 2 != 0) || (odd && even) ? "YES" : "NO");
}
