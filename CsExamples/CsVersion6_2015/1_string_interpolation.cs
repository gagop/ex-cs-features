namespace CsExamples.CsVersion6_2015;

/*
 * String interpolation
 * String interpolation in C# is a syntactic feature that simplifies the creation of
 * strings by allowing you to embed expression values directly within string literals.
 *
 * Introduced in C# 6.0, it enhances readability and maintainability of code that constructs strings.
 * Under the hood, the C# compiler transforms an interpolated string into a call to String.Format,
 * unless the interpolated string is used in a way that allows for compile-time optimization
 * to a more efficient form (e.g., directly passed as an argument to methods like Console.WriteLine).
 * 
 */
public class Example1 {

    public static void Run()
    {
        int age = 25    ;
        string message=$"John is {age} years old";
    }
    
}