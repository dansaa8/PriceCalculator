namespace PriceCalculator.Helpers;

public class MenuHelpers
{
    public const string Quit = "0";

    public static void Print()
    {
        Console.WriteLine("Welcome to Price Calculator!" +
                          "\nNavigate through the different options with the corresponding numbers" +
                          $"\n{Quit}: Quit");
    }
}