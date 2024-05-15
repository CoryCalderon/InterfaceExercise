using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string PaintColor { get; set; }
        public int NumberOfSeats { get; set; }

        public void Wheels();
        public void Doors();
        public void Seats();
        public void Color();
    }
}
