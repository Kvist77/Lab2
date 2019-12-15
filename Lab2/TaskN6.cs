using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab2
{
    class TaskN6
    {
        private static double A;
        private static double B;
        private static double C;
        private static Point points;
        static Dictionary<string, double> firstDerivative = new Dictionary<string,double>();

        public static void Task6(double dxdy, double dxx, double dyy, Point point)
        {
            firstDerivative.Add("dxdy", dxdy);
            firstDerivative.Add("dxx", dxx);
            firstDerivative.Add("dyy", dyy);
            points = point;
            getABC();
        }
        private static void getABC()
        {
            B = firstDerivative["dxdy"];
            A = firstDerivative["dxx"];
            C = firstDerivative["dyy"];
        }

        public static void getConclusionAboutThePresenceOfExtremes()
        {
            if (A * C - Math.Pow(B, 2) > 0 && A < 0)
                Console.WriteLine("в точке M(" + points.getX() + "," + points.getY() + ") имеется максимум");
        else if (A * C - Math.Pow(B, 2) > 0 && A > 0)
                Console.WriteLine("в точке M(" + points.getX() + "," + points.getY() + ") имеется минимум");
        else if (A * C - Math.Pow(B, 2) < 0)
                Console.WriteLine("в точке M(" + points.getX() + "," + points.getY() + ") экстемума нет");
        else if (A * C - Math.Pow(B, 2) == 0)
                Console.WriteLine("Вопрос о наличии экстремума остается открытым");
        }
    }
}
