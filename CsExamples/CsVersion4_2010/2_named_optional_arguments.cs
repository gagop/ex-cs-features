namespace CsExamples.CsVersion4_2010;

/*
 * Optional arguments
 * C# 4.0 introduced named and optional arguments, which are features that enhance method
 * invocation by making it clearer and reducing the amount of code you need to
 * write for calling methods with multiple parameters.
 *
 * Named arguments
 * Named arguments enable you to specify arguments for a method call by parameter name rather than
 * parameter position. This feature improves the readability of your code,
 * especially when you are calling methods with multiple optional parameters or
 * when the method has parameters with default values that you want to override out of order.
 * 
 */

public class Student {
    public string Name { get; }
    public int Age { get; }
    public string? Address { get; }

    public Student(string name, int age, string? address = null) {
        Name = name;
        Age = age;
        Address = address;
    }
}

public class Example2()
{
    public static void Run()
    {
        //Example of usage for named and optional arguments
        var st = new Student(age: 20, name: "John");
    }
}