using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProductsServicesProject {
    class Membership : Deliverable {
        public int Fee { get; set; }
        public int Units { get; set; }

        public decimal CalcSales() {
            return (Fee * Units) / 2;
        }

        public Membership (int fee, int Unit) {
            this.Fee = fee;
            this.Units = Unit;
        }
    }
}
