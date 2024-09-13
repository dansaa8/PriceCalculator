namespace PriceCalculator.Helpers;

public static class MenuHelpers
{
    public const string Quit = "0";
    public const string CalculatePriceForOne = "1";
    public const string CalculatePriceForGroup = "2";

    public static void Print()
    {
        Console.WriteLine("Welcome to Price Calculator!" +
                          "\nNavigate through the different options with the corresponding numbers" +
                          $"\n{Quit}: Quit" +
                          $"\n{CalculatePriceForOne}: Calculate price for one person" +
                          $"\n{CalculatePriceForGroup}: Calculate price for a group of persons");
    }
}