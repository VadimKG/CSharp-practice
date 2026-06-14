double EUR;

Console.Write("Złoty: ");
double PLN = Convert.ToDouble(Console.ReadLine());

EUR = PLN / 4.25;

Console.WriteLine($"Euro: {EUR:F2}");