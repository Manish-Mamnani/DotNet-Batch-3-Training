using System;

namespace DigitalPettyCashLedger
{
    public class ExpenseTransaction : Transaction
    {
        #region Properties

        public string Category{ get; set; }

        #endregion

        #region Methods

        public override string GetSummary()
        {
            return
                "   Expense Transaction Summary   \n" +
                $"ID: {Id}\n" +
                $"Date: {Date}\n" +
                $"Amount: {Amount}\n" +
                $"Description: {Description}\n" +
                $"Category: {Category}\n";
        }

        #endregion
    }
}