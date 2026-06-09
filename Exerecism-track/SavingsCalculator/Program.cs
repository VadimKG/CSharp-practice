double balance = 1000.0;
double target = 3000.0;
double percent = 0.10;
int years = 0;

while (balance < target)
{
    balance = balance + (balance * percent);
    years++;
}

Console.WriteLine($"Long-term accumulation strategy successful! Target reached in {years} years.");
Console.WriteLine($"Final index fund balance: {balance}");