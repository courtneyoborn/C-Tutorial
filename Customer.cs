using System.Collections.Generic;
using System;

namespace UdemyTutorial
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();  // readonly access modifier ensures field is only initialised once

        public Customer() // default parameterless constructor () 
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this () // calles the constructor without any parameters ()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // calles the constructor that takes the id parameter ()
        {
            this.Name = name;
        }

    }
}
