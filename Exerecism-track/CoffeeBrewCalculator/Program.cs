Console.Write("Water: ");
double water = Convert.ToDouble(Console.ReadLine());

Console.Write("pours: ");
int pours = Convert.ToInt32(Console.ReadLine());

double addWater = water / pours;
double result = 0;
for (int i = 1; i <= pours; i++)
{
    result += addWater;
    Console.WriteLine($"Pour {i}: scales should show {result:F1} ml.");
}