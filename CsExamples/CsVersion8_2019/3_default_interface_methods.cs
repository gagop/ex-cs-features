namespace CsExamples.CsVersion8_2019;

public interface IExample3
{
    // A method without an implementation
    void MethodA();

    // A default method with an implementation
    void MethodB()
    {
        Console.WriteLine("Default implementation of MethodB");
    }
}