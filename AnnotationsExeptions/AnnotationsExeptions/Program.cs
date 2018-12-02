using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsExeptions
{
    class Program
    {
        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Field)]
        public class UInfoAttribute : Attribute
        {
            public string Desc;
            public UInfoAttribute() { }
            public UInfoAttribute(string str)
            {
                Desc = str;
            }
        }

        public static Logger logger = LogManager.GetCurrentClassLogger();

        [UInfo(Desc = "Главный метод программы")]

        static void Main(string[] args)
        {
            logger.Info("Приложение запущенно.");

            string result = "";
            Console.WriteLine("Введите пожалуйста число:");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                result = "Вы ввели число " + a;
            }
            catch (FormatException)
            {
                result = "Ошибка. Вы ввели не число!";
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

