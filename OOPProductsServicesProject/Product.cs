using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProductsServicesProject {
    class Product : Deliverable {
        public decimal price { get; set; }
        public int units { get; set; }

        public Product(decimal amount, int times) {
            this.price = amount;
            this.units = times;
        }

        public decimal ProductSales (){
            return this.price * this.units;
        }
    }
}
