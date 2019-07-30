using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProductsServicesProject {
    class Services : Deliverable {
        public int rate { get; set; }
        public int hours { get; set; }

        public Services(int Rate, int Hours) {
            this.rate = Rate;
            this.hours = Hours;
        }
    }
}
