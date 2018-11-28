using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Сколько строк будет в первом массиве?");

            int a = Convert.ToInt16(Console.ReadLine());

            Console.Write("Сколько столбцов будет в первом массиве?");

            int b = Convert.ToInt16(Console.ReadLine());

            int[,] first = new int[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("Введите {0},{1} элемент первого массива ", i + 1, j + 1);

                    first[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < b; j++)

                    Console.Write("{0} ", first[i, j]);

            }

            Console.ReadKey();



            Console.WriteLine();

            Console.Write("Сколько строк будет во втором массиве?");

            int x = Convert.ToInt16(Console.ReadLine());

            Console.Write("Сколько столбцов будет во втором массиве?");

            int y = Convert.ToInt16(Console.ReadLine());

            int[,] second = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("Введите {0},{1} элемент  второго массива ", i + 1, j + 1);

                    second[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < y; j++)

                    Console.Write("{0} ", second[i, j]);

            }

            Console.ReadKey();

            int[,] sum =  first.Concat(second).ToArray();

            Console.ReadKey();
        }
    }
}
