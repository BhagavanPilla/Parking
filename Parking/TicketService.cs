using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class TicketService
    {
        public Ticket GenerateTicket(string vehicleNumber,VehicleType vehicleType,int slotnumber)
        {
            DateTime InTime= DateTime.Now;
            return new Ticket(vehicleNumber, vehicleType, slotnumber, InTime,default);
        }
        public void UpdateOutTime(List<Ticket> tickets, string vehicleNumber)
        {
           foreach (Ticket ticket in tickets)
            {
                if(ticket.VehicleNumber == vehicleNumber)
                {
                    ticket.OutTime = DateTime.Now;
                    ticket.DisplayTicket();

                }
            }
        }
    }
}
