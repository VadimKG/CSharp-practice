using System;

namespace MemoryExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BEFORE CALLING METHODS ---");
            int number = 10;
            Console.WriteLine($"Number: {number}");
            int[] array = { 10, 20, 30 };
            Console.WriteLine($"First array element: {array[0]}\n");

            ModifyNumber(number);
            ModifyArray(array);
            
            Console.Write("--- AFTER CALLING METHODS ---");
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"First array element: {array[0]}");
        }   

        static void ModifyNumber(int number)
        {
            number = 99;
        }

        static void ModifyArray(int[] array) //array_2
        {
            array[0] = 99; //array_2
        }
    }
}