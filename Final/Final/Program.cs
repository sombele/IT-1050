﻿

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            elevator1.AddOccupant((new Passenger("A1", 180)), 0);
            elevator1.AddOccupant((new Passenger("A2", 220)), 1);
            bool elavator1IsOverMaxCapacity = elevator1.IsOverMaxcapaicty();

            Elevator elevator2 = new Elevator(3, 600);
            elevator2.AddOccupant((new Passenger("A1", 200)), 0);
            elevator2.AddOccupant((new Passenger("A2", 200)), 1);
            elevator2.AddOccupant((new Passenger("A3", 201)), 2);
            bool elavator2IsOverMaxCapacity = elevator2.IsOverMaxcapaicty();

        }
    }
}
