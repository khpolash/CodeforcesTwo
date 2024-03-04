// See https://aka.ms/new-console-template for more information
Console.WriteLine("1850C Word on the Paper!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string result = string.Empty;
    for (int j = 0; j < 8; j++)
    {
        string str = Console.ReadLine()!;
        result += new string(str.Where(char.IsLetter).ToArray());
    }
    Console.WriteLine(result);
}