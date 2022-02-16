using System;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Logger.GetInstance();
            Starter.Run();
        }
    }
}
