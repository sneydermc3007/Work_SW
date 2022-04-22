using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SolucionesWiga
{
    public static class Function1
    {
        [FunctionName("HttpExample")]
        public static async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "v1/clientes")] HttpRequest req,
            ILogger log)

        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "solucioneswiga2018snake-mc.mysql.database.azure.com",
                Database = "WigaSolucionesAzure",
                UserID = "SneyderSnake28@solucioneswiga2018snake-mc",
                Password = "UCLA sneyder#20",
                SslMode = MySqlSslMode.Required,
            };

            // El error que se estaba presentando al poner los datos de azure
            using (var conn = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=solucioneswiga;Uid=root;password="))
            {
                conn.Open();
                Console.WriteLine("Conexion abierta");
                
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = @"SELECT cliente.idClientes ,cliente.nombre, factura.fecha_compra, producto.nombre, detalle_factura.cantidad, producto.precio 
                                            FROM cliente, factura, detalle_factura, producto 
                                                WHERE cliente.idClientes = factura.id_cliente_fk 
                                                    AND factura.numero = detalle_factura.numero_factura_fk 
                                                        AND detalle_factura.id_producto_fk = producto.id_producto";

                    Cliente obj_cliente = new();
                    Factura obj_factura = new();
                    Articulo obj_articulo = new();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {

                            Console.WriteLine(string.Format(
                                "Reading from table=({0}, {1}, {2}, {3}, {4}, {5}",
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDateTime(2),
                                reader.GetString(3),
                                reader.GetInt32(4),
                                reader.GetDouble(5)
                                ));

                            obj_articulo.producto = reader.GetString(3);
                            obj_articulo.cantidad = reader.GetInt32(4);
                            obj_articulo.total = reader.GetDouble(5);
                            obj_factura.date = reader.GetDateTime(2);                           
                            obj_cliente.id = reader.GetInt32(0);
                            obj_cliente.name = reader.GetString(1);

                            //--------------- Pruebas de envio --------------------
                            obj_articulo = new Articulo(obj_articulo.producto, obj_articulo.cantidad, obj_articulo.total);
                            List<Articulo> articulos = new List<Articulo> { obj_articulo };

                            obj_factura = new Factura(obj_factura.date, articulos);
                            List<Factura> factura_Objeto = new List<Factura> { obj_factura };

                            obj_cliente = new Cliente(obj_cliente.id, obj_cliente.name, factura_Objeto);

                            Console.WriteLine("\n");
                        }
                    }
                }
            }

            //Articulo objeto_retorno_articulo = new Articulo("Cuaderno", 2, 10000);
            //List<Articulo> articulos = new List<Articulo> { objeto_retorno_articulo };

            //Factura objeto_retorno_factura = new Factura(System.DateTime.Today, articulos);
            //List<Factura> facturaObj = new List<Factura> { objeto_retorno_factura };

            //Cliente objeto_retorno_cliente = new Cliente(0, "Camila Cardeño", facturaObj);

            //List<Cliente> listaClientes = new List<Cliente> { objeto_retorno_cliente };
            //var response = new { clientes = listaClientes };

            Test myTest = new();
            var response2 = new { test = myTest.texto };
            return new OkObjectResult(response2);
        }
    }
}