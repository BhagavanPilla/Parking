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

            ParkingLotService parkingLotService = new ParkingLotService(3,3,3);
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
