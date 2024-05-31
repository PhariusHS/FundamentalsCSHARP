

namespace ConsoleApp1.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {

        public double Alcohol { get; set; }
        public int ID { get; set; }


        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido es de 10");
        }


        public Cerveza (int Mililitros, string Marca, string Nombre = "Cerveza") : 
            base (Mililitros, Marca, Nombre)

        {
            
        }
    }
}
