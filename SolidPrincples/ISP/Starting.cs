using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincples.ISP
{
    public interface IVehicle
    {
        void Drive();
        void Fly();
    }

    public class MultiFunctionalCar : IVehicle
    {
        public void Drive()
        {
            //actions to start driving car
            Console.WriteLine("Drive a multifunctional car");
        }
        public void Fly()
        {
            //actions to start flying
            Console.WriteLine("Fly a multifunctional car");
        }
    }

    public class Car : IVehicle
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
