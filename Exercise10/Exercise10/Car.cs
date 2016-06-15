using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Car : Vehicle
    {
        public bool engineIsRunning { get; set; }
        public Car() : base("Car")
        {
            this.engineIsRunning = false;
        }
        public void StartEngine()
        {
            this.engineIsRunning = true;
        }
    }
}