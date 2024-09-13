using PriceCalculator.Entities;

namespace PriceCalculator.Helpers;

public static class OutputHelper
{
    public static void PrintGroupSummary(Person[] group)
    {
        decimal totalPrice = 0;
        foreach (Person p in group)
        {
            totalPrice += p.GetPrice();
        }

        Console.WriteLine($"Antal personer i sällskapet: {group.Length}");
        Console.WriteLine($"och den totala kostnaden blir: {totalPrice}");
    }

    public static void PrintPriceForOne(Person p)
    {
        Console.WriteLine(p.AgeGroup switch
        {
            AgeGroup.Youth => $"Ungdomspris: {p.GetPrice()}",
            AgeGroup.Pensioner => $"Pensionärspris: {p.GetPrice()}",
            AgeGroup.Adult => $"Standardpris: {p.GetPrice()}"
        });
    }

    public static void PrintWordXTimes(string word, uint count)
    {
        for (int i = 1; i <= count; i++)
        {
            Console.Write($"{i}.{word}");
            if (i != count) Console.Write(", ");
            else Console.WriteLine();
        }
    }
}