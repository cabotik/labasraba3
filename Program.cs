using System;

namespace labasraba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pastry's list: ");
            Pastry pastry = new Pastry("Maffin", true, "Chokolate", "Tiny");
            Console.WriteLine(pastry.Print());

            Pastry pastry_first = new Pastry("Pie", true, "Strawberry", "Middle");
            Console.WriteLine(pastry_first.Print());

            Pastry pastry_second = new Pastry("Bun", false, "Cherry", "Middle");         
            Console.WriteLine(pastry_second.Print());
            Console.ReadLine();
        }
        
    }
}
