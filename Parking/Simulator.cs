using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Simulator
    {
        public static int Input()
        {
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if(n<0)
                {
                    throw new Exception();
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter Integer Value");
                n=Input();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter Small value");
                n=Input();
            }
            catch(Exception)
            {
                Console.WriteLine("Enter Positive Value");
                n=Input();
            }
            return n;
        }
        static void Main()
        {
            Console.Write("Enter no of two wheeler slots : ");
            int n1 = Input();
            Console.Write("Enter no of four wheeler slots : ");
            int n2 = Input();
            Console.Write("Enter no of heavy Vehicle slots : ");
            int n3 = Input();

            List<ParkingSlot> slots = new List<ParkingSlot>();
            for(int i=0; i < n1; i++)
            {
                slots.Add(new ParkingSlot(i + 1,VehicleType.twoWheeler));
            }
            for (int i = 0; i < n2; i++)
            {
                slots.Add(new ParkingSlot(i + 1, VehicleType.fourWheeler));
            }
            for (int i = 0; i < n3; i++)
            {
                slots.Add(new ParkingSlot(i + 1, VehicleType.heavyVehicle));
            }

            ParkingLotService parkingLotService = new ParkingLotService(n1,n2,n3,slots);
            while (true)
            {

                parkingLotService.DisplayAvailableSlots();

                Console.WriteLine("\n1.Park Vehicle");
                Console.WriteLine("2.Unpark Vehicle");
                Console.WriteLine("3.Exit");
                int option=Input();

                switch(option)
                {
                    case 1:
                        parkingLotService.ParkVehicle();
                        break;
                    case 2:
                        parkingLotService.UnParkVehicle();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Enter Valid Option");
                        break;
                }
            }
        }
    }
}
