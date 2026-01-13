namespace EventDrivenPhoneCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneCall phoneObj = new PhoneCall();

            phoneObj.MakeAPhoneCall(true);
            Console.WriteLine(phoneObj.Message); 

            phoneObj.MakeAPhoneCall(false);
            Console.WriteLine(phoneObj.Message);
        }
    }
}
