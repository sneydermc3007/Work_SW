using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SolucionesWiga
{
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=solucioneswiga; Uid=root; pwd=;");
            
            String query  = "SELECT * FROM cliente";

            MySqlCommand commandDatabase = new MySqlCommand(query, conectar);
            
            try
            {
                conectar.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();

            }
            catch (Exception ex){
                Console.WriteLine("Error en la ejecucion del query" + ex.Message);
            }
            
            return conectar;
        }
    }
}
