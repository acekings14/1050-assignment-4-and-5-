using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamDavis_Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Elevator elevator1 = new Elevator(2, 400);
            Passenger A1 = new Passenger("A1", 180);
            elevator1.AddOccupant(A1 , 0);
            Passenger A2 = new Passenger("A2", 220);
            elevator1.AddOccupant(A2, 1);

            Elevator elevator2 = new Elevator(3, 600);
            Passenger A1 = new Passenger("A1", 200);
            elevator1.AddOccupant(A1, 0);
            Passenger A3 = new Passenger("A3", 220);
            elevator1.AddOccupant(A2, 1); Passenger A3 = new Passenger("A3", 201);
            elevator2.AddOccupant(A3 , 2);
            



        }
    }
}
