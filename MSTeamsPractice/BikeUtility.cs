using System;

namespace MSTeamsPractice;

public class BikeUtility
{

    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count + 1;

        Bike bike = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };

        Program.bikeDetails.Add(key, bike);
    }

    public SortedDictionary<string,List<Bike>> GroupBikesbyBrand()
    {
        SortedDictionary<string,List<Bike>> groupedBikes = new SortedDictionary<string,List<Bike>>();

        foreach(var item in Program.bikeDetails)
        {
            if (!groupedBikes.ContainsKey(item.Value.Brand))
            {
                groupedBikes[item.Value.Brand] = new List<Bike>();
            }

            groupedBikes[item.Value.Brand].Add(item.Value);
        }

        return groupedBikes;
    }
}
