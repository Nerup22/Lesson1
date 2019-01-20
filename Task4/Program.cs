using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Описание
            //Написать программу обмена значениями двух переменных.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.
            #endregion

            #region Решение
            Console.Write("Введите число a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Int32.Parse(Console.ReadLine());
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
            Console.WriteLine($"Первое число равно: {a}");
            Console.WriteLine($"Второе число равно: {b}");
            Console.ReadKey();
            #endregion
        }
    }
}
