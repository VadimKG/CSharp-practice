using System.Globalization;

int[] expenses = { 150, 50, 120, 0, 85};
int total = 0;

for (int i = 0; i < expenses.Length; i++)
{
    Console.WriteLine($"Day {i + 1} expense: {expenses[i]} PLN");
    total += expenses[i];
}
Console.WriteLine("-------------------");
Console.WriteLine($"Total expenses for 5 days: {total} PLN");