using System;

namespace ConsoleApp1
{
    internal class DataEntryExercise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("How many rooms are there in your house?");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a product's price:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("In the same line, enter your last name, age and height:");
            string[] info = Console.ReadLine().Split(' ');
            string last_name = info[0];
            int age = int.Parse(info[1]);
            double height = double.Parse(info[2]);

            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(price);
            Console.WriteLine(last_name);
            Console.WriteLine(age);
            Console.WriteLine(height);
        }
    }
}
