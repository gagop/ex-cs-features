namespace CsExamples.CsVersion1;

/*
 * In C#, a struct (or structure) is a value type that allows you to encapsulate data and related functionality.
 * Structures are quite similar to classes, which are reference types, but they have some
 * key differences and are used in different scenarios.
 *
 * Value Type: Unlike classes, structs are value types.
 * This means that when a struct is assigned to a new variable or passed to a method, a copy of the value is passed rather than a reference to the same object.
 * This can make structs more efficient for small data structures.
 *
 * Memory Allocation: Structs are allocated on the stack,
 * which can provide performance benefits, especially for small and frequently used data.
 *
 * Default Inheritance: Structs implicitly inherit from System.ValueType, which itself inherits from System.Object.
 *
 * Representing Simple Data Structures: Structs are ideal for small data structures that contain primarily data values and do not require inheritance or reference semantics.
 * Examples include complex numbers, points in a coordinate system, or small data containers.
 *
 * Performance Considerations: When performance and memory efficiency are concerns, especially in high-volume data scenarios,
 * structs can be beneficial due to their stack allocation and value semantics.
 *
 * Immutability: Structs are often used to create immutable data types because they are copied when assigned or passed,
 * making it easier to reason about the code and avoid unintended side effects.
 *
 * Limitations:
 * No Inheritance: Structs cannot inherit from other structs or classes (though they can implement interfaces),
 * which limits their use in object-oriented design scenarios.
 *
 * Default Constructors: Unlike classes, structs cannot declare a parameterless constructor.
 * A struct always has a default parameterless constructor that initializes all
 * numeric fields to zero and all reference fields to null.
 *
 * Boxing and Unboxing: When a struct is assigned to a variable of a reference type
 * (e.g., object or an interface it implements), it is boxed, creating a reference copy on the heap.
 * This can negate performance benefits if not used carefully.
 *
 * Suitability for Small Data: Due to their value type semantics, using structs for large,
 * complex data structures can lead to performance penalties due to the cost of copying.
 * Structs are best suited for small, immutable data.
 * 
 */
public struct Money
{
    public decimal Amount { get; }
    public string Currency { get; }
    
    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }
}

/*
 * With newer versions of C#, structs (and classes) can have what's called a "primary constructor",
 * which is a concise way to define constructors and initialize properties.
 */
public struct Money2(decimal amount, string currency)
{
    public decimal Amount { get; } = amount;
    public string Currency { get; } = currency;
}