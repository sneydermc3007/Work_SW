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

namespace SolucionesWiga
{
    public static class Function1
    {
        [FunctionName("HttpExample")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "v1/clientes")] HttpRequest req,
            ILogger log)
        {
            Item item1 = new Item("Cuaderno", 2, 10000);
            Item item2 = new Item("BlocK", 2, 15000);
            List<Item> items = new List<Item> { item1, item2 };

            Item item3 = new Item("Borrador", 3, 3000);
            List<Item> items_2 = new List<Item> { item3 };

            Invoice invoice1 = new Invoice("Factura 1 de mayo 2019", items);
            Invoice invoice_2 = new Invoice("Factura 3 de julio 2019", items_2);

            List<Invoice> invoiceObj = new List<Invoice> { invoice1, invoice_2 };

            Client client = new Client(0, "Camila Martínez", invoiceObj);

            //------------------------------------------
            // Prueba varios datos quemados

            Item item4 = new Item("Bafles", 2, 100000);
            List<Item> items_3 = new List<Item> { item4 };

            Invoice invoice_3 = new Invoice("Factura 1 de enero 2018", items_3);

            Item item5 = new Item("Audifonos", 4, 25000);
            List<Item> items_4 = new List<Item> { item5 };

            Invoice invoice_4 = new Invoice("Factura 5 de febrero 2019", items_4);

            List<Invoice> invoiceObj_3 = new List<Invoice> { invoice_3, invoice_4 };
            Client client_2 = new Client(1, "Claudia Guarin", invoiceObj_3);

            List<Client> clientsList = new List<Client> { client, client_2 };

            var response = new { clients = clientsList };

            return new OkObjectResult(response);
        }
    }

    public class Client
    {
        // Auto-implemented properties.
        public int id { get; }
        public string name { get; }
        public List<Invoice> invoice { get; }

        public Client(int id, string name, List<Invoice> invoice)
        {
            this.id = id;
            this.name = name;
            this.invoice = invoice;
        }
    }
    public class Invoice
    {
        // Auto-implemented properties.
        public string date { get; }
        public List<Item> items { get; }

        public Invoice(string date, List<Item> items)
        {
            this.date = date;
            this.items = items;
        }
    }

    public class Item
    {
        // Auto-implemented properties.
        public string product { get; }
        public int quantity { get; }
        public int total { get; }

        public Item(string product, int quantity, int total)
        {
            this.product = product;
            this.quantity = quantity;
            this.total = total;
        }
    }
}
