using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public interface IVehicle
    {
        public void Start();
        public void Stop();
    }
    public class Car: IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car has been started");
        }
        public void Stop()
        {
            Console.WriteLine("Car has been stoped");
        }
    }
    public class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike has been started");
        }
        public void Stop()
        {
            Console.WriteLine("Bike has been stoped");
        }
    }
    internal class VehicleClass
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Start();
            car.Stop();
            Bike bike = new Bike();
            bike.Start();
            bike.Stop();
        }
    }
}
