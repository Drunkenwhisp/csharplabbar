using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Vehicle("Gocart");
            var l = new Vehicle("Car");

            Console.WriteLine(v.DescribeVehicle());
            Console.WriteLine(l.DescribeVehicle());
        }
    }
}
