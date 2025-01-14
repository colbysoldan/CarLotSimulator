﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //DONE


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var niceCar = new Car("Porsche","Panamera",2020,"purrs","teacups clinking", true);
            lot.Cars.Add(niceCar);

            var reliableCar = new Car();
            reliableCar.Make = "Subaru";
            reliableCar.Model = "Outback";
            reliableCar.Year = 2005;
            reliableCar.EngineNoise = "is barely audible";
            reliableCar.HonkNoise = "\"get out of the way of my manbun\"";
            reliableCar.IsDrivable = true;
            lot.Cars.Add(reliableCar);

            var lemonCar = new Car()
            {
                Make = "Mazda",
                Model = "626",
                Year = 1993,
                EngineNoise = "backfires",
                HonkNoise = "beep beep",
                IsDrivable = false,
            };
            lot.Cars.Add(lemonCar);

            Console.WriteLine($"\n\nTotal cars in lot: {CarLot.numberOfCars}\n\n");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Make: {car.Make}" +
                    $"\nModel: {car.Model}" +
                    $"\nYear: {car.Year}" +
                    $"\nDescription: The engine {car.EngineNoise} and the horn makes a {car.HonkNoise} sound.\n\n");
                
            }
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
