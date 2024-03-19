namespace CsExamples.CsVersion11_2022;

public interface IUtility
{
    static void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

public interface IMyInterface
{
    void RequiredMethod(); // Implicitly abstract

    // Explicitly abstract method (C# 8.0 does not add new syntax for this, but the concept applies to default implementations)
    abstract void AnotherRequiredMethod();

    // Default implementation
    void OptionalMethod()
    {
        Console.WriteLine("This is an optional method.");
    }
}