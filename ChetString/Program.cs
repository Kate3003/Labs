using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите {0} число", i);
                arr[i] = Int16.Parse(Console.ReadLine());
            }
            String s = "";
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    s += " " + i;
                }
            }
            Console.WriteLine("String {0}", s);
        }
    }
}
