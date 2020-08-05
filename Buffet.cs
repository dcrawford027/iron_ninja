using System;
using System.Collections.Generic;

namespace iron_ninja
{
    public class Buffet
    {
        public List<IConsumable> Menu;

        // constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Hamburger", 1000, false, false),
                new Food("Curry", 600, true, false),
                new Food("Cheesecake", 1800, false, true),
                new Drink("Tea", 100, false, true),
                new Food("Steak", 780, false, false),
                new Food("Chicken", 500, false, false),
                new Food("Salmon", 420, true, false),
                new Drink("Coca-Cola", 150, false, true),
                new Food("French Fries", 810, false, false),
                new Drink("Water", 0, false, false),
                new Drink("Beer", 250, false, false),
            };
        }

        public IConsumable Serve()
        {
            int randomIndex = new Random().Next(0, Menu.Count);
            return Menu[randomIndex];
        }
    }
}