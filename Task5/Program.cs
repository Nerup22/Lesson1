using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Описание
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организуйте в центре экрана
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
            #endregion

            #region Решение
            var a = ("Меня зовут: Роман");
            Console.WriteLine("{0,50}", a);
            var b = ("Моя фамилия: Масюк");
            Console.WriteLine("{0,50}", b);
            var c = ("Я живу: в Калуге");
            Console.WriteLine("{0,50}", c);
            Console.ReadKey();
            #endregion
        }
    }
}
