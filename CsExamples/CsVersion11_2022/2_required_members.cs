namespace CsExamples.CsVersion11_2022;

public class Person
{
    public required string Name { get; set; }
    public required string Email { get; set; }
}

public class Examples2
{
    public static void Run()
    {
        var person = new Person { Name = "John Doe", Email = "john.doe@example.com" };
        // This is valid and compiles.

        // The following would result in a compile-time error:
        // var person2 = new Person { Name = "Jane Doe" };
        // Error: The required property 'Email' must be initialized.
    }
}