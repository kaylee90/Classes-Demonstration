using System;

namespace ClassesDemonstration.Models
{
    public class Pizza
    {
        public string Customer { get; set; }
        //Size
        public int Diameter { get; set; }

        //# of slices
        public int SliceCount { get; set; }

        //Sauce Type
        public string SauceType { get; set; }

        //Cheese Type
        public string CheeseType { get; set; }

        //Toppings
        public string[] Toppings { get; set; }

        //CookTime
        public TimeSpan CookTime { get; set; }

        //Gluten free
        public bool IsGlutenFree { get; set; }

        //crust type
        public CrustType TypeOfCrust { get; set; }

        //Slice Type
        public SliceType HowToSlice { get; set; }
    }

    public enum CrustType
    {
        Default = 0,
        ThinCrust = 1,
        Pan = 2,
        HandTossed = 3,
        DeepDish = 4,
        Flat = 5
    }

    public enum SliceType
    {
        Default = 0,
        Square = 1,
        Regular = 2,
        NoneAtAll = 3
    }
}
