namespace LogicalOperators
{
    internal class LogicalOperators
    {
        static void Main(string[] args)
        {
            // &&: 'and' both expressions have to be True
            // ||: 'or' at least one of the expressions have to be True
            // !: 'not' it denies one of the expressions, if it is True it becomes False, and vice versa
            // They also have an order of precedence, so ! > && > ||

            bool c1 = 2 > 3 || 4 != 5,
                 c2 = !(2 > 3) && 4 != 5,
                 c3 = 10 < 5,
                 c4 = c1 || c2 && c3;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}
