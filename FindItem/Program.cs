using System;
using System.Collections.Generic;

namespace FindItem{
	public class Program{
		public static SortedDictionary<string,long> itemDetails = new SortedDictionary<string,long>();
		
		public SortedDictionary<string,long> FindItemDetails(long soldCount){
			SortedDictionary<string,long> result = new SortedDictionary<string,long>();
			
			foreach(var item in itemDetails){
				if(item.Value == soldCount){
					result.Add(item.Key,item.Value);
				}
			}
			return result;		
		}

		public List<string> FindMinandMaxSoldItems(){
			List<string> result = new List<string>();
			string minimum = "";
			string maximum = "";
			long minValue = long.MaxValue;
			long maxValue = 0;
			
			foreach(var item in itemDetails){
				if(item.Value <= minValue){
					minValue = item.Value;
					minimum = item.Key;
				}

				if(item.Value >= maxValue){
					maxValue = item.Value;
					maximum = item.Key;
				}
			}

			result.Add(minimum);
			result.Add(maximum);
			return result;
		}

		public Dictionary<string,long> SortByCount(){
			Dictionary<string,long> result = new Dictionary<string,long>();

			foreach(var item in itemDetails){
				result.Add(item.Key,item.Value);
			}

            result = result.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

			return result;
		}

		public static void Main(string[] args){
			Program pObj = new Program();

			Console.Write("Enter the number of items: ");
			int n = Int32.Parse(Console.ReadLine());
			
			for(int i=0;i<n;i++){
				Console.Write("\nEnter name of the item: ");
				string name = Console.ReadLine();
				
				Console.Write("Enter the sold count: ");
				long count = long.Parse(Console.ReadLine());

				Program.itemDetails.Add(name,count);
			}

			SortedDictionary<string,long> foundItems = pObj.FindItemDetails(10);

			if(foundItems.Count == 0){
				Console.WriteLine("Invalid sold count");
			}
			else{
				Console.WriteLine("Items with sold count 10: ");
				foreach(var item in foundItems){
					Console.WriteLine($"{item.Key}");
				}
			}

			List<string> maxAndMin = pObj.FindMinandMaxSoldItems();
			Console.WriteLine($"Minimum Sold Item: {maxAndMin[0]}");
			Console.WriteLine($"Maximum Sold Item: {maxAndMin[1]}");

			Dictionary<string,long> orderedList = pObj.SortByCount();
			
			Console.WriteLine("Item Details sorted by sold count: ");	
			foreach(var item in orderedList){
				Console.WriteLine($"Item name: {item.Key}\t Sold Count: {item.Value}");
			}
		}
	}
}