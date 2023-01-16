using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int CarriageCapacity { get; set; }
        public bool HasFifthRow { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Transmission { get; set; }
        public bool CanDrive { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
    }
}
