using System;

namespace _20220305048_StockApp
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int UnitNumber { get; set; }
        public string Brand { get; set; }
        public string WarehouseName { get; set; }
        public DateTime CountDateTime { get; set; }

        public Product() { CountDateTime = DateTime.Now; }

        public override string ToString() => $"ID: {Id} | Ürün: {ProductName} | Adet: {UnitNumber} | Marka: {Brand}";
    }
}