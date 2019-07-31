using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProductsServicesProject {
    class Deliverable {
        public int id { get; set; }
        public string name { get; set; }

        public static decimal GetSales(decimal products, int services) {
            return products + services;
        }
    }
}
