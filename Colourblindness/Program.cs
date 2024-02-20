// See https://aka.ms/new-console-template for more information
Console.WriteLine("1722B Colourblindness!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string firstStr = Console.ReadLine()!;
    string secondStr = Console.ReadLine()!;

    Char[] firstRow = new Char[n];
    Char[] secondRow = new Char[n];

    for (int j = 0; j < n; j++)
    {
        firstRow[j] = firstStr[j];
        secondRow[j] = secondStr[j];
    }

    bool result = IsRowsIdentical(n, firstRow, secondRow);

    Console.WriteLine(result ? "YES" : "NO");
}

static bool IsRowsIdentical(int n, char[] firstRow, char[] secondRow)
{
    for (int i = 0; i < n; i++)
    {
        if (firstRow[i] == 'R')
        {
            if (secondRow[i] != 'R')
            {
                return false;
            }
        }
        else
        {
            if (secondRow[i] == 'R')
            {
                return false;
            }
        }
    }

    return true;
}