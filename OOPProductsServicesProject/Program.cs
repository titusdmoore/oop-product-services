using System;

namespace OOPProductsServicesProject {
    class Program {
        static void Main(string[] args) {
            Product plain = new Product(10m, 2500);
            var plainSales = plain.ProductSales();

            Product decent = new Product(25, 1500);
            var decentSales = decent.ProductSales();

            Product ultra = new Product(50m, 1000);
            var ultraSales = ultra.ProductSales();

            var productSales = ultraSales + decentSales + plainSales;

            Services light = new Services(25, 1000);
            var lightSales = light.ServicesSales();
            Services standard = new Services(50, 550);
            var standardSales = standard.ServicesSales();
            Services heavy = new Services(100, 750);
            var heavySales = heavy.ServicesSales();

            var serviceSales = lightSales + standardSales + heavySales;

            var totalSales = Deliverable.GetSales(productSales, serviceSales);
            Console.WriteLine(totalSales);

        }
    }
}
