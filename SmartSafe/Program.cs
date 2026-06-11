int Pin = 1234;
int attempts = 0;
int inputPin = 1234;

do
{
    attempts++;

    if (attempts > 4)
    {
        Console.WriteLine("Alert! Safe locked");
        break;
    }
    if (Pin == inputPin)
    {
        Console.WriteLine("The safe is open");
        break;
    }
    if (Pin != inputPin)
    {
        Console.WriteLine("Incorrect PIN");
        continue;
    }
}

while (true);