// See https://aka.ms/new-console-template for more information
Console.WriteLine("233A Perfect Permutation!\n");

int n = int.Parse(Console.ReadLine()!);

if (n % 2 == 1)
{
    Console.WriteLine("-1");
    return;
}

for (int i = 1; i <= n; i += 2)
{
    Console.Write($"{i + 1} {i} ");
}

