int size = 5;

for(int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}