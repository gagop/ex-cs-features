namespace CsExamples.CsVersion1;

/*
 * A delegate in C# is a type that represents references to methods with a specific parameter list and return type.
 * When you instantiate a delegate, you can associate its instance with any method with a compatible signature
 * and return type.
 *
 * Delegates are used to pass methods as arguments to other methods, allowing for flexible and
 * dynamic method invocation.
 * Event handling in C# heavily relies on delegates to define event handlers.
 */

//1. Definition: You define a delegate type specifying the method's signature it will represent.
//   This includes the return type and the parameters.
public delegate bool FindEvenNumbers(int number);

//2. Instantiation and Assignment: Once a delegate type is defined, you can create an instance of it and assign a method that matches its signature.
public class ExampleOfDelegates
{
        public FindEvenNumbers del;
        public int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
}

//3. Invocation: You can invoke the delegate instance as you would call a method directly.
//   When invoked, the delegate will call the method(s) it references with the provided arguments.
public class ExampleOfDelegates2
{
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static void Main()
    {
        ExampleOfDelegates example = new ExampleOfDelegates();
        example.del = IsEven;
        foreach (int number in example.numbers)
        {
            if (example.del(number))
            {
                Console.WriteLine(number);
            }
        }
    }
}

/* Built-in delegates
 * In C#, Action and Func are built-in generic delegate types provided by the .NET Framework to
 * simplify the usage of delegates for common programming scenarios.
 *
 * They are highly useful for when you want to pass methods as arguments or return them
 * from methods without needing to define custom delegate types for every signature.
 * 
 */
public static class Example3
{
    //Built-in delegates with return type void
    static Action<int> p1 = PrintNumber;
    
    //Using built-in delegates for 
    static Func<int, bool> f1 = IsEven;
    
    public static void PrintNumber(int num)
    {
        Console.WriteLine(num);
    }
    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
}