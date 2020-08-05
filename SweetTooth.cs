using System;

namespace iron_ninja
{
    public class SweetTooth : Ninja
    {
        public override bool IsFull 
        {
            get
            {
                if (calorieIntake > 1500) {
                    return true;
                }
                return false;
            }
        }

        public override void Consume(IConsumable item)
        {
            if (!IsFull) {
                if (item.IsSweet) {
                    calorieIntake += item.Calories + 10;
                } else {
                    calorieIntake += item.Calories;
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            } else {
                Console.WriteLine("You are full and cannot eat anymore.");
            }
        }
    }
}