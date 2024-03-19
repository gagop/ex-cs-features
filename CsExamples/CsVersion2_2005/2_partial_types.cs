namespace CsExamples.CsVersion2;
 
/*
 * Partial classes are a feature in C# that allow a single class, struct, or interface to be split into
 * multiple files. This is particularly useful in large projects, where separating a class into
 * manageable parts can improve readability and maintainability.
 *
 * Partial classes also facilitate collaborative work, allowing multiple developers to work on
 * different aspects of the same class without causing file conflicts.
 *
 * Each part of the partial class must use the partial keyword and have the same access modifier.
 * When the application is compiled, all partial class fragments are combined into a single class.
 * This means that partial classes can share methods, properties, fields, and events across different files.
 *
 * We can use partial classes to split the definition of a class into multiple files.
 * We can also use it for splitting the definition of a struct/interface.
 *
 * Partial methods are a special case that complements partial classes.
 * A partial method has its signature defined in one part of a partial class,
 * and its implementation may be provided in another part of the class.
 *
 * The interesting aspect of partial methods is that if an implementation is not provided,
 * the compiler will remove the method signature, and any calls to the method will also be removed.
 * This makes partial methods ideal for providing hooks or placeholders that can be optionally implemented.
 *
 * Partial methods must return void and cannot have access modifiers (they are implicitly private).
 * 
 */

public partial class Student
{
    public string Name { get; }
    public int Age { get; }
    public string Address { get; }
    
    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
    }
}

public partial class Student
{
    public string Email { get; }
    public string Phone { get; }
}