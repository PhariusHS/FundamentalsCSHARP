using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Models
{
    internal class CervezaDB
    {

        private string connectionString = "Data source=DESKTOP-68QCP94;Initial Catalog=Bebidas;" +
            "Integrated Security=True;";

        public List<Cerveza> Get() // Metodo de clase de obtencion datos
        {
            List <Cerveza> cervezas = new List <Cerveza>();

            string query = "select id, nombre, marca, mililitros, alcohol from cervezas";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection); 
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nombre = reader.GetString(1);
                    string marca = reader.GetString(2);
                    int mililitros = reader.GetInt32(3);
                    Cerveza cerveza = new Cerveza(mililitros, marca, nombre);
                    cerveza.ID = reader.GetInt32(0);
                    cerveza.Alcohol = reader.GetDouble(4);
                    cervezas.Add(cerveza);
                }
                reader.Close();
                connection.Close();
            }




            return cervezas; 
        }

        public void Add(Cerveza cerveza) // Metodo clase agregar datos
        {
            string query = "insert into cervezas (nombre, marca, mililitros, alcohol) " + 
                "values (@nombre, @marca, @mililitros, @alcohol)";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@mililitros", cerveza.Mililitros);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);                                                                  
                connection.Open();

                    command.ExecuteNonQuery();

                connection.Close();
            }

        }


        public void Edit(Cerveza cerveza) // Metodo clase editar datos
        {
            string query = "update cervezas set nombre=@nombre, marca=@marca, mililitros=@mililitros, " +
                "alcohol = @alcohol where id = @id";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@mililitros", cerveza.Mililitros);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@id", cerveza.ID);
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }

        }

    }
}
