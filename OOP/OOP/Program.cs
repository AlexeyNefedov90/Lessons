using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{   
    class Program
    {
        static void Main(string[] args)
        {
            Mebel divan = new Mebel();
            divan.name = "Диван";
            divan.width = 6;
            divan.length = 3;
            divan.height = 1;
            divan.form = "Угловой";
            divan.Information();

            Console.ReadKey();

            Mebel stol = new Mebel();
            stol.name = "Стул";
            stol.color = "Красный";
            stol.width = 3;
            stol.length = 4;
            stol.height = 2;
            stol.Information();

            Console.ReadKey();

        }
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

    class Delivery : ILoading
    {
        public void Load()
        {
            Console.WriteLine("Доставленно 15 диванов на фабрику");
        }
    }
    class Assembly : IShipment
    {
        public void Ship()
        {
            Console.WriteLine("Отгруженно 6 столов заказчику");
        }
    }






















}   




