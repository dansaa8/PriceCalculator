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
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please try again.\n");
                    break;
            }
        } while (isAlive);
    }
}