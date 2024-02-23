using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class ParkingLot
    {
         public int numberOfTwoWheelerSlots;
         public int numberOfFourWheelerSlots;
         public int numberOfHeavyVehicleSlots;
         public List<ParkingSlot> slot;

        public ParkingLot(int twowheelers,int fourWheelers,int heavyVehicle,List<ParkingSlot> slots)
        {
            numberOfTwoWheelerSlots = twowheelers;
            numberOfFourWheelerSlots = fourWheelers;
            numberOfHeavyVehicleSlots = heavyVehicle;
            slot = slots;
            
        }

        public List<Ticket> tickets=new List<Ticket>();

        public void AvailableSlots()
        {
            Console.WriteLine("\nParking Lot Available slots are");
            Console.WriteLine(VehicleType.twoWheeler + " : " + (numberOfTwoWheelerSlots - GetSlotsForVehicle(VehicleType.twoWheeler)));
            Console.WriteLine(VehicleType.fourWheeler + " : " + (numberOfFourWheelerSlots - GetSlotsForVehicle(VehicleType.fourWheeler)));
            Console.WriteLine(VehicleType.heavyVehicle + " : " + (numberOfHeavyVehicleSlots - GetSlotsForVehicle(VehicleType.heavyVehicle)));
        }

        public void OccupiedSlots()
        {
            foreach (var parked in slot)
            {
                if (parked.IsOccupied == true)
                {
                    Console.WriteLine(parked.VehicleType + " Slot " + parked.SlotNumber + " is Occupied by " + parked.VehicleNumber);
                }
                
            }
        }

        public int GetSlotsForVehicle(VehicleType vehicleType)
        {
            int slots = 0;
            foreach (var K in slot)
            {
                if(K.VehicleType == vehicleType && K.IsOccupied==true)
                {
                    slots++;
                }
            }
            return slots;
        }

    }
}
