// See https://aka.ms/new-console-template for more information
Console.WriteLine("1807b Grab the Candies!\n");

int t = int.Parse(Console.ReadLine()!);
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] numArr = new int[n];
    string[] str = Console.ReadLine()!.Split();

    for (int j = 0; j < n; j++)
    {
        numArr[j] = int.Parse(str[j]);
    }

    int sumEven = 0, sumOdd = 0;

    for (int k = 0; k < n; k++)
    {
        if (numArr[k] % 2 == 0)
        {
            sumEven += numArr[k];
        }
        else
        {
            sumOdd += numArr[k];
        }
    }

    Console.WriteLine(sumEven > sumOdd ? "YES" : "NO");
}
