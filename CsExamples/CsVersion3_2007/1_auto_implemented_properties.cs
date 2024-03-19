namespace CsExamples.CsVersion3;

/*
 * C# auto-implemented properties, commonly known as auto-properties, provide a simplified syntax
 * to declare properties without the need to explicitly define backing fields.
 *
 * Before auto-properties were introduced, developers had to manually implement both the get
 * and set accessors of a property, along with a private field to store the property value.
 *
 * Auto-properties streamline this process by automatically generating this underlying field,
 * making the code cleaner and more concise.
 * 
 */

public class Student {
    //Auto-implemented properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string School { get; set; }
    
    //Full properties
    private string _name;
    public string Name2 {
        get => _name;
        set => _name = value;
    }
    
    //Private set
    public int Age2 { get; private set; }
    
    //Read-only
    public string School2 { get; }
    
}