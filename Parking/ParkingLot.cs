using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class ParkingLot
    {
        public static int numberOfTwoWheelerSlots;
        public static int numberOfFourWheelerSlots;
        public static int numberOfHeavyVehicleSlots;
        public static List<bool> occupiedSlots;
        

        public ParkingLot(int twowheelers,int fourWheelers,int heavyVehicle)
        {
            numberOfTwoWheelerSlots = twowheelers;
            numberOfFourWheelerSlots = fourWheelers;
            numberOfHeavyVehicleSlots = heavyVehicle;

            int totalSlots=numberOfTwoWheelerSlots+numberOfFourWheelerSlots+numberOfHeavyVehicleSlots;
            occupiedSlots = new List<bool>(new bool[totalSlots]);
        }

        public static int FindAvailableSlots(int start,int end)
        {
            for(int i= start; i < end; i++)
            {
                if (!occupiedSlots[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static int GetSlotsForVehicle(int vehicleType)
        {
            switch (vehicleType)
            {
                case 2:
                    return numberOfTwoWheelerSlots;
                case 4:
                    return numberOfFourWheelerSlots;
                case 6:
                    return numberOfTwoWheelerSlots;
                default:
                    return 0;
            }
        }
    }
}
