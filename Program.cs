using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Описание
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах
            #endregion

            #region Решение
            Console.Write("Введите Ваш вес:");
            int m = Int32.Parse(Console.ReadLine());          
            Console.Write("Введите Ваш рост:"); //исходил от того, что многие в сантиметрах называют 
            int a = Int32.Parse(Console.ReadLine());
            double h = a / 100d;
            double i = m / (h * h);       
            Console.WriteLine($"Ваш индекс массы тела: {i}");
            Console.ReadKey();
            #endregion
        }
    }
}
