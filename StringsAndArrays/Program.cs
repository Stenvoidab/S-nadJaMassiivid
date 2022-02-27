using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konsool küsib kasutaja eesnime
            //programm kuvab kasutaja eesnime pikkuse

            Console.WriteLine("Sisesta oma eesnimi:");
            string FirstName = Console.ReadLine();

            int FirstNameLenght = FirstName.Length;
            Console.WriteLine($"Sinu eesnimes on {FirstNameLenght} sümbolit ");
        }
    }
}
