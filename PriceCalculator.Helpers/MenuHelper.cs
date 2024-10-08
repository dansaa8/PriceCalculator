namespace PriceCalculator.Helpers;

public static class MenuHelper
{
    public const string Quit = "0";
    public const string CalculatePriceForOne = "1";
    public const string CalculatePriceForGroup = "2";
    public const string LoopWord = "3";
    public const string GrabThirdWord = "4";

    public static void PrintMenu()
    {
        Console.WriteLine("Welcome to Price Calculator!" +
                          "\nNavigate through the different options with the corresponding numbers" +
                          $"\n{Quit}: Quit" +
                          $"\n{CalculatePriceForOne}: Calculate price for one person" +
                          $"\n{CalculatePriceForGroup}: Calculate price for a group of persons" +
                          $"\n{LoopWord}: Loop a word 10 times!" +
                          $"\n{GrabThirdWord}: Enter a sentence of at least 3 words separated by space");
    }
}