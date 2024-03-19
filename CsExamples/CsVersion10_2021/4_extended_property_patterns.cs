namespace CsExamples.CsVersion10_2021;

public class Address
{
    public string City { get; set; }
    public string Country { get; set; }
}

public class Person
{
    public string Name { get; set; }
    public Address Address { get; set; }
}

public class Examples4
{
    public static void Run()
    {
        //Old version
        Person person = new Person { Name = "John", Address = new Address { City = "New York", Country = "USA" } };

        if (person is { Address: { City: "New York" } })
        {
            Console.WriteLine($"{person.Name} lives in New York.");
        }
        
        //Extended patterns
        if (person is { Address.City: "New York" })
        {
            Console.WriteLine($"{person.Name} lives in New York.");
        }
        
        List<Person> people = new List<Person>
        {
            new Person { Name = "John", Address = new Address { City = "New York", Country = "USA" } },
            new Person { Name = "Jane", Address = new Address { City = "Los Angeles", Country = "USA" } },
            new Person { Name = "Doe", Address = new Address { City = "London", Country = "UK" } }
        };

        var newYorkers = people.Where(p => p is { Address.City: "New York" }).ToList();

        foreach (var newYorker in newYorkers)
        {
            Console.WriteLine(newYorker.Name);
        }
    }
}