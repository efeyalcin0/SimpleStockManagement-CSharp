using System;

namespace _20220305048_StockApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            StockManager sm = new StockManager();

            while (true)
            {
                Console.WriteLine("\n=============================");
                Console.WriteLine("   STOK TAKİP UYGULAMASI   ");
                Console.WriteLine("=============================");
                Console.WriteLine("1. Yeni Ürün Ekle");
                Console.WriteLine("2. Ürünleri Listele");
                Console.WriteLine("3. Çıkış");
                Console.Write("Lütfen bir işlem seçin (1-3): ");

                
                string s = Console.ReadLine();

                if (s == "1")
                {
                    Product p = new Product();

                    Console.Write("Ürün Adı: ");
                    p.ProductName = Console.ReadLine();

                    Console.Write("Marka: ");
                    p.Brand = Console.ReadLine();

                    Console.Write("Adet: ");
                    int.TryParse(Console.ReadLine(), out int a);
                    p.UnitNumber = a;

                    sm.Add(p);
                }
                else if (s == "2")
                {
                    sm.List();
                }
                else if (s == "3")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız!");
                }
            }
        }
    }
}