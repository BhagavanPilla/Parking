using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Vehicle
    {
        public string VehicleNumber {  get; set; }
        public VehicleType VehicleType { get; set; }



        public Vehicle(string vehicle, VehicleType type)
        {
            this.VehicleNumber = vehicle;
            this.VehicleType = type;
        }
    }
}
