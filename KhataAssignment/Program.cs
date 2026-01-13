namespace KhataAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> record = new Dictionary<string, int>()
            {
                {"Milk",100 },
                {"Tea",50 },
                {"Coffee",100 },
                {"Sugar",50 },
                {"Salt",200 }
            };

            Khata khataObj = new Khata(record);

            int total = khataObj.getTotal();
            Console.WriteLine($"Total Amount: {total}");

            int repeatedAmount = khataObj.getRepeatAmount();
            Console.WriteLine($"Repeated Amount Count: {repeatedAmount}");

        }
    }
}
