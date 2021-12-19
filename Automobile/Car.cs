using System;
using System.Collections.Generic;
using System.Text;

namespace Automobile
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}
