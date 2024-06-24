using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность");
            int n=int.Parse(Console.ReadLine());
            int[,] array = new int[n,n];
            for(int i = 0; i < n; i++)
            {
                

                for (int j = 0; j < n; j++)
                {

                    
                    array[i,j] = ((j==i)) || (i+j==n-1)|| (j-i==2)||(i-j==2)?1:0;
                    


                    Console.Write("{0} ",array[i,j]);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
