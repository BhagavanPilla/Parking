using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Ticket
    {
        public string vehicleNumber {  get; set; }
        public VehicleType vehicleType { get; set; }
        public int slotNumber {  get; set; }
        public DateTime inTime { get; set; }
        public DateTime outTime {  get; set; }
        public Ticket(string vehicleNumber,VehicleType vehicleType,int slotNumber,DateTime inTime,DateTime outTime)
        {
            this.vehicleNumber = vehicleNumber;
            this.vehicleType = vehicleType;
            this.slotNumber = slotNumber;
            this.inTime = inTime;
            this.outTime = outTime;

        }
        public void DisplayTicket()
        {
            Console.WriteLine("VehicleNumber: " + vehicleNumber);
            Console.WriteLine("Slot: " + slotNumber);
            Console.WriteLine("InTime: " + inTime);
            Console.WriteLine("OutTime: " + outTime);
        }
    }
}
