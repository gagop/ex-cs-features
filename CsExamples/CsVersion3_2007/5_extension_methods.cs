namespace CsExamples.CsVersion3;

/*
 * Extension methods in C# are a special kind of static method that allow you to
 * add new methods to existing types without modifying the original type, creating a subclass,
 * or using any form of inheritance.
 *
 * They are a powerful feature of C# that enhance the functionality of existing classes,
 * structs, or interfaces in a clean and maintainable way.
 *
 * Extension methods are particularly useful when you want to add methods to types
 * that you do not own or cannot modify directly, such as .NET Framework classes,
 * third-party library classes, or interfaces.
 * 
 */
public static class Examples5 {

    public static string GetFirstLetter(this string str)
    {
        return str[0].ToString();
    }

    public static void Run()
    {
        string str = "Hello";
        Console.WriteLine(str.GetFirstLetter());
    }
    
}