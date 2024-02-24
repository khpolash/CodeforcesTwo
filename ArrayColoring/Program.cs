// See https://aka.ms/new-console-template for more information
Console.WriteLine("1857A\tArray Coloring!\n");

int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int cnt = 0;

    string[] input = Console.ReadLine()!.Split();
    for (int i = 0; i < n; i++)
    {
        int x = int.Parse(input[i]);
        if (x % 2 != 0)
            cnt++;
    }

    if (cnt % 2 == 0)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}