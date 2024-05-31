
namespace ConsoleApp1.Models
{
    internal class Bebida
    {
        public string Nombre { get; set; } 
        public int Mililitros { get; set; }
        public string Marca {  get; set; }

        public Bebida(int Mililitros, string Marca, string Nombre)
        {

            this.Nombre = Nombre;
            this.Marca = Marca; 
            this.Mililitros = Mililitros;
        }

        public void Beber(int Bebido)
        {
            this.Mililitros -= Bebido;
        }
    }
}
