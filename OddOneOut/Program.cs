// See https://aka.ms/new-console-template for more information
Console.WriteLine("1915A Odd One Out!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int[] inputs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    int uniqueOne = inputs.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).FirstOrDefault();

    Console.WriteLine(uniqueOne);

}
