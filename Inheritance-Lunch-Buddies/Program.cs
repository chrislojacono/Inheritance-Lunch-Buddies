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

        public string Eat()
        {
            var restaurant = new Restaurant();
            var randomRestaurant = restaurant.Name;
            Console.WriteLine($"{FirstName} {LastName} is at {randomRestaurant}");
            return randomRestaurant;
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office");
        }
        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var randomRestaurant = restaurant.Name;
            Console.WriteLine($"{FirstName} {LastName} is at {randomRestaurant}");
            foreach (var companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}");
            }
        }
        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var randomRestaurant = restaurant.Name;
            Console.WriteLine($"{FirstName} {LastName} is at {randomRestaurant} eating {food} with {companions[0].FirstName}, {companions[1].FirstName}, {companions[2].FirstName}, and {companions[3].FirstName}");
        }
    }
    class Restaurant
    {
        public string Name { get; set; }
        private List<string> _restaurantNames = new List<string> { "Maggianos", "Rolf and Daughters", "Bricktops", "Mas Tacos", "Camino Chino", "Desanos", "Taquieria Azteca" };

        public Restaurant()
        {
            Name = this.RandomRestaurantGenerator();
        }

        public string RandomRestaurantGenerator()
        {
            var random = new Random();
            int index = random.Next(_restaurantNames.Count);
            return _restaurantNames[index];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var restaurant1 = new Restaurant();
            Console.WriteLine($"Tonight we are eating at {restaurant1.Name}");

            var myBuddy1 = new LunchBuddy("Chase", "Moss");
            myBuddy1.Eat();

            var myBuddy2 = new LunchBuddy("Curtis", "Blow");
            var myBuddy3 = new LunchBuddy("Rodger", "Cook");
            var myBuddy4 = new LunchBuddy("Gabby", "Irwing");
            var myBuddy5 = new LunchBuddy("Meredith", "Broadway");

            var companions = new List<LunchBuddy> { myBuddy1, myBuddy2, myBuddy3, myBuddy4, myBuddy5 };

            myBuddy5.Eat(companions);
            myBuddy5.Eat("tortellini", companions);
        }
    }
}
