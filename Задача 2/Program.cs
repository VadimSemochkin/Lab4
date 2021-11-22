using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int sumPositive = 0;
            int sumNegative = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n>0)
                {
                    sumPositive++;
                }
                else
                {
                    if (n == 0)
                        continue;
                    sumNegative++;
                }
            } while (n!=0);
            if (sumPositive>sumNegative)
            {
                Console.WriteLine("Положительных чисел больше и равно {0}", sumPositive);
            }
            else
            {
                if (sumPositive==sumNegative)
                {
                    Console.WriteLine("Количество положительных и отрицательных чисел одинаково и равно {0}", sumNegative);
                }
                else
                {
                    Console.WriteLine("Количество отрицательных чисел больше и равно {0}",sumNegative);
                }
            }

            Console.ReadKey();
        }
    }
}
