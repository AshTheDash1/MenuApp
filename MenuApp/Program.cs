using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuApp
{
    internal class Program
    {
        public static string UserChoice { get; set; }

        private static void Main(string[] args)
        {
            string OrderType = "";
            //string UserChoice = "";


            List<MenuItem> MenuItems = new List<MenuItem>
            {
                new MenuItem {Name = "Jotos Fingers", Cost = 3.99, Type = "Appetizer", ItemNumber = 0},
                new MenuItem {Name = "Side of Ranch", Cost = .50, Type = "Appetizer", ItemNumber = 1},
                new MenuItem {Name = "Side of Sauce", Cost = .50, Type = "Appetizer", ItemNumber = 2},
                new MenuItem {Name = "Cheese Sticks", Cost = 5.49, Type = "Appetizer", ItemNumber = 3},
                new MenuItem {Name = "Garlic Cheese Bread", Cost = 4.99, Type = "Appetizer", ItemNumber = 4},
                new MenuItem {Name = "Pizza Bites", Cost = 5.99, Type = "Appetizer", ItemNumber = 5},
                new MenuItem {Name = "Fried Mushrooms", Cost = 5.99, Type = "Appetizer", ItemNumber = 6},
                new MenuItem {Name = "Jalapeño Poppers", Cost = 5.99, Type = "Appetizer", ItemNumber = 7},
                new MenuItem {Name = "Mac-n-Cheese Bites", Cost = 5.99, Type = "Appetizer", ItemNumber = 8},
                new MenuItem {Name = "Cheese", Cost = 8.49, Type = "Pizza", Size = "Small", ItemNumber = 9},
                new MenuItem {Name = "Cheese", Cost = 10.99, Type = "Pizza", Size = "Medium", ItemNumber = 10},
                new MenuItem {Name = "Cheese", Cost = 11.99, Type = "Pizza", Size = "Large", ItemNumber = 11},
                new MenuItem {Name = "Cheese", Cost = 14.99, Type = "Pizza", Size = "X-Large", ItemNumber = 12},
                new MenuItem {Name = "One Topping Pizza", Cost = 9.49, Type = "Pizza", Size = "Small", ItemNumber = 13},
                new MenuItem {Name = "One Topping Pizza", Cost = 12.49, Type = "Pizza", Size = "Medium", ItemNumber = 14},
                new MenuItem {Name = "One Topping Pizza", Cost = 13.99, Type = "Pizza", Size = "Large", ItemNumber = 15},
                new MenuItem {Name = "One Topping Pizza", Cost = 17.49, Type = "Pizza", Size = "X-Large", ItemNumber = 16},
                new MenuItem {Name = "Additional Toppings", Cost = 1.00, Type = "Pizza", ItemNumber = 17},
                new MenuItem {Name = "Additional Toppings", Cost = 1.50, Type = "Pizza", ItemNumber = 18},
                new MenuItem {Name = "Additional Toppings", Cost = 2.00, Type = "Pizza", ItemNumber = 19},
                new MenuItem {Name = "Additional Toppings", Cost = 2.50, Type = "Pizza", ItemNumber = 20},
                new MenuItem {Name = "Joto's Special", Cost = 12.49, Type = "Pizza", Size = "Small", ItemNumber = 21},
                new MenuItem {Name = "Joto's Special", Cost = 15.99, Type = "Pizza", Size = "Medium", ItemNumber = 22},
                new MenuItem {Name = "Joto's Special", Cost = 18.99, Type = "Pizza", Size = "Large", ItemNumber = 23},
                new MenuItem {Name = "Joto's Special", Cost = 22.99, Type = "Pizza", Size = "X-Large", ItemNumber = 24},
                new MenuItem {Name = "Joto's Veggie", Cost = 12.49, Type = "Pizza", Size = "Small", ItemNumber = 25},
                new MenuItem {Name = "Joto's Veggie", Cost = 15.99, Type = "Pizza", Size = "Medium", ItemNumber = 26},
                new MenuItem {Name = "Joto's Veggie", Cost = 18.99, Type = "Pizza", Size = "Large", ItemNumber = 27},
                new MenuItem {Name = "Joto's Veggie", Cost = 22.99, Type = "Pizza", Size = "X-Large", ItemNumber = 28},
                new MenuItem {Name = "Joto's Deluxe", Cost = 13.49, Type = "Pizza", Size = "Small", ItemNumber = 29},
                new MenuItem {Name = "Joto's Deluxe", Cost = 16.99, Type = "Pizza", Size = "Medium", ItemNumber = 30},
                new MenuItem {Name = "Joto's Deluxe", Cost = 19.99, Type = "Pizza", Size = "Large", ItemNumber = 31},
                new MenuItem {Name = "Joto's Deluxe", Cost = 23.99, Type = "Pizza", Size = "X-Large", ItemNumber = 32},
                new MenuItem {Name = "Joto's Meat", Cost = 13.49, Type = "Pizza", Size = "Small", ItemNumber = 33},
                new MenuItem {Name = "Joto's Meat", Cost = 15.99, Type = "Pizza", Size = "Medium", ItemNumber = 34},
                new MenuItem {Name = "Joto's Meat", Cost = 19.99, Type = "Pizza", Size = "Large", ItemNumber = 35},
                new MenuItem {Name = "Joto's Meat", Cost = 23.99, Type = "Pizza", Size = "X-Large", ItemNumber = 36},
                new MenuItem {Name = "Joto's Steak", Cost = 12.49, Type = "Pizza", Size = "Small", ItemNumber = 37},
                new MenuItem {Name = "Joto's Steak", Cost = 15.99, Type = "Pizza", Size = "Medium", ItemNumber = 38},
                new MenuItem {Name = "Joto's Steak", Cost = 18.99, Type = "Pizza", Size = "Large", ItemNumber = 39},
                new MenuItem {Name = "Joto's Steak", Cost = 22.99, Type = "Pizza", Size = "X-Large", ItemNumber = 40},
                new MenuItem {Name = "Joto's Hawaiian", Cost = 10.49, Type = "Pizza", Size = "Small", ItemNumber = 41},
                new MenuItem {Name = "Joto's Hawaiian", Cost = 13.99, Type = "Pizza", Size = "Medium", ItemNumber = 42},
                new MenuItem {Name = "Joto's Hawaiian", Cost = 15.99, Type = "Pizza", Size = "Large", ItemNumber = 43},
                new MenuItem {Name = "Joto's Hawaiian", Cost = 19.99, Type = "Pizza", Size = "X-Large", ItemNumber = 44},
                new MenuItem {Name = "Joto's Buffalo Chicken", Cost = 11.49, Type = "Pizza", Size = "Small", ItemNumber = 45},
                new MenuItem {Name = "Joto's Buffalo Chicken", Cost = 14.99, Type = "Pizza", Size = "Medium", ItemNumber = 46},
                new MenuItem {Name = "Joto's Buffalo Chicken", Cost = 16.99, Type = "Pizza", Size = "Large", ItemNumber = 47},
                new MenuItem {Name = "Joto's Buffalo Chicken", Cost = 20.99, Type = "Pizza", Size = "X-Large", ItemNumber = 48},
                new MenuItem {Name = "Thick Pan(add to existing total)", Cost = 2.00, Type = "Pizza", Size = "Small", ItemNumber = 49},
                new MenuItem {Name = "Thick Pan(add to existing total)", Cost = 2.00, Type = "Pizza", Size = "Large", ItemNumber = 50},
                new MenuItem {Name = "Boneless Wings", Cost = 6.99, Type = "Wings", Size = "6", ItemNumber = 51},
                new MenuItem {Name = "Boneless Wings", Cost = 12.99, Type = "Wings", Size = "12", ItemNumber = 52},
                new MenuItem {Name = "Boneless Wings", Cost = 19.99, Type = "Wings", Size = "20", ItemNumber = 53},
                new MenuItem {Name = "Bone-in Wings", Cost = 6.99, Type = "Wings", Size = "6", ItemNumber = 54},
                new MenuItem {Name = "Bone-in Wings", Cost = 12.99, Type = "Wings", Size = "12", ItemNumber = 55},
                new MenuItem {Name = "Bone-in Wings", Cost = 19.99, Type = "Wings", Size = "20", ItemNumber = 56},
                new MenuItem {Name = "Calzone", Cost = 7.99, Type = "Special", ItemNumber = 57},
                new MenuItem {Name = "Chicken Tenders", Cost = 8.99, Type = "Special", ItemNumber = 58},
                new MenuItem {Name = "French Fries", Cost = 2.99, Type = "Special", Size = "Small", ItemNumber = 59},
                new MenuItem {Name = "French Fries", Cost = 4.99, Type = "Special", Size = "Large", ItemNumber = 60},
                new MenuItem {Name = "Tater Tots", Cost = 2.99, Type = "Special", ItemNumber = 61},
                new MenuItem {Name = "Onion Rings", Cost = 5.49, Type = "Special", ItemNumber = 62},
                new MenuItem {Name = "Original Roll-A-Dough", Cost = 8.99, Type = "Special", ItemNumber = 63},
                new MenuItem {Name = "Chicken Roll-A-Dough", Cost = 8.99, Type = "Special", ItemNumber = 64},
                new MenuItem {Name = "Meatball Roll-A-Dough", Cost = 8.99, Type = "Special", ItemNumber = 65},
                new MenuItem {Name = "Pepperoni Roll-A-Dough", Cost = 8.99, Type = "Special", ItemNumber = 66},
                new MenuItem {Name = "Steak Roll-A-Dough", Cost = 8.99, Type = "Special", ItemNumber = 67},
                new MenuItem {Name = "Veggie Roll-A-Dough", Cost = 8.99, Type = "Special", ItemNumber = 68},
                new MenuItem {Name = "CheeseBurger Roll-A-Dough", Cost = 8.99, Type = "Special", ItemNumber = 69},
                new MenuItem {Name = "Super Roll-A-Dough", Cost = 8.99, Type = "Special", ItemNumber = 70},
                new MenuItem {Name = "Meat Lasanga", Cost = 10.49, Type = "Dinners", ItemNumber = 71},
                new MenuItem {Name = "Meat Ravioli", Cost = 10.29, Type = "Dinners", ItemNumber = 72},
                new MenuItem {Name = "Cheese Ravioli", Cost = 10.29, Type = "Dinners", ItemNumber = 73},
                new MenuItem {Name = "Spaghetti", Cost = 8.99, Type = "Dinners", ItemNumber = 74},
                new MenuItem {Name = "Ziti", Cost = 9.99, Type = "Dinners", ItemNumber = 75},
                new MenuItem {Name = "Chicken Parmesan", Cost = 10.49, Type = "Dinners", ItemNumber = 76},
                new MenuItem {Name = "Chicken Tenders with Chips", Cost = 5.99, Type = "Kids Menu", ItemNumber = 77},
                new MenuItem {Name = "Spaghetti with Garlic Bread", Cost = 4.99, Type = "Kids Menu", ItemNumber = 78},
                new MenuItem {Name = "Dough Dog with Chips", Cost = 4.99, Type = "Kids Menu", ItemNumber = 79},
                new MenuItem {Name = "Mini Cheese Pizza", Cost = 6.79, Type = "Kids Menu", ItemNumber = 80},
                new MenuItem {Name = "Antipasto Salad", Cost = 8.99, Type = "Salads", ItemNumber = 81},
                new MenuItem {Name = "Chef Salad", Cost = 8.99, Type = "Salads", ItemNumber = 82},
                new MenuItem {Name = "Turkey Chef Salad", Cost = 9.49, Type = "Salads", ItemNumber = 83},
                new MenuItem {Name = "Caesar Salad", Cost = 6.99, Type = "Salads", ItemNumber = 84},
                new MenuItem {Name = "Chicken Caesar Salad", Cost = 8.99, Type = "Salads", ItemNumber = 85},
                new MenuItem {Name = "Crunchy Chicken Salad", Cost = 9.29, Type = "Salads", ItemNumber = 86},
                new MenuItem {Name = "Chicken Strip Salad", Cost = 9.29, Type = "Salads", ItemNumber = 87},
                new MenuItem {Name = "Buffalo Chicken Salad", Cost = 9.29, Type = "Salads", ItemNumber = 88},
                new MenuItem {Name = "Greek Salad", Cost = 9.49, Type = "Salads", ItemNumber = 89},
                new MenuItem {Name = "Creamy Chicken Salad", Cost = 6.99, Type = "Salads", ItemNumber = 90},
                new MenuItem {Name = "Tuna Salad", Cost = 6.99, Type = "Salads", ItemNumber = 91},
                new MenuItem {Name = "Tossed Salad", Cost = 5.99, Type = "Salads", ItemNumber = 92},
                new MenuItem {Name = "Creamy Chicken", Cost = 5.79, Type = "Subs", Size = "6inch", ItemNumber = 93},
                new MenuItem {Name = "Creamy Chicken", Cost = 7.99, Type = "Subs", Size = "12inch", ItemNumber = 94},
                new MenuItem {Name = "Ham & Cheese", Cost = 5.79, Type = "Subs", Size = "6inch", ItemNumber = 95},
                new MenuItem {Name = "Ham & Cheese", Cost = 7.99, Type = "Subs", Size = "12inch", ItemNumber = 96},
                new MenuItem {Name = "Sausage", Cost = 5.79, Type = "Subs", Size = "6inch", ItemNumber = 97},
                new MenuItem {Name = "Sausage", Cost = 7.99, Type = "Subs", Size = "12inch", ItemNumber = 98},
                new MenuItem {Name = "Veggie", Cost = 5.79, Type = "Subs", Size = "6inch", ItemNumber = 99},
                new MenuItem {Name = "Veggie", Cost = 7.99, Type = "Subs", Size = "12inch", ItemNumber = 100},
                new MenuItem {Name = "Tuna", Cost = 5.79, Type = "Subs", Size = "6inch", ItemNumber = 101},
                new MenuItem {Name = "Tuna", Cost = 7.99, Type = "Subs", Size = "12inch", ItemNumber = 102},
                new MenuItem {Name = "Meatball", Cost = 5.79, Type = "Subs", Size = "6inch", ItemNumber = 103},
                new MenuItem {Name = "Meatball", Cost = 7.99, Type = "Subs", Size = "12inch", ItemNumber = 104},
                new MenuItem {Name = "BLT", Cost = 5.79, Type = "Subs", Size = "6inch", ItemNumber = 105},
                new MenuItem {Name = "BLT", Cost = 7.99, Type = "Subs", Size = "12inch", ItemNumber = 106},
                new MenuItem {Name = "Steak", Cost = 6.49, Type = "Subs", Size = "6inch", ItemNumber = 107},
                new MenuItem {Name = "Steak", Cost = 8.49, Type = "Subs", Size = "12inch", ItemNumber = 108},
                new MenuItem {Name = "Italian", Cost = 6.49, Type = "Subs", Size = "6inch", ItemNumber = 109},
                new MenuItem {Name = "Italian", Cost = 8.49, Type = "Subs", Size = "12inch", ItemNumber = 110},
                new MenuItem {Name = "BBQ Beef", Cost = 6.49, Type = "Subs", Size = "6inch", ItemNumber = 111},
                new MenuItem {Name = "BBQ Beef", Cost = 8.49, Type = "Subs", Size = "12inch", ItemNumber = 112},
                new MenuItem {Name = "Turkey Bacon", Cost = 6.49, Type = "Subs", Size = "6inch", ItemNumber = 113},
                new MenuItem {Name = "Turkey Bacon", Cost = 8.49, Type = "Subs", Size = "12inch", ItemNumber = 114},
                new MenuItem {Name = "Chicken Marinara", Cost = 6.49, Type = "Subs", Size = "6inch", ItemNumber = 115},
                new MenuItem {Name = "Chicken Marinara", Cost = 8.49, Type = "Subs", Size = "12inch", ItemNumber = 116},
                new MenuItem {Name = "Chicken Breast", Cost = 6.49, Type = "Subs", Size = "6inch", ItemNumber = 117},
                new MenuItem {Name = "Chicken Breast", Cost = 8.49, Type = "Subs", Size = "12inch", ItemNumber = 118},
                new MenuItem {Name = "Super Club", Cost = 7.49, Type = "Subs", Size = "6inch", ItemNumber = 119},
                new MenuItem {Name = "Super Club", Cost = 9.49, Type = "Subs", Size = "12inch", ItemNumber = 120},
                new MenuItem {Name = "Steak Deluxe", Cost = 7.49, Type = "Subs", Size = "6inch", ItemNumber = 121},
                new MenuItem {Name = "Steak Deluxe", Cost = 9.49, Type = "Subs", Size = "12inch", ItemNumber = 122},
                new MenuItem {Name = "Chicken parm", Cost = 7.49, Type = "Subs", Size = "6inch", ItemNumber = 123},
                new MenuItem {Name = "Chicken parm", Cost = 9.49, Type = "Subs", Size = "12inch", ItemNumber = 124},
                new MenuItem {Name = "Buffalo Chicken", Cost = 7.49, Type = "Subs", Size = "6inch", ItemNumber = 125},
                new MenuItem {Name = "Buffalo Chicken", Cost = 9.49, Type = "Subs", Size = "12inch", ItemNumber = 126},
                new MenuItem {Name = "Cuban", Cost = 7.99, Type = "Subs", Size = "9inch", ItemNumber = 127},
                new MenuItem {Name = "Creamy Chicken", Cost = 7.49, Type = "Wraps", ItemNumber = 128},
                new MenuItem {Name = "Ham & Cheese", Cost = 7.49, Type = "Wraps", ItemNumber = 129},
                new MenuItem {Name = "Tuna", Cost = 7.49, Type = "Wraps", ItemNumber = 130},
                new MenuItem {Name = "Veggie", Cost = 7.49, Type = "Wraps", ItemNumber = 131},
                new MenuItem {Name = "Buffalo Chicken", Cost = 7.99, Type = "Wraps", ItemNumber = 132},
                new MenuItem {Name = "Chicken Caesar", Cost = 7.99, Type = "Wraps", ItemNumber = 133},
                new MenuItem {Name = "Chicken Strip", Cost = 7.99, Type = "Wraps", ItemNumber = 134},
                new MenuItem {Name = "Crunchy Chicken", Cost = 7.99, Type = "Wraps", ItemNumber = 135},
                new MenuItem {Name = "Turkey", Cost = 7.99, Type = "Wraps", ItemNumber = 136},
            };
            List<MenuItem> UserOrder = new List<MenuItem>();



            while (UserChoice != "check out")
            {
                if (OrderType != "pick up" && OrderType != "delivery")
                {
                    Console.WriteLine("Welcome to Jotos online ordering");
                    Console.WriteLine("Will this be for 'Pick up' or 'Delivery'?");
                    OrderType = Console.ReadLine().ToLower();
                }

                if (OrderType == "pick up" || OrderType == "delivery")
                {

                    Console.WriteLine("Please type one of the following to get started:");
                    Console.WriteLine("Appetizer/Pizza/Wings/Special/Dinners/Kids Menu/Salads/Subs/Wraps");
                    Console.WriteLine("Type display cart to show all items in your cart or check out to check out");
                    Console.WriteLine();
                    UserChoice = Console.ReadLine().ToLower();                                                   //Add ToLower(). (added by cody)

                    if (UserChoice == "appetizer")
                    {
                        var Appetizer = MenuItems.Where(x => x.Type == "Appetizer");
                        foreach (var item in Appetizer)
                        {
                            Console.WriteLine($"{item.Size} {item.Name} = ${item.Cost} Item Number:{item.ItemNumber}");
                        }
                        AddToOrder(UserOrder, MenuItems);
                    }
                    else if (UserChoice == "pizza")
                    {
                        var Pizza = MenuItems.Where(x => x.Type == "Pizza");
                        foreach (var item in Pizza)
                        {
                            Console.WriteLine($"{item.Size} {item.Name} = ${item.Cost} Item Number:{item.ItemNumber}");
                        }
                        AddToOrder(UserOrder, MenuItems);
                    }
                    else if (UserChoice == "wings")
                    {
                        var Wings = MenuItems.Where(x => x.Type == "Wings");
                        foreach (var item in Wings)
                        {
                            Console.WriteLine($"{item.Size} {item.Name} = ${item.Cost} Item Number:{item.ItemNumber}");
                        }
                        AddToOrder(UserOrder, MenuItems);
                    }
                    else if (UserChoice == "special")
                    {
                        var Special = MenuItems.Where(x => x.Type == "Special");
                        foreach (var item in Special)
                        {
                            Console.WriteLine($"{item.Size} {item.Name} = ${item.Cost} Item Number:{item.ItemNumber}");
                        }
                        AddToOrder(UserOrder, MenuItems);
                    }
                    else if (UserChoice == "dinners")
                    {
                        var Dinners = MenuItems.Where(x => x.Type == "Dinners");
                        foreach (var item in Dinners)
                        {
                            Console.WriteLine($"{item.Size} {item.Name} = ${item.Cost} Item Number:{item.ItemNumber}");
                        }
                        AddToOrder(UserOrder, MenuItems);
                    }
                    else if (UserChoice == "kids Menu")
                    {
                        var KidsMenu = MenuItems.Where(x => x.Type == "Kids menu");
                        foreach (var item in KidsMenu)
                        {
                            Console.WriteLine($"{item.Size} {item.Name} = ${item.Cost} Item Number:{item.ItemNumber}");
                        }
                        AddToOrder(UserOrder, MenuItems);
                    }
                    else if (UserChoice == "salads")
                    {
                        var Salads = MenuItems.Where(x => x.Type == "Salads");
                        foreach (var item in Salads)
                        {
                            Console.WriteLine($"{item.Size} {item.Name} = ${item.Cost} Item Number:{item.ItemNumber}");
                        }
                        AddToOrder(UserOrder, MenuItems);
                    }
                    else if (UserChoice == "subs")
                    {
                        var Subs = MenuItems.Where(x => x.Type == "Subs");
                        foreach (var item in Subs)
                        {
                            Console.WriteLine($"{item.Size} {item.Name} = ${item.Cost} Item Number:{item.ItemNumber}");
                        }
                        AddToOrder(UserOrder, MenuItems);
                    }
                    else if (UserChoice == "wraps")
                    {
                        var Wraps = MenuItems.Where(x => x.Type == "Wraps");
                        foreach (var item in Wraps)
                        {
                            Console.WriteLine($"{item.Size} {item.Name} = ${item.Cost} Item Number:{item.ItemNumber}");
                        }
                        AddToOrder(UserOrder, MenuItems);
                    }
                    else if (UserChoice == "check out")
                    {                                                        // delete response and just use UserChoice in while loop (added by cody)
                        Console.WriteLine();
                        FinalOrder(UserOrder);
                        Console.WriteLine();
                    }
                    else if (UserChoice == "display cart")
                    {
                        Console.WriteLine();
                        RemoveFromOrder(UserOrder, MenuItems);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid response.");
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("Please enter a valid response.");
                    Console.WriteLine();
                }//Add a catch when they type in wrong answer for pickup and delivery(added by cody)
            }
        }


        public static void FinalOrder(List<MenuItem> UserOrder)
        {
            foreach (var items in UserOrder)
            {
                Console.WriteLine($"{items.Name}, ${items.Cost}");
            }
            Console.Write("The Sub Total would be: $");
            Console.WriteLine(UserOrder.Sum(x => x.Cost));
            Console.Write("The Final Total would be: $");
            Console.WriteLine(Math.Round(UserOrder.Sum(x => x.Cost * 1.07), 2));              //Plus in .07% taxs(added by cody)
        }
        public static void AddToOrder(List<MenuItem> UserOrder, List<MenuItem> MenuItems)
        {
            Console.WriteLine("Select an item number to add item to cart");
            Console.Write("Item Number: ");
            UserOrder.Add(MenuItems[int.Parse(Console.ReadLine())]);
            Console.WriteLine();
        }
        public static void RemoveFromOrder(List<MenuItem> UserOrder, List<MenuItem> MenuItems)
        {
            foreach (var items in UserOrder)
            {
                Console.WriteLine($"{items.Name}, ${items.Cost}, Item Number:{items.ItemNumber}");
            }
            Console.WriteLine("Select an item number to Remove item from cart");
            Console.Write("Item Number: ");
            UserOrder.Remove(MenuItems[int.Parse(Console.ReadLine())]);
            Console.WriteLine("The updated cart is...");
            foreach (var items in UserOrder)
            {
                Console.WriteLine($"{items.Name}, ${items.Cost}");
            }
            Console.WriteLine();
            Console.WriteLine("Will that complete your order today?");
            string OrderComplete = Console.ReadLine();
            if (OrderComplete == "yes")
            {
                UserChoice = "check out";
                FinalOrder(UserOrder);
            }
            else
            {
                Console.WriteLine();
                return;
            }
        }

    }
}
