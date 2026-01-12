using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace EventDelegateDemo
{
    interface IBank
    {
        bool OpenAct(string details);

        List<string> GenStatement();
    }

    interface RBI
    {

    }

    public class HDFC : IBank
    {
        public delegate void Transaction(int actNo, string date, int amount);
        public List<string> GenStatement()
        {
            throw new NotImplementedException();
        }

        public bool OpenAct(string details)
        {
            throw new NotImplementedException();
        }
    }

    class Axis : IBank
    {
        public List<string> GenStatement()
        {
            throw new NotImplementedException();
        }

        public bool OpenAct(string details)
        {
            throw new NotImplementedException();
        }
    }

    class HDFCJalandhar : HDFC
    {

    }
    public class EventDemo
    {
        public static void EventDemoMain()
        {
            HDFCJalandhar hdfcJal = new HDFCJalandhar();
        }
    }
}
