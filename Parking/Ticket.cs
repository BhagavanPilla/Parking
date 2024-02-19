using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Ticket:Parking
    {
        public Ticket(int twoWheelers, int fourWheelers, int heavyVehicles):base(twoWheelers,fourWheelers,heavyVehicles)
        {

        }
        public static void DisplayOccupancy()
        {
            Console.WriteLine("\n2 WheelerSlots:" + (numberOfTwoWheelerSlots - (CountOccupiedSlots(0, numberOfTwoWheelerSlots))));
            Console.WriteLine("4 WheelerSlots:" + (numberOfFourWheelerSlots - (CountOccupiedSlots(numberOfTwoWheelerSlots, numberOfTwoWheelerSlots + numberOfFourWheelerSlots))));
            Console.WriteLine("heavy vehicleSlots:"+(numberOfHeavyVehicleSlots-(CountOccupiedSlots(numberOfTwoWheelerSlots + numberOfFourWheelerSlots, occupiedSlots.Count))));
        }
    }
}
