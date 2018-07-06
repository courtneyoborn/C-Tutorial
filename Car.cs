using System;
using static UdemyTutorial.Program;

namespace UdemyTutorial
{
      public class Car : Vehicle
        {
            public Car(string registrationNumber)
                : base(registrationNumber)
            {
                 //var car = new Car("XYZ123");
                 Console.WriteLine("Car is being initialized.");

            }
        }
 }

