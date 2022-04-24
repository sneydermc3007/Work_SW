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
using System.Linq;

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
                
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = @"SELECT cliente.idClientes ,cliente.nombre, factura.fecha_compra, producto.nombre, detalle_factura.cantidad, producto.precio 
                                            FROM cliente, factura, detalle_factura, producto 
                                                WHERE cliente.idClientes = factura.id_cliente_fk 
                                                    AND factura.numero = detalle_factura.numero_factura_fk 
                                                        AND detalle_factura.id_producto_fk = producto.id_producto";

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        List<Cliente> listaClientes = new ();
                        List<Cliente> listaClientesTemp = new ();

                        while (await reader.ReadAsync())
                        {
                            //Posicion 0 es id
                            //Posicion 1 es name del cliente
                            //Posicion 2 es Fecha de compras
                            //Posicion 3 es nombre del Podructo
                            //Posicion 4 es cantidad
                            //Posicion 5 es total
                            Console.WriteLine(string.Format(
                                "Reading from table=({0}, {1}, {2}, {3}, {4}, {5}",
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDateTime(2),
                                reader.GetString(3),
                                reader.GetInt32(4),
                                reader.GetDouble(5)
                                ));

                            Articulo obj_articulo = new(reader.GetString(3), reader.GetInt32(4), reader.GetDouble(5));
                            Factura obj_factura = new(reader.GetDateTime(2), new List<Articulo> { obj_articulo });
                            Cliente obj_cliente = new(reader.GetInt32(0), reader.GetString(1), new List<Factura> { obj_factura });

                            if (listaClientes.Count == 0)
                            {
                                listaClientes.Add(obj_cliente);
                                listaClientesTemp.Add(obj_cliente);
                            } 
                            else
                            {
                                var nuevoCliente = true;
                                foreach (Cliente cliente in listaClientes)
                                {
                                    if (cliente.id == obj_cliente.id)
                                    {
                                        nuevoCliente = false;
                                    }
                                }
                                if (nuevoCliente)
                                {
                                    listaClientes.Add(obj_cliente);
                                } 
                                else
                                {
                                    for (int i = 0; i < listaClientes.Count; i++)
                                    {
                                        if (listaClientes[i].id == obj_cliente.id)
                                        {
                                            var facturas = listaClientes[i].factura;
                                            Console.WriteLine("\t ya esta en la lista: " + obj_cliente.name);

                                            var nuevaFactura = true;
                                            foreach (Factura factura in facturas)
                                            {
                                                if (factura.date == obj_factura.date)
                                                {
                                                    nuevaFactura = false;
                                                }
                                            }
                                            if (nuevaFactura)
                                            {
                                                Console.WriteLine("\t Otra factura");
                                                facturas.Add(obj_factura);
                                            }
                                            else
                                            {
                                                var articulos = new List<Articulo>();
                                                for (int j = 0; j < facturas.Count; j++)
                                                {
                                                    if (facturas[j].date == obj_factura.date)
                                                    {
                                                        Console.WriteLine("\t Esta fecha ya tiene una factura");
                                                        articulos.Add(obj_articulo);
                                                        facturas[j].articulos.Add(obj_articulo);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        var response = new { clientes = listaClientes };
                        return new OkObjectResult(response);
                    }
                }
            }
        }
    }
}