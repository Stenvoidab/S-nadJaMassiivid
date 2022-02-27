using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string DontP = "Don't Panic!";

            DontP = DontP.Replace('o', '0');
            DontP = DontP.Replace('a', '4');

            Console.WriteLine(DontP);
        }
    }
}
