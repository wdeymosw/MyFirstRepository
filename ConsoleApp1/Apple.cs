using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Apple : Product
    {
          public Apple (string name, int calorie, int volume)
            : base (name, calorie, volume)
        {

        }

        public static Apple add(Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Calorie + apple2.Calorie) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);

            return apple;
        }
    }
}
