using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumChetChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chisla = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите {0} число", i + 1);
                chisla[i] = Int16.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (int i in chisla)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Сумма четных чисел {0}", sum);
        }
    }
}
