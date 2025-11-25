using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_2
{
    //-----------//
    abstract class Transport
    {
        public string Name_transpotr { get; set; }
        public int Speed_transport { get; set; }

        public Transport(string name_t, int speed_t)
        {
            Name_transpotr = name_t;
            Speed_transport = speed_t;  
        }
        public abstract void Travel();

    }

    class Car : Transport
    {
        public string Type_car { get; set; }

        public Car(string name_t, string type_c, int speed_t)
            : base(name_t, speed_t)
        {
            Type_car = type_c;
        }

        public override void Travel()
        {
            Console.WriteLine("{0} {1} едет со скоростью {2} км/ч ", Name_transpotr, Type_car, Speed_transport);
        }
    }

    class Train : Transport
    {
        public int Size_people { get; set; }

        public Train(string name_t, int speed_t, int size_p)
            : base(name_t, speed_t)
        {
            Size_people = size_p;
        }
        public override void Travel()
        {
            Console.WriteLine("{0} едет со скоростью {1} км/ч c {2}" + " занятыми местами ", Name_transpotr, Speed_transport, Size_people );
        }
    }
    class Exspress : Train
    {
        public int Premium_place {get; set; }
        public Exspress(string name_t, int speed_t, int size_p, int premium_p) 
            : base(name_t, speed_t, size_p)
        {
            Premium_place = premium_p;
        }

        public override void Travel()
        {
            Console.WriteLine("{0} едет со скоростью {1} км/ч c {2} занятыми местами," +
                " из них которые {3} - премиум места. ",Name_transpotr, Speed_transport, Size_people, Premium_place);
        }
    }
}
