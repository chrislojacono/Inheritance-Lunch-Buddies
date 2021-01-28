# Inheritance-Lunch-Buddies
1. Create a new class to represent a LunchBuddy.
    1. Its constructor should accept two parameters.
        - First name of your lunch buddy
        - Last name of your lunch buddy
2. Create a new class to represent a Restaurant.
    1. It should have a private property that contains a List of restaurant names. `List<string>`
    2. Its constructor should pick a random restaurant name and assign it to a public property called "Name"
3. Define a method on your LunchBuddy class named `eat()` that will allow it to be invoked with the following four signatures.
    1. `eat()` - Will select a random restaurant name from a list of strings (List of restaurant names can come from anywhere), print to console that the buddy is at that restaurant, and also return the restaurant.
    2. `eat(string food)` - Will output that the buddy ate that specific food at the office.
    3. `eat(List<LunchBuddy> companions)` - Will select a random restaurant name from a list of strings, print to console that the buddy is at that restaurant, and also output the first name of each lunch buddy in the specified list.
    4. `eat(string food, List<LunchBuddy> companions)` - Will select a random restaurant name from a list of strings, print to console that the buddy at that restaurant, and ordered the specified food, with the first name of the teammates specified in the list.
