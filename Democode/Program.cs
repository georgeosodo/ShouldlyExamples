using System;


namespace Democode
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.AddInts(1,2);            
            Console.WriteLine(calc.AddInts(1, 2));
        }
    }
}
