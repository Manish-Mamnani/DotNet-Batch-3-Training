using System.Globalization;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DirectoryDemo dirObj = new DirectoryDemo();

            //string directoryName = @"D:\Capgemini\LPU";
            //dirObj.DirectoryDemoFunc(directoryName);

            //dirObj.DriveInfoFunc("D:\\");

            //dirObj.PathDemoFunc();

            FileStreamDemo fsDemoObj = new FileStreamDemo();

            //fsDemoObj.CreateFile(@"D:\Capgemini\SampleData.txt");

            fsDemoObj.ReadFile(@"D:\Capgemini\MeetingDemo\Program.cs");

        }
    }
}
