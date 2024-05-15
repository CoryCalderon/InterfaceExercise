using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool ThirdRowOfSeats { get; set; }
        public string FrontFoldingSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string PaintColor { get; set; }
        public int NumberOfSeats { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }

        public void Color()
        {
            Console.WriteLine();
        }

        public void Company()
        {
            Console.WriteLine();
        }

        public void Doors()
        {
            Console.WriteLine();
        }

        public void Emblem()
        {
            Console.WriteLine();
        }

        public void Seats()
        {
            Console.WriteLine();
        }

        public void Wheels()
        {
            Console.WriteLine();
        }
    }

    

}
