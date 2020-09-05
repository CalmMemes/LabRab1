using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr_One
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 35, f = 5, x = 4, y = 3;
            int Z;
            Z = a/f + y * f - (f+y)/x;

            Console.WriteLine("Лабораторная работа №1. Разработка консольного приложения");
            Console.WriteLine("Сухарев Роман Олегович");
            Console.WriteLine("ИНС-192");
            Console.WriteLine("04.09.01");
            Console.WriteLine("г.Ставрополь ул.50 лет ВЛКСМ дом 81/1");
            Console.WriteLine("Информатика");
            Console.WriteLine("Делать игры :)");

            Console.WriteLine("Решим уравнение №6");
            Console.WriteLine("Z = a/f + y * f - (f+y)/x");
            Console.WriteLine("Перменная a = {0}", a);
            Console.WriteLine("Переменная x = {0}", x);
            Console.WriteLine("Переменная y = {0}", y);
            Console.WriteLine("Переменная f = {0}", f);
            Console.WriteLine("Ответ Z = {0}", Z);

            Console.ReadKey();
        }
    }
}
