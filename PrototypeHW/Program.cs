using System.Text.Json;

namespace PrototypeHW
{
    class program
    {
        public static void Main(string[] args)
        {
            Customer customer= new Customer("or","Ganon",25);
           Recits recits= new Recits(customer,1000,55,new DateTime(1993,12,25));
            Recits  recits_Copy = recits.Clone();


            Recits RecitCopy2 = DeepCopy<Recits>(recits);
            customer.Name = "Or";
            Console.WriteLine(recits_Copy);
            Console.WriteLine(RecitCopy2);

        }
        public static T DeepCopy<T>(T info)
        {
            var json = JsonSerializer.Serialize(info);
            T obj = JsonSerializer.Deserialize<T>(json);
            return obj;
        }
    }
}