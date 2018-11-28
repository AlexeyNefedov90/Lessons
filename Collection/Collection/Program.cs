using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Mebel> furniture = new List<Mebel>()
            {
                new Mebel { Name = "Шкаф", Width = 3, Height = 2, Length = 3, Color = "Зеленый" },
                new Mebel { Name = "Кровать", Width = 1, Height = 3, Length = 2, Color = "Синий" },
                new Mebel { Name = "Кресло", Width = 4, Height = 2, Length = 1, Color = "Красный" },
                new Mebel { Name = "Стул", Width = 5, Height = 3, Length = 4, Color = "Белый" },
                new Mebel { Name = "Стол", Width = 3, Height = 4, Length = 5, Color = "Черный" },
                new Mebel { Name = "Тумба", Width = 2, Height = 5, Length = 3, Color = "Серый" }
            };



            Console.WriteLine(furniture);
            Console.ReadKey();

            var sortedFur = from f in furniture //Отсортируем по убыванию имени мебели
                              orderby f.Name descending
                              select f;

            foreach (Mebel f in sortedFur)
                Console.WriteLine(f.Name);
                Console.ReadKey();

            Console.WriteLine();


            var sortedFurn = from f in furniture //Отсортируем по возрастанию цвета
                            orderby f.Color ascending
                             select f;

            foreach (Mebel f in sortedFurn)
                Console.WriteLine(f.Color);
                Console.ReadKey();


        }
    }
    public class Mebel
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public string Color { get; set; }
    }
}