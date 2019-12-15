using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задания(3-8)");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 3:
                    TaskN3.isMinInCurrentPoint(0);
                    break;
                case 4:
                    TaskN4.Algorit(1);
                    break;
                case 5:
                    TaskN5.getInfo();
                    break;
                case 6:
                    Point M = new Point(0, 0);
                    TaskN6.Task6(4d, 2d, 10d, M);
                    TaskN6.getConclusionAboutThePresenceOfExtremes();
                    break;
                case 7:
                    int[][] hessMatrix1 = new int[3][];
                    hessMatrix1[0] = new int[3] { -2, 2, 0 };
                    hessMatrix1[1] = new int[3] { 2, -12, 20 };
                    hessMatrix1[2] = new int[3] { 0, 20, -46 };
                    TaskN7andN8 task7 = new TaskN7andN8();
                    task7.Task7and8(hessMatrix1);
                    task7.getConclusionAboutThePresenceOfExtremes();
                    break;
                case 8:
                    int[][] hessMatrix2 = new int[3][];
                    hessMatrix2[0] = new int[3] { 2, 0, 0 };
                    hessMatrix2[1] = new int[3] { 0, 2, 0 };
                    hessMatrix2[2] = new int[3] { 0, 0, 2 };
                    TaskN7andN8 task8 = new TaskN7andN8();
                    task8.Task7and8(hessMatrix2);
                    task8.getConclusionAboutThePresenceOfExtremes();
                    break;

            }
            Console.ReadKey();
            
        }

       
    }
}
