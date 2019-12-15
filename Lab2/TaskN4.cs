using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class TaskN4
    {



        public static void Algorit(double z)
        {
            double x, fxproizv, D, e = 0.0001, fx;
            do
            {
                x = z;
                fxproizv = Math.Exp(-x) * Math.Sin(x / 2d) - ((Math.Exp(-x) * Math.Cos(x / 2)) / 2d);
                D = ((((-5 * Math.Sin(x / 2d)) / 4) + Math.Cos(x / 2d)) * Math.Exp(-x));
                z = x - fxproizv / D;
                Console.WriteLine("Z = {0} и X = {1}", z, x);

            }
            while (Math.Abs(z - x) > e);

            x = z;
            fxproizv = Math.Exp(-x) * Math.Sin(x / 2d) - ((Math.Exp(-x) * Math.Cos(x / 2)) / 2d);
            D = ((((-5 * Math.Sin(x / 2d)) / 4) + Math.Cos(x / 2d)) * Math.Exp(-x));
            fx = -Math.Exp(-x) * ((Math.Exp(x / 2) - Math.Exp(-x / 2)) / 2);
            if (D > 0)
            {
                Console.WriteLine("Минимум равен {0} в точке {1}", fx, x);
                return;
            }
            else if (D < 0)
            {
                Console.WriteLine("Максимум равен {0} в точке {1}", fx, x);
                return;
            }
        }
    }
}

