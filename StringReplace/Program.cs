using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses 'hello world!' tärniga.

            string hellow = "Hello World!";

            
            
            hellow = hellow.Replace('o', '*');
            
            Console.WriteLine(hellow);
        }
    }
}
