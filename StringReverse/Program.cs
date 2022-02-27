using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutaja eesnime tagurpidi

            Console.WriteLine("Sisesta oma eesnimi:");
            string FirstName = Console.ReadLine();

            for(int i = FirstName.Length-1; i >= 0; i--)
            {
                Console.Write(FirstName[i]);
            }
        }
    }
}
