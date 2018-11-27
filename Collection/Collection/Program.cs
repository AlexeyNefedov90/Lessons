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
            Mebel divan = new Mebel(); /////////пока ещё не доделал
            divan.name = "Диван";
            divan.width = 6;
            divan.length = 3;
            divan.height = 1;
            divan.form = "Угловой";
            divan.Information();

            Mebel stol = new Mebel();
            stol.name = "Стол ";
            stol.width = 3;
            stol.length = 4;
            stol.height = 2;
            stol.color = "Красный";
            stol.Information();

            Mebel shkaf = new Mebel();
            shkaf.name = "Шкаф ";
            shkaf.width = 5;
            shkaf.length = 2;
            shkaf.color = "Серый";
            shkaf.form = "Купе";
            shkaf.height = 6;
            shkaf.Information();

            Mebel tumba = new Mebel();
            tumba.name = "Тумба";
            tumba.color = "Белый";
            tumba.width = 4;
            tumba.length = 3;
            tumba.height = 1;
            tumba.form = "Круглая";
            tumba.Information();


            ArrayList furniture = new ArrayList() {};

            furniture.Add(divan);
            furniture.Add(stol);
            furniture.Add(shkaf);
            furniture.Add(tumba);

            Console.WriteLine(furniture);
            Console.ReadLine();

            furniture.Sort();

            Console.WriteLine(furniture);
            Console.ReadLine();

        }
    

    public interface IComparable
    {
            int CompareTo(object o);
    }


        class Mebel
    {
        public string name;
        public int width;
        public int length;
        public int height;
        public string color;
        public string form;

        public void Information()
        {
            Console.WriteLine($"Название мебели: {name} Ширина: {width} Длина: {length} Высота: {height} Цвет: {color} Форма: {form} ");
        }
    }

}
