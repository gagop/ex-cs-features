namespace CsExamples.CsVersion7_2017;

public class Examples2 {

    public static void Run()
    {
        //Type pattern
        object obj = "Hello, World!";
        if (obj is string s)
        {
            Console.WriteLine(s.ToUpper()); // Output: HELLO, WORLD!
        }
        
        //Constant pattern
        if (obj is "Hello, World!")
        {
            Console.WriteLine("It's the same string");
        }
        
        //Var pattern with when clause
        if (obj is var x && x is string y)
        {
            Console.WriteLine(y.ToUpper()); // Output: HELLO, WORLD!
        }
        
        //Switch expression
        /*
        var shape = new Rectangle { Length = 10, Breadth = 10 };

        var area = shape switch
        {
            Circle c => Math.PI * c.Radius * c.Radius,
            Rectangle r when r.Length == r.Breadth => r.Length * r.Breadth, // Square
            Rectangle r => r.Length * r.Breadth,
            _ => 0 // Default case
        };
        */
        
        //Property pattern
        /*
        var person = new Person { Name = "John", Age = 30 };

        var status = person switch
        {
            { Age: >= 18 } => "Adult",
            { Age: < 18 } => "Minor",
            _ => "Unknown"
        };
        */
        
        //Tuple pattern
        (string, int) personInfo = ("John", 30);

        var result = personInfo switch
        {
            ("John", 30) => "Found John, who is 30 years old.",
            (_, > 18) => "Found an adult.",
            _ => "Default case"
        };
    }
}