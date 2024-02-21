using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Vehicle
    {
        public string vehicleNumber {  get; set; }
        public VehicleType vehicletype { get; set; }



        public Vehicle(string vehicle, VehicleType type)
        {
            this.vehicleNumber = vehicle;
            this.vehicletype = type;
        }
    }
}
