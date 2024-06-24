using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            int summ = 0;
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(1, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
                
            }
            Console.WriteLine(max);
            int min = array[0];
            foreach (int b in array)
            {
                if (b < min)
                    min = b;
            }
            Console.WriteLine(min);
            summ =max+min;
            Console.WriteLine($"Сумма наибольшего и наименьшего элемента массива равна {summ}");
            Console.ReadKey();

        }
    }
}
