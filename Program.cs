using System;

namespace NumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter X = new Converter();
            Console.WriteLine(X.noConverter(162));
            Console.WriteLine(X.noConverter(121));
            Console.WriteLine(X.noConverter(620));
            Console.WriteLine(X.noConverter(900));
            Console.Read();
        }
    }
}
