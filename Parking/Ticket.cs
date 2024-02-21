using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Ticket
    {
        public string VehicleNumber {  get; set; }
        public VehicleType VehicleType { get; set; }
        public int SlotNumber {  get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime {  get; set; }
        public Ticket(string vehicleNumber,VehicleType vehicleType,int slotNumber,DateTime inTime,DateTime outTime)
        {
            this.VehicleNumber = vehicleNumber;
            this.VehicleType = vehicleType;
            this.SlotNumber = slotNumber;
            this.InTime = inTime;
            this.OutTime = outTime;

        }
        public void DisplayTicket()
        {
            Console.WriteLine("\n-----------------------TICKET--------------------------");
            Console.WriteLine("VehicleNumber: " + VehicleNumber);
            Console.WriteLine("Slot: " + SlotNumber);
            Console.WriteLine("InTime: " + InTime);
            Console.WriteLine("OutTime: " + OutTime);
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
