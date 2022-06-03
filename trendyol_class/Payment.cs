using System;
using System.Collections.Generic;
using System.Text;

namespace trendyol_class
{
    class Payment: Card

    {
        public int Amount { get; set; }
        public string Type { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Currency { get; set; }


    }
}
