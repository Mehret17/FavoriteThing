using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Foods
{
    class Pizza : FoodBase
    {
        // property
        //public string Type { get; set; } = "vegtable pizza";
        //public bool isOrganic { get; set; } = true;

        //method
        //public void GetType()
        //{
        //    Console.WriteLine($"my favoriet food is {Type}");
        //}

        //public void Organic()
        //{

        //    if (isOrganic)
        //    {
        //        Console.WriteLine("It very healthy");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No thanks, that is not healty!");
        //    }
        //}
        public Pizza() : base("pizza")
        {
        }
    }
}
