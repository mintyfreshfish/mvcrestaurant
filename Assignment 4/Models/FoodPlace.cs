using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{
    public class FoodPlace
    {
        FoodPlace(int rank, string name, string address)
        {
            Rank = rank;
            Name = name;
            Address = address;
        }

        public int Rank { get; }
        public string Name { get; set; }
        public string? Fave { get; set; } = "It's All Tasty!";
        public string Address { get; set; }
        public string? Phone { get; set; }
        public string? WebLink { get; set; } = "Coming Soon";

        public static FoodPlace[] GetFoodPlaces()
        {
            FoodPlace fp1 = new FoodPlace(1, "Burgers for Barbers", "Up the Hill")
            {
                Fave = "\"The Clean Cut\"",
                Phone = "456-123-0947",
                WebLink = "www.burgersforbarbers.com"
            };

            FoodPlace fp2 = new FoodPlace(2, "The Monkey's Foot", "294 Uptree Ave. Suite #7")
            {
                Fave = "Banana Smoothie",
                Phone = "889-456-2341",
                WebLink = "www.smellssogross.com"
            };

            FoodPlace fp3 = new FoodPlace(3, "Donkey Hoagie", "3915 Spain St.")
            {
                Fave = "\"Stinky Foot\"",
                Phone = "333-748-1029",
                WebLink = "www.thatmandatoryspanishnovel.com"
            };

            FoodPlace fp4 = new FoodPlace(4, "That One Taco Truck", "Start straight, then turn left at the second corner, circle back a bit until you find the weird graffiti, then look to your right")
            {
            };

            FoodPlace fp5 = new FoodPlace(5, "Porks and Rec", "9034 Pawnee St.")
            {
                Fave = "\"The Big Pig\"",
                Phone = "294-038-3894",
                WebLink = "www.aprilandy5ever.com"
            };

            return new FoodPlace[] { fp1, fp2, fp3, fp4, fp5 };
        }
    }
}
