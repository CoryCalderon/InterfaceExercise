using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces
            //Create 2 Interfaces called IVehicle & ICompany - DONE
            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle: - DONE
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */ 
            //In ICompany: - DONE
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes - DONE
                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
            var suv = new SUV();
            var truck = new Truck();
            var car = new Car();

            suv.NumberOfSeats = 7;
            suv.NumberOfDoors = 5;
            suv.Logo = "plus sign";
            suv.NumberOfWheels = 4;
            suv.FrontFoldingSeats = "5 front folding seats";
            suv.Name = "Chevy";
            suv.PaintColor = "red";
            suv.ThirdRowOfSeats = true;

            truck.NumberOfSeats = 5;
            truck.NumberOfDoors = 4;
            truck.Logo = "L";
            truck.NumberOfWheels = 6;
            truck.HasBed = true;
            truck.Name = "Lexus";
            truck.PaintColor = "black";
            truck.TrailerHitch = true;

            car.NumberOfDoors = 2;
            car.Logo = "H";
            car.NumberOfSeats = 4;
            car.NumberOfWheels = 4;
            car.FourWheelDrive = true;
            car.HasTrunk = true;
            car.PaintColor = "blue";
            car.Name = "Honda";

            
            Console.WriteLine($"Welcome to Car Mart! I'm your personal assist to help find just the right vehicle for you. " +
                $"For starters, what type of vehicle you're looking for? car, truck or suv");
            string answer = Console.ReadLine();


            switch (answer)
            {
                case "car":
                    Console.WriteLine($"A car is a great choice. We have a {car.PaintColor} {car.Name} thats got your name on it! ");
                    Console.WriteLine($"Would you like to hear more about this option?");
                    var yesOrNo = Console.ReadLine();
                    switch (yesOrNo)
                    {
                        case "yes":
                            Console.WriteLine($"Great! The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires.");
                            break;
                        case "Yes":
                            Console.WriteLine($"Great! The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires.");
                            break;
                        case "no":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires!");
                            break;
                        case "No":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires!");
                            break;

                    }
                    break;
                case "Car":
                    Console.WriteLine($"A car is a great choice. We have a {car.PaintColor} {car.Name} thats got your name on it! ");
                    Console.WriteLine($"Would you like to hear more about this option?");
                    yesOrNo = Console.ReadLine();
                    switch (yesOrNo)
                    {
                        case "yes":
                            Console.WriteLine($"Great! The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires.");
                            break;
                        case "Yes":
                            Console.WriteLine($"Great! The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires.");
                            break;
                        case "no":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires!");
                            break;
                        case "No":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires!");
                            break;

                    }
                    break;
                case "CAR":
                    Console.WriteLine($"A car is a great choice. We have a {car.PaintColor} {car.Name} thats got your name on it! ");
                    Console.WriteLine($"Would you like to hear more about this option?");
                    yesOrNo = Console.ReadLine();
                    switch (yesOrNo)
                    {
                        case "yes":
                            Console.WriteLine($"Great! The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires.");
                            break;
                        case "Yes":
                            Console.WriteLine($"Great! The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires.");
                            break;
                        case "no":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires!");
                            break;
                        case "No":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {car.NumberOfDoors} doors, {car.NumberOfSeats} seats and {car.NumberOfWheels} new tires!");
                            break;

                    }
                    break;
                case "truck":
                    Console.WriteLine($"A truck is a great choice. We have a {truck.PaintColor} {truck.Name} thats got your name on it! ");
                    Console.WriteLine($"Would you like to hear more about this option?");
                    yesOrNo = Console.ReadLine();
                    switch (yesOrNo)
                    {
                        case "yes":
                            Console.WriteLine($"Great! The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires.");
                            break;
                        case "Yes":
                            Console.WriteLine($"Great! The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires.");
                            break;
                        case "no":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires!");
                            break;
                        case "No":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires!");
                            break;

                    }
                    break;
                case "Truck":
                    Console.WriteLine($"A truck is a great choice. We have a {truck.PaintColor} {truck.Name} thats got your name on it! ");
                    Console.WriteLine($"Would you like to hear more about this option?");
                    yesOrNo = Console.ReadLine();
                    switch (yesOrNo)
                    {
                        case "yes":
                            Console.WriteLine($"Great! The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires.");
                            break;
                        case "Yes":
                            Console.WriteLine($"Great! The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires.");
                            break;
                        case "no":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires!");
                            break;
                        case "No":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires!");
                            break;

                    }
                    break;
                case "TRUCK":
                    Console.WriteLine($"A truck is a great choice. We have a {truck.PaintColor} {truck.Name} thats got your name on it! ");
                    Console.WriteLine($"Would you like to hear more about this option?");
                    yesOrNo = Console.ReadLine();
                    switch (yesOrNo)
                    {
                        case "yes":
                            Console.WriteLine($"Great! The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires.");
                            break;
                        case "Yes":
                            Console.WriteLine($"Great! The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires.");
                            break;
                        case "no":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires!");
                            break;
                        case "No":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {truck.NumberOfDoors} doors, {truck.NumberOfSeats} seats and {truck.NumberOfWheels} new tires!");
                            break;

                    }
                    break;
                case "SUV":
                    Console.WriteLine($"An suv is a great choice. We have a {suv.PaintColor} {suv.Name} with your name on it!");
                    Console.WriteLine($"Would you like to hear more about this option?");
                    yesOrNo = Console.ReadLine();
                    switch (yesOrNo)
                    {
                        case "yes":
                            Console.WriteLine($"Great! The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires.");
                            break;
                        case "Yes":
                            Console.WriteLine($"Great! The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires.");
                            break;
                        case "no":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires!");
                            break;
                        case "No":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires!");
                            break;

                    }
                    break;
                case "Suv":
                    Console.WriteLine($"An suv is a great choice. We have a {suv.PaintColor} {suv.Name} with your name on it!");
                    Console.WriteLine($"Would you like to hear more about this option?");
                    yesOrNo = Console.ReadLine();
                    switch (yesOrNo)
                    {
                        case "yes":
                            Console.WriteLine($"Great! The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires.");
                            break;
                        case "Yes":
                            Console.WriteLine($"Great! The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires.");
                            break;
                        case "no":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires!");
                            break;
                        case "No":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires!");
                            break;
                    }
                    break;
                case "suv":
                    Console.WriteLine($"An suv is a great choice. We have a {suv.PaintColor} {suv.Name} with your name on it!");
                    Console.WriteLine($"Would you like to hear more about this option?");
                    yesOrNo = Console.ReadLine();
                    switch (yesOrNo)
                    {
                        case "yes":
                            Console.WriteLine($"Great! The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires.");
                            break;
                        case "Yes":
                            Console.WriteLine($"Great! The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires.");
                            break;
                        case "no":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires!");
                            break;
                        case "No":
                            Console.WriteLine($"Well, I'll tell you anyway. The car we have in stock has {suv.NumberOfDoors} doors, {suv.NumberOfSeats} seats and {suv.NumberOfWheels} new tires!");
                            break;
                    }
                    break;

            }
            


            }
    }
}
