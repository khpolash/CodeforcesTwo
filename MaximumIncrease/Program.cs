// See https://aka.ms/new-console-template for more information
Console.WriteLine("702A  Maximum Increase!\n");

int n = int.Parse(Console.ReadLine()!);
string[] str = Console.ReadLine()!.Split();
long[] numArray = new long[n];

for (int i = 0; i < n; i++)
{
    numArray[i] = int.Parse(str[i]);
}
int count = 1, max = 1;
for (int j = 1; j < n; j++)
{
    if (numArray[j] > numArray[j - 1])
    {
        count++;
    }
    else
    {
        if (count > max)
            max = count;

        count = 1;
    }
}

if (count > max)
{
    max = count;
}

Console.WriteLine(max);