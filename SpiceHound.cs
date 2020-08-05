using System;

namespace iron_ninja
{
    public class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1200) {
                    return true;
                }
                return false;
            }
        }

        public override void Consume(IConsumable item)
        {
            if (!IsFull) {
                if (item.IsSpicy) {
                    calorieIntake += item.Calories - 5;
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