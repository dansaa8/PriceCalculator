namespace PriceCalculator.Entities;

public class Person
{
    public Person(uint age)
    {
        Age = age;
    }

    private uint Age { get; }

    public AgeGroup AgeGroup => Age switch
    {
        < 20 => AgeGroup.Youth,
        > 64 => AgeGroup.Pensioner,
        _ => AgeGroup.Adult
    };

    public decimal GetPrice()
    {
        return AgeGroup switch
        {
            AgeGroup.Youth => 80,
            AgeGroup.Pensioner => 90,
            AgeGroup.Adult => 120,
            _ => 120
        };
    }
}