using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincples.ISP.Refactoring
{
    public interface ICar
    {
        void Drive();
    }
    public interface IAirplane
    {
        void Fly();
    }

    public class Car : ICar
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
    }
    public class Airplane : IAirplane
    {
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }

    public class MultiFunctionalCar : ICar, IAirplane
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
}
