namespace PriceCalculator;

public class Person
{
    private uint Age { get; }

    public Person(uint age)
    {
        Age = age;
    }

    public AgeGroup AgeGroup => Age switch
    {
        < 20 => AgeGroup.Youth,
        > 64 => AgeGroup.Pensioner,
        _ => AgeGroup.Adult
    };

    public decimal GetPrice() => AgeGroup switch
    {
        AgeGroup.Youth => 80,
        AgeGroup.Pensioner => 90,
        AgeGroup.Adult => 120
    };
}