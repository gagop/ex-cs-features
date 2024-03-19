namespace CsExamples.CsVersion3;

/*
 * Implicitly typed local variables in C# are variables declared using the var keyword,
 * allowing the compiler to infer their type based on the expression used to initialize them.
 *
 * This feature, introduced in C# 3.0, enables developers to write code that is both easier
 * to read and write, especially when dealing with complex types, without losing
 * the strong typing benefits of C#.
 * 
 */
public class Example2 {

    public void Run()
    {
        var items = new List<string>();
    }
    
}