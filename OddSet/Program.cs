// See https://aka.ms/new-console-template for more information
Console.WriteLine("1542A Odd Set!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string[] inputs = Console.ReadLine()!.Split();
    int[] number = new int[n * 2];

    for (int j = 0; j < n * 2; j++)
    {
        number[j] = int.Parse(inputs[j]);
    }

    int totalEven = 0; int totalOdd = 0;

    for (int j = 0; j < number.Length; j++)
    {
        if (number[j] % 2 == 0)
        {
            totalEven++;
        }
        else
        {
            totalOdd++;
        }
    }

    Console.WriteLine(totalEven == totalOdd ? "YES" : "NO");
}