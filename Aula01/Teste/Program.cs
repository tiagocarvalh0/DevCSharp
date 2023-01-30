using System;

namespace Teste {

    struct Product {

        public Product(int id, string name, double price) {
            Id = id;
            Name = name;
            Price = price;

        }

        public int Id;
        public string Name;
        public double Price;

        public double PriceInDolar(double Dolar) {

            return Price * Dolar;
        } 
    }

    class Program {
        static void Main(string[] args) {
            Product mouse = new Product(1, "Mouse", 299.78);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }
    }
}
