using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.interface_segregation.example1.wrong
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
        public void Fly()
        {
            throw new NotImplementedException(); // Interface Segregation violanted => we are forced to implement Fly()
        }
    }
}
