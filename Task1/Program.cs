using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя кота:");
            string nameCat = Console.ReadLine();
            Cat cat = new Cat(nameCat);
            cat.ShowInfo();
            Console.WriteLine("Введите имя собаки:");
            string nameDog = Console.ReadLine();
            Dog dog = new Dog(nameDog);
            cat.ShowInfo();
            Console.ReadKey();

        }
    }
}
