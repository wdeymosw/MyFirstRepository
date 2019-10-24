using System;

namespace ConsoleApp1
{
    
    
    class Program
    {
        
        
        static void Main()
        {
            Apple apple = new Apple("Красное яблоко", 100, 100);
            Apple apple2 = new Apple("Красное яблоко", 90, 100);
            var sumApple = Apple.add(apple, apple2);

            Console.WriteLine("Хело ворда!!!");
            Console.ReadLine();
            Console.WriteLine("Еще одна строка изменение 2");
            Console.ReadLine();

        }

       
    }
}
