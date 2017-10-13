using System;

namespace ConsoleApp1
{
    public static class MessageGenerator
    {
        public static string GreetPerson(string name)
        {
            return $"Hello {name}";
        }
    }
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine(MessageGenerator.GreetPerson("World"));
        }
    }
}
