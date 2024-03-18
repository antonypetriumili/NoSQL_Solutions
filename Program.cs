using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine("Виконав: Терещенко Богдан, ІС-03");
                double a, x, x1;
                Console.WriteLine("Введіть значення а");
                while ((!double.TryParse(Console.ReadLine(), out a) | (a <= 0)))
                {
                    Console.WriteLine("Помилка вводу, елемент а має бути числовим значенням більше 0");
                }
                if (a <= 1)
                {
                    x = Math.Min(2 * a, 0.95);
                }
                if ((a > 1) && (a < 25))
                    x = a / 5;
                else
                {
                    x = a / 25;
                }
                x1 = (double)4 / 5 * x + a / 5 * Math.Pow(x, 4);
                Console.WriteLine("x0 = " + x);
                int n = 0;
                do
                {
                    n += 1;
                    x = 4.0 / 5 * x + a / (5 * Math.Pow(x, 4));
                    x1 = 4.0 / 5 * x1 + a / (5 * Math.Pow(x1, 4));
                    Console.WriteLine("x" + n + " = " + x);
                } while (((double)5 / 4 * a * Math.Abs(x1 - x)) > (Math.Pow(10, -6)));
                double difference = (double)a - Math.Pow(x, 5);
                Console.WriteLine("Виведення різниці - " + difference);
            Console.ReadLine();

        }
    }
}
