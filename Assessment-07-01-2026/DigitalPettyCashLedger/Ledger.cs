using System;

namespace DigitalPettyCashLedger
{
    public class Ledger<T> where T : Transaction
    {
        List<T> transactionHistory;

        public Ledger()
        {
            transactionHistory = new List<T>();
        }
        
        public void AddEntry(T entry)
        {
            transactionHistory.Add(entry);
        }

        public List<T> GetTransactionByDate(DateTime date)
        {
            List<T> result = new List<T>();

            foreach (var t in transactionHistory)
            {
                if(t.Date.Date == date.Date)
                {
                    result.Add(t);
                }
            }

            return result;
        }

        public double CalculateTotal()
        {
            double total = 0;

            foreach(var t in transactionHistory)
            {
                total += t.Amount;
            }

            return total;
        }

        public List<T> GetAll()
        {
            return transactionHistory;
        }

    }
}