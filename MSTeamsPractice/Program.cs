using System;
using MSTeamsPractice;

class Program
    {
        // Given dictionary
        public static SortedDictionary<int, Bike> bikeDetails =new SortedDictionary<int, Bike>();

        static void Main(string[] args)
        {

            BikeUtility bikeUtilityObj = new BikeUtility();
            int choice;

            do
            {

                Console.WriteLine("1. Add Bike Details");
                Console.WriteLine("2. Group Bikes By Brand");
                Console.WriteLine("3. Exit\n");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                        Console.WriteLine("Enter the model");
                        string model = Console.ReadLine();

                        Console.WriteLine("Enter the brand");
                        string brand = Console.ReadLine();

                        Console.WriteLine("Enter the price per day");
                        int price = int.Parse(Console.ReadLine());

                        bikeUtilityObj.AddBikeDetails(model, brand, price);
                        Console.WriteLine("Bike details added successfully\n");
                        break;

                    case 2:
                        var grouped = bikeUtilityObj.GroupBikesbyBrand();

                        foreach (var item in grouped)
                        {
                            Console.WriteLine(item.Key);

                            foreach (var bike in item.Value)
                            {
                                Console.WriteLine(bike.Model);
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        break;
            }
                
            }while(choice != 3);
            
        }
    }
