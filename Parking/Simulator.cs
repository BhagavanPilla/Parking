using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Simulator
    {
        static void Main()
        {
            ParkingLot parkingLot = new ParkingLot(3,3,3);
            while (true)
            {

                Ticket.DisplayOccupancy();

                Console.Write("\nEnter Vehicle Number: ");
                string number = Console.ReadLine();
                Console.Write("\nEnter Vehicle Type: ");
                int type = Convert.ToInt32(Console.ReadLine());
                Parking.ParkVehicle(number, type);
            }
        }
    }
}
