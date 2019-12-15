using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class TaskN5
    {
        private static double secondDerivative(double x)
        {
            return 12 * Math.Pow(x, 2) - 84 * x + 120;
        }

        private static void examineRange(int left, int right)
        {
            Random rnd = new Random();
            int randomX = rnd.Next(left, right + 1);//Берем рандомное значение в пределах данной границы

            if (secondDerivative(randomX) > 0)
            {
                Console.WriteLine("Функция вогнута");
            }
            else
            {
                Console.WriteLine("Функция выпукла");
            }
        }

        public static void getInfo()
        {
            Console.WriteLine("Исследование точек перегиба");
            Console.WriteLine("Функция f(x)=x4-14x3+60x2-70x:");
            //Интервал, корни уравнения f''(x) = 0
            int x1 = 2;
            int x2 = 5;

            Console.WriteLine("В интервале от -Infinity : " + x1);
            examineRange(int.MinValue, 2);
            Console.WriteLine("В интервале от " + x1 + " до " + x2);
            examineRange(2, 5);
            Console.WriteLine("В интервале от " + x2 + " : +Infinity");
            examineRange(5, int.MaxValue - 1);

        }
    }
}
