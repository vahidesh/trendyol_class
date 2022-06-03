using System;
using System.Collections.Generic;
using System.Text;

namespace trendyol_class
{
    class Order
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public int SerialNumber { get; set; }
        public string ShippingAdress { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public List<string> OrderHistory { get; set; }
        public string DeliveryTrackingInf { get; set; }
    }
}
