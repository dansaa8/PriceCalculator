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
        > 100 => AgeGroup.HundredPlus,
        > 64 => AgeGroup.Pensioner,
        < 5 => AgeGroup.Infant,
        < 20 => AgeGroup.Youth,
        _ => AgeGroup.Adult
    };

    public decimal GetPrice()
    {
        return AgeGroup switch
        {
            AgeGroup.Youth => 80,
            AgeGroup.Pensioner => 90,
            AgeGroup.Adult => 120,
            AgeGroup.Infant or AgeGroup.HundredPlus => 0,
            _ => 120
        };
    }
}