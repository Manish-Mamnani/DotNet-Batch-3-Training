// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CustomPropertyDemo
{
    //struct Customer1 //value type(no memory allocation on heap) in Csharp
    //    //structure will never carry destructor
    //{

    //    //public int ID { get; set; } = 0;
    //    //public string Name { get; set; }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //init customer object

            Customer custObj = new Customer();

            custObj.CustID = 101;
            custObj.Name = "Alok";

            //init customer object
            custObj.ShippingAddr = new Address();

            custObj.ShippingAddr.FlatNo = 1802;
            custObj.ShippingAddr.BuildingName = "Sky Tower";
            custObj.ShippingAddr.Street = "Lane 1";
            custObj.ShippingAddr.Locality = "Wakad";
            custObj.ShippingAddr.City = "Mumbai";

            //1 customer have many orders
            custObj.MyOrders = new List<Orders>()
            {
                new Orders{ OrderID=1124,OrderDate=new DateTime(2001,12,22),Amount=14000},
                new Orders{ OrderID=2076,OrderDate=new DateTime(2002,1,15),Amount=24000},
                new Orders{ OrderID=8540,OrderDate=new DateTime(2004,12,05),Amount=18000},
                new Orders{ OrderID=1196,OrderDate=new DateTime(2007,08,23),Amount=32000},
                new Orders{ OrderID=3251,OrderDate=new DateTime(2012,11,21),Amount=10000},

            };
        }
    }
}