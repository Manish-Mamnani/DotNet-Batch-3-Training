using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleInventorySystem_Practice.Models
{
        /// <summary>
        /// TODO: Implement grocery product class
        /// </summary>
        public class GroceryProduct : Product
        {
            // TODO: Add these properties
            // - ExpiryDate (DateTime)
            // - IsPerishable (bool)
            // - Weight (double)
            // - StorageTemperature (string) - e.g., "Room temperature", "Refrigerated", "Frozen"

            public DateTime ExpiryDate {  get; set; }
            public bool IsPerishable { get; set; }
            public double Weight { get; set; }
            public string StorageTemperature {  get; set; }

            /// <summary>
            /// TODO: Override GetProductDetails for grocery items
            /// Include expiry information
            /// </summary>
            public override string GetProductDetails()
            {
            // TODO: Implement
                return $"Name: {Name}, Price: {Price}, Weight: {Weight}, Expiry Date: {ExpiryDate}, Storage Temperature: {StorageTemperature}";
            }

            /// <summary>
            /// TODO: Check if product is expired
            /// </summary>
            public bool IsExpired()
            {
                // TODO: Compare ExpiryDate with current date
                if(DateTime.Now > ExpiryDate)
                {
                    return true;
                }
                return false;
            }

            /// <summary>
            /// TODO: Calculate days until expiry
            /// Return negative if expired
            /// </summary>
            public int DaysUntilExpiry()
            {
                // TODO: Calculate days difference
                TimeSpan diff = DateTime.Now - ExpiryDate;
                return diff.Days;
            }

            /// <summary>
            /// TODO: Override CalculateValue to apply discount for near-expiry items
            /// Apply 20% discount if within 3 days of expiry
            /// </summary>
            public override decimal CalculateValue()
            {
                // TODO: Apply discount logic if near expiry
                TimeSpan diff = ExpiryDate - DateTime.Now;
                decimal finalPrice = Price;
                if(diff.Days <= 3)
                {
                    finalPrice = Price * 0.80m;
                }
                return finalPrice;
            }
        }
}
