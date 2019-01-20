using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Описание
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
            #endregion

            #region Решение
            Console.WriteLine("Введите x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Double r = 0;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:#.##}", r); //"{0:#.##}", сокращает до 2х знаков после запетой            
            Console.ReadKey();
            #endregion
        }
    }
}
