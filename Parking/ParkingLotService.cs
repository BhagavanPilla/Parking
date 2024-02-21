using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class ParkingLotService
    {
        public ParkingLot parkingLot;

        TicketService ticketService=new TicketService();
        public ParkingLotService(int twoWheelers,int fourWheelers,int heavyVehicles)
        {
            parkingLot=new ParkingLot(twoWheelers, fourWheelers, heavyVehicles);
        }

        public void DisplayAvailableSlots()
        {
            parkingLot.AvailableSlots();
            parkingLot.OccupiedSlots();
        }

        public bool IsSlotsAvailable(VehicleType vehicleType)
        {
            int slots = parkingLot.GetSlotsForVehicle(vehicleType);
            if(vehicleType == VehicleType.twoWheeler)
            {
                return slots < parkingLot.numberOfTwoWheelerSlots;
            }
            else if(vehicleType == VehicleType.fourWheeler)
            {
                return slots < parkingLot.numberOfFourWheelerSlots;
            }
            else if(vehicleType == VehicleType.heavyVehicle)
            {
                return slots < parkingLot.numberOfHeavyVehicleSlots;
            }
            else
            {
                return false;
            }

        }

        public int GetNextAvailableSlot(VehicleType vehicleType)
        {
            int slotNumber = 1;
            foreach(var K in parkingLot.parkedVehicle)
            {
                if(K.Value == slotNumber && K.Key.VehicleType == vehicleType)
                {
                    slotNumber++;
                }
            }
            return slotNumber;
        }

        public bool ParkVehicle()
        {
            Console.Write("\nEnter Vehicle Number to Park: ");
            string vehicleNumber = Console.ReadLine();

            Console.WriteLine("\nSelect Vehicle Type(1.Twowheeler/2.FourWheeler/3.HeavyVehicle ");
            int choice = Simulator.Input();
            VehicleType vehicleType=default;
            switch (choice)
            {
                case 1:
                    vehicleType = VehicleType.twoWheeler;
                    break;
                case 2:
                    vehicleType = VehicleType.fourWheeler;
                    break;
                case 3:
                    vehicleType = VehicleType.heavyVehicle;
                    break;
                default:
                    Console.WriteLine("\nSelect Valid Option");
                    choice = Simulator.Input();
                    break;


            }
            if(IsSlotsAvailable(vehicleType))
            {
                int slotNumber = GetNextAvailableSlot(vehicleType);
                Ticket ticket = ticketService.GenerateTicket(vehicleNumber, vehicleType, slotNumber);
                parkingLot.tickets.Add(ticket);
                parkingLot.parkedVehicle.Add(new Vehicle(vehicleNumber, vehicleType), slotNumber);
                Console.WriteLine("\nVehicle " + vehicleNumber + " parked successfully\n");
                ticket.DisplayTicket();
                return true;
            }
            else
            {
                Console.WriteLine("\n No Available Slots for " + vehicleType);
                return false;
            }
            
        }

        public void UnParkVehicle()
        {
            Console.Write("\nEnter Vehicle Number to Unpark: ");
            string vehicleNumber=Console.ReadLine();
            Vehicle parkedVehicle = null;
            foreach(var vehicle in parkingLot.parkedVehicle.Keys)
            {
                if(vehicle.VehicleNumber == vehicleNumber)
                {
                    parkedVehicle = vehicle;
                    break;
                }
            }
            if (parkedVehicle != null)
            {
                parkingLot.parkedVehicle.Remove(parkedVehicle);
                Console.WriteLine("\nVehicle "+ vehicleNumber+" Unparked Successfully\n");
                ticketService.UpdateOutTime(parkingLot.tickets, vehicleNumber);
            }
            else
            {
                Console.WriteLine("\nVehicle Not Available To Unpark");
            }

        }
            
           
        
    }
}
