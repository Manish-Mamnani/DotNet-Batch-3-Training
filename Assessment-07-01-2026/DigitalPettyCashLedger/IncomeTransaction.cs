using System;

namespace DigitalPettyCashLedger
{
    public class IncomeTransaction : Transaction
    {
        #region Properties

        public string Source{ get; set; }

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
                $"Source: {Source}\n";
        }

        #endregion
    }
}