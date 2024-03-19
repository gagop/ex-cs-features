using System.Linq.Expressions;

namespace CsExamples.CsVersion3;

/*
 * Expression trees in C# are a powerful feature that allows code to be represented
 * as a tree-like data structure, where each node of the tree is an expression,
 * such as a method call, a binary operation (like addition or comparison), or a value.
 *
 * This structure can be examined and modified at runtime, making expression trees
 * a key component for developing dynamic applications that need to generate or manipulate
 * code based on runtime information.
 * 
 */

public class Example {

    public static void Run()
    {
        //Examples of expression trees
        // Define an expression tree that represents a lambda expression 'x + y'
        ParameterExpression paramX = Expression.Parameter(typeof(int), "x");
        ParameterExpression paramY = Expression.Parameter(typeof(int), "y");
        BinaryExpression body = Expression.Add(paramX, paramY);

        // Compile the expression tree into a callable delegate
        Func<int, int, int> add = Expression.Lambda<Func<int, int, int>>(body, paramX, paramY).Compile();

        // Invoke the delegate
        int result = add(3, 5);

        Console.WriteLine(result); // Output: 8
    }
    
}