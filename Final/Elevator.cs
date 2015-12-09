using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamDavis_Final_Exam
{
    class Elevator
    {
        private double MaxWeight;
        private int MaxOccupants;
        private Passenger[] Occupants;
        public int totalWeight = 0;

        public Elevator ( double MaxWeight, int MaxOccupants)
        {
            this.MaxWeight = MaxWeight;
            Occupants = new Passenger[MaxOccupants];

        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetcurrentWeight()
        {
            return totalWeight += passenger.weight(); 

        }

       




    }
}
