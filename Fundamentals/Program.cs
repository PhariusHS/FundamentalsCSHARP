using ConsoleApp1.Models;
using Fundamentals.Models;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CervezaDB cerveza = new CervezaDB();

            var cervezas = cerveza.Get();

            foreach (var c in cervezas) 
            {
                Console.WriteLine(c.Nombre);
            }

        }
    }
}
