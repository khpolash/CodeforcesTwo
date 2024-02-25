// See https://aka.ms/new-console-template for more information
Console.WriteLine("1791B Following Directions!\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string str = Console.ReadLine()!.ToUpper();
    char[] strArr = new char[n];
    strArr = str.ToCharArray();
    int x = 0; int y = 0;
    bool passesCandy = false;
    for (int j = 0; j < n; j++)
    {
        if (strArr[j] == 'L') x--;
        if (strArr[j] == 'R') x++;
        if (strArr[j] == 'D') y--;
        if (strArr[j] == 'U') y++;

        if ((x == 1 && y == 1))
        {
            passesCandy = true;
        }
    }
    Console.WriteLine(passesCandy ? "YES" : "NO");
}