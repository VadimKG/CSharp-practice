using System;
using System.Collections.Generic; 

namespace ToDoListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            Console.WriteLine("--- OLD TO DO LIST ---");
            tasks.Add("Buy a cup of coffee");
            tasks.Add("Learn C#");
            tasks.Add("Drive a car");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }

            tasks.Remove("Buy a cup of coffee");
            tasks.Insert(0, "Learn List");

            Console.WriteLine("\n--- NEW TO DO LIST ---");
            for (int j = 0; j < tasks.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {tasks[j]}");
            }
        }
    }
}