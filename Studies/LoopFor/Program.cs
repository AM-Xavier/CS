namespace LoopFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many integers will you enter? ");
            int numbers = int.Parse(Console.ReadLine()),
                sum = 0;

            for (int n = 1; n <= numbers; n++)
            {
                Console.Write($"Value #{n}: ");
                int value = int.Parse(Console.ReadLine());
                sum += value;
            }

            Console.WriteLine($"Sum = {sum}");
        }
    }
}
