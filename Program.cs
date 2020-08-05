using System;

namespace iron_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            SweetTooth sweetie = new SweetTooth();
            SpiceHound spicy = new SpiceHound();
            Buffet buffet = new Buffet();

            sweetie.Consume(buffet.Serve());
            sweetie.Consume(buffet.Serve());
            sweetie.Consume(buffet.Serve());
            sweetie.Consume(buffet.Serve());
            sweetie.Consume(buffet.Serve());

            spicy.Consume(buffet.Serve());
            spicy.Consume(buffet.Serve());
            spicy.Consume(buffet.Serve());
            spicy.Consume(buffet.Serve());
            spicy.Consume(buffet.Serve());

        if (sweetie.ConsumptionHistory.Count > spicy.ConsumptionHistory.Count) {
            Console.WriteLine($"Sweetie cosumed the most items! She ate {sweetie.ConsumptionHistory.Count} items!");
        } else if (sweetie.ConsumptionHistory.Count < spicy.ConsumptionHistory.Count) {
            Console.WriteLine($"Spicy cosumed the most items! He ate {spicy.ConsumptionHistory.Count} items!");
        } else {
            Console.WriteLine("Sweetie and Spicy ate the same number of items!");
        }
        }
    }
}
