using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class TaskN7andN8
    {
        private int D1;
        private int D2;
        private int D3;

        public void Task7and8(int[][] hessMatrix)
        {
            this.hessMatrix = hessMatrix;
        }

        private int[][] hessMatrix;

        private void calculateDiagonalMinors()
        {
            D1 = hessMatrix[0][0];
            D2 = hessMatrix[0][0] * hessMatrix[1][1] - hessMatrix[0][1] * hessMatrix[1][0];
            D3 = hessMatrix[0][0] * hessMatrix[1][1] * hessMatrix[2][2] - hessMatrix[0][2] * hessMatrix[1][1] * hessMatrix[2][0];
        }

        public void getConclusionAboutThePresenceOfExtremes()
        {
            Console.WriteLine("Диагональные миноры:");
            calculateDiagonalMinors();
            Console.WriteLine("D1: " + D1);
            Console.WriteLine("D2: " + D2);
            Console.WriteLine("D3: " + D3);

            // has different signs
            if ((D1 < 0 && D2 > 0 && D3 < 0) || (D1 > 0 && D2 > 0 && D3 < 0) || (D1 < 0 && D2 > 0 && D3 > 0) || (D1 < 0 && D2 < 0 && D3 > 0))
                Console.WriteLine("Поскольку диагональные миноры имеют различные знаки, то о выпуклости или вогнутости функции ничего сказать нельзя.");
            if ((D1 > 0 && D2 > 0 && D3 > 0))
                Console.WriteLine("Поскольку диагональные миноры положительны, функция выпукла");
        }

    }
}
