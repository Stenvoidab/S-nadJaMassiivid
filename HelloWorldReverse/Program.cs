using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lause 'Hello World!' tagurpidi

            string hello = "Hello World!";

            for(int i = hello.Length-1;i >= 0; i--)
            {
                Console.Write(hello[i]);
            }
        }
    }
}
