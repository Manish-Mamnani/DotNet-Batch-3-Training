using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegateDemo
{
    //MultiCast Delegate
    public delegate void GreetMsg(string msg);

    //UniCast Delegate
    public delegate int Calcuation(int num1, int num2);

    class Hindi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhat"+userName);
        }

    }

    class Tamil
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Vanakkam" + userName);
        }
    }

    class Telugu
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskaram" + userName);
        }

    }

    class English
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Good Morning" + userName);
        }

    }
    class Marathi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhat" + userName);
        }

    }
    public class DelegateDemo
    {
        public static void DelegateDemoMain()
        {
            Tamil tObj = new Tamil();
            GreetMsg GreetInTamil = new GreetMsg(tObj.WelcomeMsg);

            GreetInTamil("Alok");

        }

    }
}
