string message = "Hello everyone, welcome to the matrix";
int count_e = 0;
char e = 'e';
for (int i = 0; i < message.Length; i++)
{
    if (message[i] == 'e')
    {
        count_e++;
    }        
}

Console.WriteLine($"The letter 'e' appears {count_e} times");