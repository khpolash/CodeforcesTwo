// See https://aka.ms/new-console-template for more information
Console.WriteLine("1760B Atilla's Favorite Problem!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string str = Console.ReadLine()!.ToLower();
    char[] chars = new char[n];
    chars = str.ToCharArray();
    Array.Sort(chars);
    int result = GetAlphabetPosition(chars[^1]);
    Console.WriteLine(result);
}

static int GetAlphabetPosition(char letter)
{
    return letter - 'a' + 1;
}