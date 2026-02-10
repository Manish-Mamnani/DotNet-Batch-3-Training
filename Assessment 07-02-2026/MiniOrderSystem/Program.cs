using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOrderSystem
{
    public class Program
    {
        public Dictionary<Product,int> cart = null;
        public void AddToCart(Product p, Customer c, int Quantity)
        {
            cart.Add(p,Quantity);
            Console.WriteLine("\n---Prodcut added successfully---\n");
        }

        public void PlaceOrder(Customer c)
        {
            int orderid;
            int ordercount = c.Orders.Count;
            if (ordercount == 0)
            {
                orderid = 10001;
            }
            else
            {
                orderid = c.Orders[ordercount - 1].OrdId + 1;
            }

            List<OrderItem> ordList = new List<OrderItem>();

            foreach(var item in cart)
            {
                if(item.Key.Stock < item.Value)
                {
                    throw new InvalidOrderException("Order quantity exceeds avaialble stock");
                }
                ordList.Add(new OrderItem()
                {
                    OrdId = orderid,
                    Quantity = item.Value,
                    ProdId = item.Key.ProdId,
                });
            }

            Order order = new Order()
            {
                OrdId = orderid,
                CustId = c.CustId,
                OrderItems = ordList
            };

            c.Orders.Add(order);

            Console.WriteLine("\n----Order Placed Successfully!---\n");

        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProdId = 1,
                    ProdName = "Laptop",
                    ProdPrice = 65000,
                    Stock = 10
                },
                new Product
                {
                    ProdId = 2,
                    ProdName = "Wireless Mouse",
                    ProdPrice = 1500,
                    Stock = 50
                },
                new Product
                {
                    ProdId = 3,
                    ProdName = "Keyboard",
                    ProdPrice = 2500,
                    Stock = 30
                },
                new Product
                {
                    ProdId = 4,
                    ProdName = "Headphones",
                    ProdPrice = 4000,
                    Stock = 20
                }
            };

            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                    CustId = 101,
                    CustName = "Amit Sharma"
                },
                new Customer
                {
                    CustId = 102,
                    CustName = "Neha Verma"
                },
                new Customer
                {
                    CustId = 103,
                    CustName = "Rahul Mehta"
                }
            };


            do
            {
                Console.WriteLine("=============Mini Order System=============\n");

                Console.WriteLine("Enter Customer ID : ");
                int customerId = Int32.Parse(Console.ReadLine());
                int choice = 0;
                do
                {
                    var c = customers.Find(x => x.CustId == customerId);
                    Console.WriteLine("\n=============Mini Order System=============\n");
                    Console.WriteLine($"=========Welcome {c.CustName}=========\n");

                    Console.WriteLine("1. Add to cart");
                    Console.WriteLine("2. Place order");
                    Console.WriteLine("3. Logout");

                    Console.WriteLine("\nEnter your choice: ");
                    choice = Int32.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                break;
                            }

                        case 2:
                            {
                                break;
                            }

                        case 3:
                            {
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }



                }while (choice != 3);

                break;

            }while (true);

        }
    }
}
