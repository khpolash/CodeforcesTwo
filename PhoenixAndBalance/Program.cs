// See https://aka.ms/new-console-template for more information
Console.WriteLine("1348A Phoenix and Balance!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);

    int groupOne = (int)Math.Pow(2, n), groupTwo = 0;

    for (int j = 1; j < n / 2; j++)
    {
        groupOne += (int)Math.Pow(2, j);
    }
    for (int j = n / 2; j < n; j++)
    {
        groupTwo += (int)Math.Pow(2, j);
    }

    Console.WriteLine(Math.Abs(groupOne - groupTwo));
}
