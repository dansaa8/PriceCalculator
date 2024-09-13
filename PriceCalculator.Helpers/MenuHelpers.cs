namespace PriceCalculator.Helpers;

public static class MenuHelpers
{
    public const string Quit = "0";
    public const string EvaluatePrice = "1";

    public static void Print()
    {
        Console.WriteLine("Welcome to Price Calculator!" +
                          "\nNavigate through the different options with the corresponding numbers" +
                          $"\n{Quit}: Quit" +
                          $"\n{EvaluatePrice}: Evaluate Price");
    }
}