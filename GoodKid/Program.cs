// See https://aka.ms/new-console-template for more information
Console.WriteLine("1873B Good Kid!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string[] inputs = Console.ReadLine()!.Split();
    int[] ints = new int[n];

    for (int j = 0; j < n; j++)
    {
        ints[j] = int.Parse(inputs[j]);
    }
    Array.Sort(ints);
    ints[0]++;

    long result = ints.Aggregate((a, b) => a * b);

    Console.WriteLine(result);
}
