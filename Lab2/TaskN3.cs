using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class TaskN3
    {
        public static void isMinInCurrentPoint(double x)
        {
            double a = firstProizv(x);
            if (a == 0 || double.IsInfinity(a) || double.IsNaN(a))
            {
                Console.WriteLine("Точка " + x + " является экстремумом");

                if (secondProizv(x) > 0)
                    Console.WriteLine("Точка " + x + " является максимумом");
                else
                    Console.WriteLine("Точка " + x + " является минимумом");
            }
            else
            {
                Console.WriteLine("Точка " + x + " не является экстремумом");
            }
            if (double.IsInfinity(a))
            {
                Console.WriteLine("Значение f'(x) при x= " + x + " Равно: infinity");
            }
            else
            {
                Console.WriteLine("Значение f'(x) при x= " + x + " Равно: " + a);
            }
        }
       

        private static double secondProizv(double x)
        {
            return -(2d / (9 * Math.Pow(x, 4d / 3d)));
        }

        private static double firstProizv(double x)
        {
            return 2d / (3d * Math.Pow(x, 1d / 3d));
        }
        private static double function(double x)
        {
            return Math.Pow(x, 2d / 3d) - 1;
        }
    }
}
