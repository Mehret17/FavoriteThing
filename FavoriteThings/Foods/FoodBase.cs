using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Foods
{
    class FoodBase
    {
        private readonly string _whichFood;
        private bool isOrganic = true;

        public string Food { get; protected set; }

        public FoodBase(string whichFood)
        {
            _whichFood = whichFood;
        }

        public void GetType()
        {
            Console.WriteLine($"My favorite food {_whichFood}");
            Food = Console.ReadLine();
        }

        public void Organic()
        {

            if (isOrganic)
            {
                Console.WriteLine("It is very healthy");
            }
            else
            {
                Console.WriteLine("No thanks, that is not healty!");
            }
        }


    }
}
