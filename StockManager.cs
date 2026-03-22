using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace _20220305048_StockApp
{
    public class StockManager
    {
        private List<Product> products = new List<Product>();
        private string path = "stock.json";

        public StockManager() { Load(); }

        public void Add(Product p)
        {
            p.Id = products.Count > 0 ? products[products.Count - 1].Id + 1 : 1;
            products.Add(p);
            Save();
        }

        public void List()
        {
            if (products.Count == 0) Console.WriteLine("Liste boş.");
            else products.ForEach(p => Console.WriteLine(p));
        }

        private void Save() => File.WriteAllText(path, JsonSerializer.Serialize(products));
        private void Load() { if (File.Exists(path)) products = JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(path)); }
    }
}