using System.Diagnostics;
using PriceCalculator.Helpers;

namespace PriceCalculator;

class Program
{
    static void Main(string[] args)
    {
        bool isAlive = true;
        do
        {
            MenuHelpers.Print();
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case MenuHelpers.Quit:
                    isAlive = false;
                    break;
                case MenuHelpers.CalculatePriceForOne:
                    Person p = new Person(Util.AskForUInt("age"));
                    PrintPriceForOne(p);
                    break;
                case MenuHelpers.CalculatePriceForGroup:
                    uint peopleCount = Util.AskForUInt("number of people");
                    Person[] group = new Person[peopleCount];
                    for (int i = 0; i < group.Length; i++)
                    {
                        uint age = Util.AskForUInt($"Person #{i + 1} age");
                        group[i] = new Person(age);
                    }

                    PrintGroupSummary(group);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please try again.\n");
                    break;
            }
        } while (isAlive);
    }

    private static void PrintGroupSummary(Person[] group)
    {
        decimal totalPrice = 0;
        foreach (Person p in group)
        {
            totalPrice += p.GetPrice();
        }

        Console.WriteLine($"Antal personer i sällskapet: {group.Length}");
        Console.WriteLine($"och den totala kostnaden blir: {totalPrice}");
    }

    private static void PrintPriceForOne(Person p)
    {
        Console.WriteLine(p.AgeGroup switch
        {
            AgeGroup.Youth => $"Ungdomspris: {p.GetPrice()}",
            AgeGroup.Pensioner => $"Pensionärspris: {p.GetPrice()}",
            AgeGroup.Adult => $"Standardpris: {p.GetPrice()}"
        });
    }
}