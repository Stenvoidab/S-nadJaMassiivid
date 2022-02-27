using System;

namespace HOLCounter
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu H,O ja L tähte on lauses 'hello world'

            string HelloWorld = "Hello World!".ToLower();

            int HCounter = 0;
            int OCounter = 0;
            int LCounter = 0;


            for (int i = 0;i < HelloWorld.Length; i++) 
            {
                if(HelloWorld[i] == 'h')
                {
                    HCounter++;
                }
                if(HelloWorld[i] == 'o')
                {
                    OCounter++;
                }
                if(HelloWorld[i] == 'l')
                { 
                    LCounter++;
                }
            }
            Console.WriteLine($"Lauses 'Hello World!' on {HCounter} 'h' tähte, {OCounter} 'o' tähte ja {LCounter} 'l' tähte.");



        }
    }
}
