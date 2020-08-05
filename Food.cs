namespace iron_ninja
{
    public class Food : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}

        public string GetInfo() 
        {
            return $"{Name} (Food). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }

        // add a constructor that takes in all four parameters
        public Food(string name, int cal, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
}