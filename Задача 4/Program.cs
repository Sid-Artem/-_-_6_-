﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            int summ = 0;
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 20; i+=2)
            {
               if (array[i]%2!=0 && array[i]>0) 
                {
                    summ++;
                    Console.Write("{0} ", array[i]);
                }

            }
           Console.WriteLine();
           Console.Write($"Количество нечетных положительных чисел стоящих на нечетных местах равно {summ}");
           Console.ReadKey();

        }
    }
}
