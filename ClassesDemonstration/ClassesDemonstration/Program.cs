using ClassesDemonstration.Models;
using System;

namespace ClassesDemonstration
{
    class Program
    {
        private static int gamestate;

        private static int GameState { get; set; }

        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            pizza.Customer = "Frank";
            pizza.TypeOfCrust = CrustType.ThinCrust;
            pizza.SauceType = "Marinara";
            pizza.CheeseType = "Mozzerella";
            pizza.Diameter = 21;

            pizza.Toppings = new string[10];
            pizza.Toppings[0] = "Green Peppers";
            pizza.Toppings[1] = "Onion";
            pizza.Toppings[2] = "Olives";
            pizza.Toppings[3] = "Ham";
            pizza.Toppings[4] = "Beef";
            pizza.Toppings[5] = "Sasauge";
            pizza.Toppings[6] = "Canadian Bacon";
            pizza.Toppings[7] = "Bacon";
            pizza.Toppings[8] = "Jalapenos";
            pizza.Toppings[9] = "Pineapple";

            pizza.CookTime = new System.TimeSpan(0, 8, 0);
            pizza.HowToSlice = SliceType.Square;
            pizza.SliceCount = 15;
            pizza.IsGlutenFree = false;
        }
        private static void PrintPizza(Pizza pizza)
        {
            Console.WriteLine("Customer is: {0}", pizza.Customer);
        }
    }
}
