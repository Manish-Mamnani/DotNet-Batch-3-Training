namespace Day8Collection
{
    internal class Program
    {
        public void ArrayDemoFunc()
        {
            //Simple array of Primitive Type
            int[] arrNum;
            arrNum = new int[5];

            int[] arrNum1 = new int[3] {1,2,3 };

            string[] cities =
            {
                "Delhi",
                "Chennai",
                "Trichi",
                "Agra",
                "Pune",
                "Agartala",
                "Pilibhit"
            };

            foreach(var item in cities)
            {
                if (item.Length <= 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(item);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(item);
                }
            }
        }
        static void Main(string[] args)
        {
            //Program pObj = new Program();
            //pObj.ArrayDemoFunc();

            Customer[] custArray;
            custArray = new Customer[1];

            //Init the customer object
            custArray[0] = new Customer();
            custArray[0].ID = 101;
            custArray[0].Name = "Manish";

            //Init the address class
            custArray[0].BillingAddress = new Address();

            custArray[0].BillingAddress.FlatNo = "1802";
            custArray[0].BillingAddress.BuildingName = "Sky Tower";
            custArray[0].BillingAddress.Street = "Bhumar Chowk";
            custArray[0].BillingAddress.City = "Pune";

            custArray[0].ShipingAddress = custArray[0].BillingAddress;
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}
