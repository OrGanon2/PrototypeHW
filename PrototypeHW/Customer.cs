using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeHW
{
    public class Customer
    {
        public string Name { get; set; }
        public string LastName {  get; set; }
        public int Id { get; set; }
        public Customer(string name,string lastName, int id)
        {
            LastName = lastName;
            Name = name;
            Id = id;
        }

        


    }
}
