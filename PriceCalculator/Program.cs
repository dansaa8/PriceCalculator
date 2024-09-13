using PriceCalculator.Entities;
using PriceCalculator.Helpers;

namespace PriceCalculator;

class Program
{
    static void Main(string[] args)
    {
        bool isAlive = true;
        do
        {
            MenuHelper.PrintMenu();
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case MenuHelper.Quit:
                    isAlive = false;
                    break;
                case MenuHelper.CalculatePriceForOne:
                    Person p = new Person(Util.AskForUInt("age"));
                    OutputHelper.PrintPriceForOne(p);
                    break;
                case MenuHelper.CalculatePriceForGroup:
                    uint peopleCount = Util.AskForUInt("number of people");
                    Person[] group = new Person[peopleCount];
                    for (int i = 0; i < group.Length; i++)
                    {
                        uint age = Util.AskForUInt($"Person #{i + 1} age");
                        group[i] = new Person(age);
                    }

                    OutputHelper.PrintGroupSummary(group);
                    break;
                case MenuHelper.LoopWord:
                    string chosenWord = Util.AskForString("word");
                    OutputHelper.PrintWordXTimes(chosenWord, 10);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please try again.\n");
                    break;
            }
        } while (isAlive);
    }
}