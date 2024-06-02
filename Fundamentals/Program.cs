using ConsoleApp1.Models;
using Fundamentals.Models;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CervezaDB cervezaDB = new CervezaDB();

            //insert/post data on DB

            /* 
             Cerveza cervezaPost = new Cerveza(500, "Sol", "Rubia Sol");
             cervezaPost.Alcohol = 6.0;

             cerveza.Add(cervezaPost);

             */
            

            Cerveza cervezaEd = new Cerveza(600, "Sol", "Rubia Sol");
            cervezaEd.Alcohol = 3.2;
                cervezaEd.ID = 6;

            cervezaDB.Edit(cervezaEd);
            

            //basic GET data from DB
            var cervezas = cervezaDB.Get();

            foreach (var c in cervezas) 
            {
                Console.WriteLine(c.Nombre);
            }

        }
    }
}
