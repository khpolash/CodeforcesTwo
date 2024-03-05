// See https://aka.ms/new-console-template for more information
Console.WriteLine("1454A Special Permutation!\n");

int t = int.Parse(Console.ReadLine()!);
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] res = new int[n];
    for (int j = 0; j < n; j++)
    {
        res[j] = ((j + 1) % n) + 1;
    }

    Console.WriteLine(string.Join(" ", res));
}