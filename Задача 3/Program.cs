using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника");
            int A = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Введите ширину прямоугольника");
            int B = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Введите сторону квадрата");
            int C = Convert.ToInt32(Console.ReadLine()); ;
            int n = 0;
            int k = 0;
            int N = 0;
            while (A >= C)
            {
                A -= C;
                n++;
            }
            while (B >= C)
            {
                B -= C;
                k++;
            }
            for (int i = 0; i < n; i++)
                N += k;
            Console.WriteLine("Количество квадратов, размещенных внутри прямоугольника равно {0}", N);
            Console.ReadKey();
        }
    }
}
