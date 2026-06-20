int originalNumber = 12345;
int reversedNumber = 0;

while (originalNumber > 0)
{
    int lastDigit = originalNumber % 10;
    reversedNumber = (reversedNumber * 10) + lastDigit;
    originalNumber = originalNumber / 10;
}
    Console.WriteLine(reversedNumber);