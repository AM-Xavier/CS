namespace OddNumber
{
    internal class OddNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            
            for (int n = 1; n <= x; n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }
            }

            
        }
    }
}
