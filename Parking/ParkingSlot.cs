using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class ParkingSlot
    {
        public int SlotNumber { get; set; }
        public VehicleType VehicleType;
        public string VehicleNumber {  get; set; }
        public bool IsOccupied { get; set; }

        public ParkingSlot(int slotId,VehicleType vehicleType) 
        {
            SlotNumber = slotId;
            VehicleType = vehicleType;
            VehicleNumber = string.Empty;
            IsOccupied = false;
        }
    }
}
