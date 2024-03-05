// See https://aka.ms/new-console-template for more information
Console.WriteLine("1353A Most Unstable Array!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    long[] numArr = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

    Console.WriteLine(Math.Min(2, numArr[0] - 1) * numArr[1]);
}
