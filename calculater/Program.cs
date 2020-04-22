using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total = 0;
            char oper;

            Console.Write("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите один из операторов (+ - / *):");
            oper = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("{0}{1}{2}{3}{4}", a, oper, b, "=", total);
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("{0}{1}{2}{3}{4}", a, oper, b, "=", total);
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("{0}{1}{2}{3}{4}", a, oper, b, "=", total);
            }

            else if (oper == '/')
            {
                if (b != 0)
                    total = a / b;
                else Console.WriteLine("Ошибка: на ноль делить нельзя!");
            }
            else
            {
                Console.WriteLine("Ошибка: неизвестный оператор.");
            }


            Console.ReadLine();
        }
    }
}
