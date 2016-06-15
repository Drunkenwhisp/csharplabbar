using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Gocart : Vehicle
    {
        public int lapcounter { get; set; }
        public Gocart() : base("Gocart")
        {

        }
        public void RegisterLaps()
        {
            this.lapcounter = lapcounter++;
        }
        public virtual void PrintVehicle(Gocart v)
        {
            Console.WriteLine(v.lapcounter);
        }
    }
}
