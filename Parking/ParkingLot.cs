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
        

        public ParkingLot(int twowheelers,int fourWheelers,int heavyVehicle)
        {
            numberOfTwoWheelerSlots = twowheelers;
            numberOfFourWheelerSlots = fourWheelers;
            numberOfHeavyVehicleSlots = heavyVehicle;

            
        }

        public Dictionary<Vehicle,int> parkedVehicle=new Dictionary<Vehicle,int>();
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
            foreach (var parked in parkedVehicle)
            {
                Console.WriteLine(parked.Key.vehicletype + " Slot " + parked.Value + " is Occupied by " + parked.Key.vehicleNumber);
            }
        }

        public int GetSlotsForVehicle(VehicleType vehicleType)
        {
            //int slots = 0;
            //foreach(var vehicle in parkedVehicle)
            //{
            //    vehicle.Key.vehicletype = vehicleType;
            //    slots++;
            //}
            //return slots;
            return parkedVehicle.Count(v => v.Key.vehicletype == vehicleType);
        }

    }
}
