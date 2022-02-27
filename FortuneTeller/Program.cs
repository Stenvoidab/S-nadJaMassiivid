using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm ennustab mis kasutaja homme(kasutame randomit)

            string[] predictions = new string[5] { "win a million", "lose your job", "fall in love", "buy Youtube premium", "join the dark side" };

            Random rnd = new Random();
            int Usernumber = rnd.Next(0, predictions.Length);



            Console.WriteLine($"Tomorrow you will {predictions[Usernumber]} !");

        }
    }
}
