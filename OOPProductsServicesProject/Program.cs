using System;

namespace OOPProductsServicesProject {
    class Program {
        static void Main(string[] args) {
            Product plain = new Product(10m, 2500);
            decimal plainSales = plain.ProductSales();

            Product decent = new Product(25, 1500);

            Product ultra = new Product(44.99m, 25);

            Services light = new Services(70, 125);
            Services standard = new Services(100, 125);
            Services heavy = new Services(145, 40);

        }
    }
}
