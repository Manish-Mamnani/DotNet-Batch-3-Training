using System;
using System.Collections.Generic;
using System.Text;

namespace KhataAssignment
{
    public class Khata
    {

        public Dictionary<string, int> Record { get; private set; }

        private Dictionary<int, int> RepeatedAmount { get; set; }

        public Khata()
        {
        }

        public Khata(Dictionary<string, int> record)
        {
            Record = new Dictionary<string, int>();
            RepeatedAmount = new Dictionary<int, int>();
            Record = record;
        }

        public int getTotal()
        {
            int totalAmount = 0;

            foreach(var item in Record)
            {
                totalAmount += item.Value;
            }

            return totalAmount;

        }

        public int getRepeatAmount()
        {
            RepeatedAmount.Clear();
            int repeatAmount = 0;

            foreach(var record in Record)
            {
                if (RepeatedAmount.ContainsKey(record.Value))
                {
                    RepeatedAmount[record.Value] += 1;
                }
                else
                {
                    RepeatedAmount.Add(record.Value, 1);
                }
            }

            foreach(var item in RepeatedAmount)
            {
                if(item.Value > 1)
                {
                    repeatAmount++;
                }
            }

            return repeatAmount;
        }

        public void AddItem(string itemName, int amount)
        {
            if (Record.ContainsKey(itemName))
            {
                Console.WriteLine("Item is already in your khata!");
            }
            else
            {
                Record.Add(itemName, amount);
            }
        }

    }
}
