namespace CsExamples.CsVersion7_2017;

/*
 * Local functions
 * Local functions, introduced in C# 7.0, are functions declared inside other methods. They enable you to define methods within the scope of another method, offering a way to encapsulate a piece of functionality that is only relevant within the context of that method. Local functions can capture local variables of the enclosing method,
 * similar to lambda expressions, but with some added benefits.
 *
 * Comparison with Lambda Expressions
 * Syntax: Local functions use a more traditional method syntax,
 * which can be clearer for complex operations or when defining multiple
 * local functions within a single outer method.
 *
 * Performance: Local functions can sometimes offer better performance,
 * especially when they don't capture the local state, as they avoid delegate creation.
 *
 * Visibility: Local functions are only visible within the enclosing method,
 * emphasizing their utility for encapsulation.
 * 
 */

public class Examples3 {

    public static void Run()
    {
        //Local functions
        void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    
}