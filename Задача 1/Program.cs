using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int j=0;
            double sum = 0;
            for (int i = 0; i < 7; i++)
            {
                j = int.Parse(Console.ReadLine());
                array[i] = j;
                sum += j;
                
            }
            Console.WriteLine ($"Cредние арифмитическое равно  {sum/7}");
            Console.ReadKey();  

        }
    }
}
