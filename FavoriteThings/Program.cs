using System;
using FavoriteThings.Foods;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var burger = new Burger();
            var sushi = new Sushi();
            var pizza = new Pizza();

            var foods = new FoodBase[] { burger, sushi, pizza };

            foreach (var food in foods)
            {
                food.GetType();
                food.Organic();
            }

            //burger.GetType();
            //burger.Organic();
            //Console.WriteLine();

           
            //sushi.GetType();
            //sushi.Organic();
            //Console.WriteLine();

         
            //pizza.GetType();
            //pizza.Organic();
            //Console.WriteLine();


            Console.ReadLine();

   


        }
    }
}
