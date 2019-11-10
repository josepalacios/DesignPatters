using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class VehicleBuilder
    {
        public Vehicle vehicle;

        // Gets vehicle instance

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        // Abstract build methods

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
