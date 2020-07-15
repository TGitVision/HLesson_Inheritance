using System;

namespace HLesson_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from HLesson_Inheritance!");

            // Declare and call base classes here...added by th 07142020
            Vehicle vehicle1 = new Vehicle(4, 6, "red", 4, 2020);
            vehicle1.Start();
            vehicle1.Stop();
            // vehicle1.GetVehicleDetails();

            //////Vehicle vehicle2 = new Vehicle(2, 2, "black", 4);
            //////vehicle2.Start();
            //////vehicle2.Stop();
            //////vehicle2.GetVehicleDetails();

            // Declare and call classes here...added by th 07142020
            Car car1 = new Car(true, true, 4, 6, "red", 4, 2016);
            car1.Start();
            car1.Stop();
            car1.Stop();            
            car1.Start();
            car1.Start();
            car1.Stop();
            car1.GetVehicleDetails();

            // Print and Write base class values and custom values.
            Console.WriteLine(car1.ToString());

            // Another class...added by th 07142020
            Boat boat1 = new Boat(true, false, "yacht", 6, 12, "white", 0, 2019);
            boat1.Start();
            boat1.Stop();
            boat1.Stop();            
            boat1.Start();
            boat1.Start();
            boat1.Stop();
            boat1.GetVehicleDetails();

            // Print and Write base class values and custom values.
            Console.WriteLine(boat1.ToString());

            // Another class...added by th 07142020
            Plane plane1 = new Plane(true, 4, 80, 4, 150, "orange", 16, 2020);
            plane1.Start();
            plane1.Stop();
            plane1.Stop();
            plane1.Start();
            plane1.Start();
            plane1.Stop();
            plane1.GetVehicleDetails();

            // Print and Write base class values and custom values.
            Console.WriteLine(plane1.ToString());

        }
    }
}
