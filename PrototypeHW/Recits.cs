using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeHW
{
    public class Recits : Iclone<Recits>
    {
       
        public Customer customer1 {  get; set; }
        public int AmountPayed { get; set; }
        public int Tax { get; set; }
        public  DateTime DateOfPerchase{ get; set; }

        public Recits()
        {

        }

        public Recits(Customer customer,int amountPayed,int tax , DateTime dateOfperchase)
        {
           this.customer1 = customer;
            AmountPayed = amountPayed;
            Tax = tax;
            DateOfPerchase = dateOfperchase;
        }

        public Recits Clone()
        {
            Recits clone = new Recits(this.customer1,this.AmountPayed,this.Tax,this.DateOfPerchase);
            return clone;
        }

        public override string ToString()
        {
            return $"Customer : {customer1.Name} {customer1.LastName}, Customer ID {customer1.Id} \n Date Of Perchase : {DateOfPerchase}";
        }
    }
}
