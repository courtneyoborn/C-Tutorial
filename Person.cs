using System;

namespace UdemyTutorial
{
    public class Person
    {

        public DateTime Birthdate { get; set; }

        //public int Id;
        public string FirstName;
        //public string LastName;
        //public DateTime Birthdate;
         

        public void Introduce(string to)
        {
            Console.WriteLine("Hi, {0}, I am {1}", to, FirstName);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.FirstName = str; 

            return person;
        }

        static void UsePerson()
        {
            var person = Person.Parse("John");
            person.Introduce("Courtney");

            var customer = new Customer(1, "John");
            var order = new Order();
            customer.Orders.Add(order);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }

        //var person = new Person();
        //person.Birthdate(new DateTime(1993, 02, 22));
        //Console.WriteLine(person.Birthdate());
        //int num;
        //var result = int.TryParse("abc", out num); // try parse does not throw an exception
        //if (result)
        //    Console.WriteLine(num);
        //else
        //    Console.WriteLine("Conversion failed");
    }
}
