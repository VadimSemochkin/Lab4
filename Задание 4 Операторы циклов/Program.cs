using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_Операторы_циклов
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(sum+=(2*i-1));
            }
            Console.ReadKey();
        }
    }
}
