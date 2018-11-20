using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
     public class Program
    {
        static void Main()
        {
            Calculation();
            Retry();
        }
        static void Calculation()
        {
            int result;

            Console.WriteLine("Выбрать операцию: Сумма(+),Разность(-),Деление(/),Умножение(*):");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ввести первое число:");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ввести второе число:");
            int b = Convert.ToInt16(Console.ReadLine());

            if (operation == '+')
            {
                result = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + result + ".");
            }

            else if (operation == '-')
            {
                result = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + result + ".");
            }

            else if (operation == '*')
            {
                result = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + result + ".");
            }

            else if (operation == '/')
            {
                result = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + result + ".");
            }
            else
            { Console.WriteLine("Неизвестный оператор."); }

        }
        static void Retry()
        {

            Console.WriteLine("Вы хотите продолжить работу с калькулятором? (Д/Н)");
            int repeat = Convert.ToChar(Console.ReadLine());

            do
            {
                Calculation();
            }
            while (repeat == 'Д');
        }
    }
 }
