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

    public static string FindWordInSentence(uint minimumWordCount, uint desiredWordPosition)
    {
        if (desiredWordPosition < 1 || minimumWordCount < desiredWordPosition)
        {
            throw new ArgumentOutOfRangeException(nameof(desiredWordPosition), 
                $"The desired word position must be between 1 and {minimumWordCount}.");
        }

        while (true)
        {
            string input = AskForString($"sentence of at least {minimumWordCount} words");
            string[] enteredWords = input.Split(' ');

            if (enteredWords.Length < minimumWordCount)
            {
                Console.WriteLine("You entered too few words for this sentence.");
            }
            else
            {
                return enteredWords[desiredWordPosition - 1];
            }
        }
    }

}