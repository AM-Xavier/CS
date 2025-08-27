namespace ConditionalStatements
{
    internal class ConditionalStatements
    {
        static void Main(string[] args)
        {
            // if, else and else if

            int x = 24;

            if (x < 12)
            {
                Console.WriteLine("Good morning!");
            }

            else if (x < 18)
            {
                Console.WriteLine("Good afternoon!");
            }

            else
            {
                Console.WriteLine("Good night!");
            }

            Console.WriteLine("Enter an integer:");
            int z = int.Parse(Console.ReadLine());

            if (z % 2 == 0) 
            {
                Console.WriteLine("The number you entered is even.");
            }

            else 
            { 
                Console.WriteLine("The number you entered is odd."); 
            }
        }
    }
}
