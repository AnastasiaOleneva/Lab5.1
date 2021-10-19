using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0} :\t", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            double arithmetic_mean = (array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6]) / array.Length;
            Console.WriteLine("Среднее арифметическое значение массива= {0}", arithmetic_mean);
            Console.ReadKey();
        }
    }
}
