using ConsoleApp1.Models;
using Fundamentals.Models;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CervezaDB cerveza = new CervezaDB();

            //insert/post data on DB

            Cerveza cervezaPost = new Cerveza(500, "Sol", "Rubia Sol");
            cervezaPost.Alcohol = 6.0;

            cerveza.Add(cervezaPost);


            //basic GET data from DB
            var cervezas = cerveza.Get();

            foreach (var c in cervezas) 
            {
                Console.WriteLine(c.Nombre);
            }

        }
    }
}
