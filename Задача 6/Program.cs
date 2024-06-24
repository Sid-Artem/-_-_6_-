using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int summi = 0;
            int summj = 0;
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)

                {

                    array[i, j] = int.Parse(Console.ReadLine());


                }
            }

            int height = array.GetLength(0);
            int width = array.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(array[i, j] + "\t");

                }
                Console.WriteLine();

            }

            var column1 = 0;
            var column2 = 0;
            var column3 = 0;
            var column4 = 0;
            var column5 = 0;
            var row1 = 0;
            var row2 = 0;
            var row3 = 0;
            var row4 = 0;
            var row5 = 0;

            var osdiogonal = 0;
            var dopdiogonal = 0;

            for (int k = 0; k < n; k++)
            {

                for (int p = 0; p < n; p++)
                {
                    Console.Write(array[k, p] + "\t");

                    if (k == p) osdiogonal += array[k, p];

                    if (k + p == n - 1) dopdiogonal += array[k, p];

                    if (k == 0) row1 += array[k, p];

                    if (k == 1) row2 += array[k, p];

                    if (k == 2) row3 += array[k, p];

                    if (k == 3) row4 += array[k, p];

                    if (k == 4) row5 += array[k, p];

                    if (p == 0) column1 += array[k, p];

                    if (p == 1) column2 += array[k, p];

                    if (p == 2) column3 += array[k, p];

                    if (p == 3) column4 += array[k, p];

                    if (p == 4) column5 += array[k, p];

                }
            }
               
            if (osdiogonal == dopdiogonal && row1==row2 && row3==row1 && row4==row1 && row5==row1 && column1==column2 && column3==column1&& column4==column1&& column5==column1&& osdiogonal==row5 && dopdiogonal==row5 && dopdiogonal==column5 && osdiogonal ==column5 )
            {
                    Console.WriteLine("Магический квадрат");

            }
            
            Console.ReadKey();


        }
    }
}