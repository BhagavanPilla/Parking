using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Parking:ParkingLot
    {
        public Parking(int twoWheelers,int fourWheelers,int heavyVehicles):base(twoWheelers, fourWheelers, heavyVehicles)
        {

        }
        public static void ParkVehicle(string vehicleNumber,int vehicleType)
        {
            int startSlot = 0;
            switch(vehicleType)
            {
                case 2:
                    startSlot = 0;
                    break;
                case 4:
                    startSlot = numberOfTwoWheelerSlots;
                    break;
                case 6:
                    startSlot = numberOfTwoWheelerSlots +numberOfFourWheelerSlots;
                    break;
                default:
                    Console.WriteLine("Enter valid vehicle type");
                    return;
                    //break;
            }
            int slot = FindAvailableSlots(startSlot, startSlot + GetSlotsForVehicle(vehicleType));

            if(slot != -1)
            {
                occupiedSlots[slot] = true;
                Console.WriteLine("\nTICKET");
                Console.WriteLine("VEHICLE NUMBER:" + vehicleNumber);
                Console.WriteLine("SLOT:" + (slot+1));
                Console.WriteLine("In Time:"+DateTime.Now);
            }
            else
            {
                Console.WriteLine("\nNo Availble Slots for " + vehicleType + "Wheelers");
            }
        }
        
        public static int CountOccupiedSlots(int start,int end)
        {
            int count = 0;
            for(int i = start; i < end; i++)
            {
                if (occupiedSlots[i])
                    count++;
            }
            return count;
        }
    }
}
