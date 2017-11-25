using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "4 4 2 - +";
            Parser p = new Parser(expression);
            Console.WriteLine("'" + expression + "' equals " + p.evaluate());
            Console.ReadKey();
        }
    }
}
