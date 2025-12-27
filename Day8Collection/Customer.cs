using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Day8Collection
{
    public class Address
    {
        public string FlatNo {  get; set; }
        public string BuildingName {  get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
    internal class Customer
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShipingAddress { get; set; }
    }
}
