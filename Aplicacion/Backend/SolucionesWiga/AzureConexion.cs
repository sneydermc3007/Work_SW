//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

//namespace SolucionesWiga
//{
//    class AzureConexion
//    {
//        static async Task Main(string[] args)
//        {
//            var builder = new MySqlConnectionStringBuilder
//            {
//                Server = "solucioneswiga2018snake-mc.mysql.database.azure.com",
//                Database = "WigaSolucionesAzure",
//                UserID = "SneyderSnake28@solucioneswiga2018snake-mc",
//                Password = "UCLA sneyder#20",
//                SslMode = MySqlSslMode.Required,
//            };

//            using (var conn = new MySqlConnection(builder.ConnectionString))
//            {
//                Console.WriteLine("Opening connection");
//                await conn.OpenAsync();

//                using (var command = conn.CreateCommand()) {

//                    command.CommandText = "SELECT cliente.idClientes ,cliente.nombre, factura.fecha_compra, producto.nombre, detalle_factura.cantidad, producto.precio" +
//                        "FROM cliente, factura, detalle_factura, producto" +
//                        "WHERE cliente.idClientes = factura.id_cliente_fk" +
//                        "AND factura.numero = detalle_factura.numero_factura_fk" +
//                        "AND detalle_factura.id_producto_fk = producto.id_producto";

//                    Cliente  obj_cliente = new();
//                    Factura  obj_factura = new();
//                    Articulo obj_articulo = new();


//                    using (var reader = await command.ExecuteReaderAsync())
//                    {
//                        while (await reader.ReadAsync())
//                        {
//                            obj_articulo.producto = reader["solucioneswiga.producto.nombre"].ToString();
//                            obj_articulo.cantidad = Convert.ToInt32(reader["solucioneswiga.detalle_factura.cantidad"]);
//                            obj_articulo.total = Convert.ToInt32(reader["solucioneswiga.producto.precio"]);

//                            obj_factura.date = Convert.ToDateTime(reader["solucioneswiga.factura.fecha_compra"]).ToString("DD/MM/yyyy");

//                            obj_cliente.name = reader["solucioneswiga.cliente.nombre"].ToString();
//                            obj_cliente.id = Convert.ToInt32(reader["solucioneswiga.cliente.idClientes"]);
//                        }
//                    }
//                }
//            }
//        }
//    }

   
//}
