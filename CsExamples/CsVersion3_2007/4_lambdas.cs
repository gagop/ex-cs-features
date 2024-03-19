namespace CsExamples.CsVersion3;

public class Examples4 {

    /*
     * A lambda expression in C# is a concise way to represent an anonymous method using a clear
     * and brief syntax.
     *
     * It provides a simple mechanism to create delegates or expression tree types,
     * which are particularly useful for writing LINQ queries and event handlers, or whenever
     * a short method is needed that won't be reused elsewhere.
     * 
     */
    public static void Run()
    {
        //Lambda expressions
        Func<int, int, int> add = (a, b) => a + b;
        
        //Lambda with longer body
        Func<int, int, int> add2 = (a, b) => {
            return a + b;
        };
    }
    
}