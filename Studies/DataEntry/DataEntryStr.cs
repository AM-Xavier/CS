using System;

namespace DataEntry
{
    class DataEntryStr
    {
        static void Main(string[] args)
        {
            // Data entry with strings
            string prompt = Console.ReadLine();

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string w = Console.ReadLine();

            // Splitting the input string into parts based on spaces

            string[] v = w.Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Your entry was: ");
            Console.WriteLine(prompt);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // Another way of splitting the input
            string[] d = Console.ReadLine().Split(' ');
            string e = d[0];
            string f = d[1];
            string g = d[2];
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}


