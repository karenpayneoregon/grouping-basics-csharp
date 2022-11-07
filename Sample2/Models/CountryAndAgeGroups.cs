
namespace Sample2.Models;

public class CountryAndAgeGroups
{
    public Country HomeCountry { get; }
    public int Age { get; }

    public CountryAndAgeGroups(Country homeCountry, int age)
    {
        HomeCountry = homeCountry;
        Age = age;
    }
}