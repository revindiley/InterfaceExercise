using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany DONE   

            //Create 3 classes called Car , Truck , & SUV DONE  

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common. DONE
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company DONE
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes 

            /*Create 2 members that are specific to each class DONE
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. DONE
             * 
             */

            //Now, create objects of your 3 classes and give their members values; 
            //Creatively display and organize their values

            Car Customer1 = new Car()
            {
                LowToGround = true,
                HasTrunk = true,
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                Transmission = "automatic",
                CanDrive = true,
                Make = "Ford",
                Model = "Edge"
            };

            SUV Customer2 = new SUV()
            {
                CarriageCapacity = 7,
                HasFifthRow = true,
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                Transmission = "automatic",
                CanDrive = true,
                Make = "Toyota",
                Model = "Seqouia"
            };

            Truck Customer3 = new Truck()
            {
                HasBedCover = true,
                TowingCapacity = 11000,
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                Transmission = "automatic",
                CanDrive = true,
                Make = "Chevrolet",
                Model = "Silverado"
            };
            Console.WriteLine($"Customer #1 brought in a 2017 {Customer1.Make} {Customer1.Model} with an {Customer1.Transmission} transmission, has all {Customer1.NumberOfDoors} doors, and all " +
                $"{Customer1.NumberOfWheels} wheels. It's {Customer1.LowToGround} that it's low to the ground, {Customer1.HasTrunk} that it has a trunk, and {Customer1.CanDrive} that it was brought in with " +
                $"the capability of driving.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Customer #2 brought in a 2020 {Customer2.Make} {Customer2.Model} with an {Customer2.Transmission} transmission, has all {Customer2.NumberOfDoors} doors, and all " +
                $"{Customer2.NumberOfWheels} wheels. It has a carriage capacity of {Customer2.CarriageCapacity} and is {Customer2.HasFifthRow} that there is fifth-row seating.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Customer #3 brought in a 2021 {Customer3.Make} {Customer3.Model} with an {Customer3.Transmission} transmission, has all {Customer3.NumberOfDoors} doors, and all " +
                $" {Customer3.NumberOfWheels} wheels. It has a towing capacity of {Customer3.TowingCapacity} and {Customer3.HasBedCover} that it had on a bed cover when it was brought in.");





        }
    }
}
