

namespace ConsoleApp1.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {

        public double Alcohol { get; set; }


        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido es de 10");
        }


        public Vino(int Mililitros, string Marca, string Nombre = "Vino") :
            base(Mililitros, Marca, Nombre)

        {

        }
    }
}
