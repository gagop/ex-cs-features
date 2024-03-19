namespace CsExamples.CsVersion9_2020;

/*
 * Reference type
 * A constructor with parameters for initializing the properties.
 * Equals(object? obj), GetHashCode(), and ToString(),
 * With expression support for non-destructive mutation.
 */
public record Person(string FirstName, string LastName);

public record Employee(string FirstName, string LastName, string Department) : Person(FirstName, LastName);

//Record struct
public record struct Point(int X, int Y);

public class Examples1 {

    public static void Run()
    {
        var person1 = new Person("John", "Doe");
        var person2 = new Person("John", "Doe");

        Console.WriteLine(person1 == person2); // Output: True
        
        //With expression support for non-destructive mutation
        var person3 = person1 with { FirstName = "Jane" };
        Console.WriteLine(person3); // Output: Person { FirstName = Jane, LastName = Doe }
    }
    
}