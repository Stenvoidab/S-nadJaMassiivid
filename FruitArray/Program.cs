using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab mis puuvilja kasutaja sööb

            string[] Fruit = new string[5] { "an apple", "a banana", "a lemon", "a orange", "some grapes" };

            //Console.WriteLine("Enter a number from 0 to 4:");

            Random rnd = new Random();
            int Usernumber = rnd.Next(0,Fruit.Length);

         
            Console.WriteLine($"Today you will have {Fruit[Usernumber]}");

        }
    }
}
