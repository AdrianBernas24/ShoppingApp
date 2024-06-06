using System;
using System.Collections.Generic;

namespace SelfCheckout
{
    public static class ProductFactory
    {
        public static List<FoodProduct> CreateProducts()
        {
            return new List<FoodProduct>
            {
                new Bakery("Chleb", 4.50m),
                new Bakery("Bułka", 1.20m),
                new Bakery("Rogalik", 2.50m),
                new Vegetable("Marchewka", 2.00m),
                new Vegetable("Ziemniak", 3.00m),
                new Vegetable("Pomidor", 3.50m),
                new Fruit("Jabłko", 1.50m),
                new Fruit("Banan", 2.00m),
                new Fruit("Pomarańcza", 3.00m),
                new Dairy("Mleko", 3.20m),
                new Dairy("Jogurt", 2.50m),
                new Dairy("Ser", 5.00m),
            };
        }
    }
}
