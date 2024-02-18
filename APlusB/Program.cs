// See https://aka.ms/new-console-template for more information
Console.WriteLine("1772A A+B!\n");

int t = int.Parse(Console.ReadLine()!);
for (int i = 0; i < t; i++)
{
    string inputs = Console.ReadLine()!;

    int a = int.Parse(inputs[0].ToString());
    int b = int.Parse(inputs[2].ToString());

    Console.WriteLine(a + b);
}