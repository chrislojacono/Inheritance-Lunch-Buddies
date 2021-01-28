using System;
using System.Collections.Generic;
namespace Inheritance_Lunch_Buddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }
    }
    class Restaurant
    {
        public string Name { get; set; }
        private List<string> _restaurantNames = new List<string>{ "Maggianos", "Rolf and Daughters", "Bricktops", "Mas Tacos", "Camino Chino", "Desanos", "Taquieria Azteca"};

        public Restaurant()
        {
            Name = this.RandomRestaurantGenerator(_restaurantNames); 
        }

        public string RandomRestaurantGenerator(List<string> listOfRestaurants)
        {
            var random = new Random();
            int index = random.Next(listOfRestaurants.Count);
            return listOfRestaurants[index];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var restaurant1 = new Restaurant();
            Console.WriteLine($"Tonight we are eating at {restaurant1.Name}");
        }
    }
}
