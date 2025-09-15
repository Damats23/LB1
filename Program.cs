using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car("Машина", "Kia Rio", 50);
            Train train = new Train("Скоростной поезд 'Ласточка'", 100, 500);
            Exspress exs = new Exspress("Поезд 'Москва-Краснодар'", 200, 1500, 55);

            auto.Travel();
            train.Travel();
            exs.Travel();
            Console.Read();

        }
    }
}
