// See https://aka.ms/new-console-template for more information
Console.WriteLine("935A Fafa and his Company!\n");


int n = int.Parse(Console.ReadLine()!);

int count = 1;

for (int i = 2; i * i < n; i++)
{
    if (n % i == 0)
    {
        count += 2;
    }
}

if (Math.Sqrt(n) == (int)Math.Sqrt(n))
{
    count++;
}


Console.WriteLine(count);