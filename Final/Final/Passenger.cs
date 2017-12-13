

namespace Final
{
    class Passenger
    {
        private string Name;
        private double Weight;

        public Passenger(string name, double weight)
        { Name = name; Weight = weight; }

        public string Getname()
        {  return Name;
        }
        public double Getweight()
        {return Weight;
        }

    }
}
