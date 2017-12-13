

namespace Final
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;
        private double AllWeights = 0;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        { Occupants[index] = passenger; }

        public double GetCurrentWeight()
        {
            for (int i = 0; i < Occupants.Length; i++)
            { AllWeights += Occupants[i].Getweight(); }
            return AllWeights;
        }
        public bool IsOverMaxcapaicty()
        {
            if (MaxWeight < GetCurrentWeight()) { return true; }
            else { return false; }
        }
    }
}

