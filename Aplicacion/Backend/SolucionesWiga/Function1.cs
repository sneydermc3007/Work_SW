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
                Console.WriteLine("Conexion abierta");
                conn.Open();
                
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
                        }

                    }


                }
            }

            //Cliente myClient = new();
            //Factura myInvoice = new();
            //Articulo myItem = new();
            //AzureConexion myConexion = new();

            //Item item1 = new Item("Cuaderno", 2, 10000);
            //List<Item> items = new List<Item> { item1 };

            //Item item3 = new Item("Borrador", 3, 3000);
            //List<Item> items_2 = new List<Item> { item3 };

            //Invoice invoice1 = new Invoice("Factura 1 de mayo 2019", items);
            //Invoice invoice_2 = new Invoice("Factura 3 de julio 2019", items_2);

            //List<Invoice> invoiceObj = new List<Invoice> { invoice1, invoice_2 };

            //Client client = new Client(0, "Camila Martínez", invoiceObj);

            //List<Client> clientsList = new List<Client> { client };

            //var response = new { clients = clientsList };

            Test myTest = new();
            var response2 = new { test = myTest.texto };
            return new OkObjectResult(response2);
        }
    }
}
