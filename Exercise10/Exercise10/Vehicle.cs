using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Vehicle
    {
        public string type { get; set; }
        public Vehicle(string type)
        {
            this.type = type;
        }
        public string DescribeVehicle()
        {
            return $"This Vehicle is a {type}";
        }
    }
}
