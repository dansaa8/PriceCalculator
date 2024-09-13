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
                case MenuHelpers.EvaluatePrice:
                    Person p = new Person(Util.AskForUInt("age"));
                    PrintPrice(p);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please try again.\n");
                    break;
            }
        } while (isAlive);
    }

    private static void PrintPrice(Person p)
    {
        Console.WriteLine(p.AgeGroup switch
        {
            AgeGroup.Youth => $"Ungdomspris: {p.GetPrice()}",
            AgeGroup.Pensioner => $"Pensionärspris: {p.GetPrice()}",
            AgeGroup.Adult => $"Standardpris: {p.GetPrice()}"
        });
    }
}