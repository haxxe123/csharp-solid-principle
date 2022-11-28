using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.interface_segregation.example1.wrong
{
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException(); // Interface Segregation violanted => we are forced to implement Drive()
        }
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
