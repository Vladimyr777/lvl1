using System;

namespace ConsoleApp0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как тебя зовут? ") ;
            var name = Console.ReadLine() ;
            Console.WriteLine($"Сегодня [{DateTime.Now}] , приветсвую {name}");
        }
    }
}