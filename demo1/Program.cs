using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] airgs)
        {
            loop();
            Console.WriteLine("Hello World!");
        }
        public static void loop()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0}", i);

            }

        }


    }

}
