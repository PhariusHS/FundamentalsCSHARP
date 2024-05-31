﻿using ConsoleApp1.Models;
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

    }
}