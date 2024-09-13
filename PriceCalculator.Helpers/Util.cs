namespace PriceCalculator.Helpers;

public static class Util
{
    public static string AskForString(string prompt)
    {
        Console.Write($"{prompt}: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            Console.WriteLine($"Please enter a valid {prompt}");
        }
    }   

    public static uint AskForUInt(string prompt)
    {
        Console.Write($"{prompt}: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(input) && uint.TryParse(input, out uint result))
            {
                return result;
            }

            Console.WriteLine($"Please enter a valid {prompt}");
        }
    }
}