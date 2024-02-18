// See https://aka.ms/new-console-template for more information
Console.WriteLine("1742B Increasing!\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] arr = new int[n];
    string[] input = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        arr[j] = int.Parse(input[j]);
    }

    var keyValuePair = arr.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

    bool result = true;

    foreach (var kvp in keyValuePair)
    {
        if (kvp.Value > 1)
        {
            result = false;
            break;
        }
    }

    Console.WriteLine(result ? "YES" : "NO");
}