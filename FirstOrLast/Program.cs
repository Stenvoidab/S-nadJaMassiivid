using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm palub kasutajal sisestada ees- ja perekonnanime
            //Programm kontrollib andmete pikkust
            //programm kuvab, kumb on pikem

            Console.WriteLine("Sisesta oma eesnimi:");
            string UserFirstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string UserLastName = Console.ReadLine();

            int FirstNameLenght = UserFirstName.Length;
            int LastNameLenght = UserLastName.Length;

            if(FirstNameLenght < LastNameLenght)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi.");
            }
            else if (LastNameLenght < FirstNameLenght)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi.");
            }
            else if (LastNameLenght == FirstNameLenght)
            {
                Console.WriteLine("Sinu eesnimi ja perekonnanimi on sama pikad.");
            }

        }
    }
}
