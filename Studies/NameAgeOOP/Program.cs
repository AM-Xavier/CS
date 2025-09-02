namespace NameAgeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("First person data:");
            Console.Write("First name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("First person data:");
            Console.Write("First name: ");
            p2.Name = Console.ReadLine();
            Console.Write("Age: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age)
            {
                Console.WriteLine($"The oldest person is {p1.Name}");
            }

            else
            {
                Console.WriteLine($"The oldest person is {p2.Name}");
            }

        }
    }
}
