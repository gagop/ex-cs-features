namespace CsExamples.CsVersion4_2010;

/*
 * Covariance and contravariance
 * Covariance and contravariance are concepts in type theory that pertain to how types can be
 * assigned in a way that ensures type safety, especially in the context of generic types,
 * such as those in collections, delegates, and interfaces in languages like C#.
 *
 * These concepts become particularly useful when dealing with inheritance hierarchies and polymorphism.
 */
public class Examples3 {

    public static void Run()
    {
        // Assignment compatibility.
        string str = "test";  
        // An object of a more derived type is assigned to an object of a less derived type.
        object obj = str;  
        
        // Covariance.
        IEnumerable<string> strings = new List<string>();  
        // An object that is instantiated with a more derived type argument
        // is assigned to an object instantiated with a less derived type argument.
        // Assignment compatibility is preserved.
        IEnumerable<object> objects = strings;
        
        // Contravariance.
        // Assume that the following method is in the class:
        static void SetObject(object o) { }
        Action<object> actObject = SetObject;  
        // An object that is instantiated with a less derived type argument
        // is assigned to an object instantiated with a more derived type argument.
        // Assignment compatibility is reversed.
        Action<string> actString = actObject;  
        
        /*
         * Covariance for arrays enables implicit conversion of an array of a more derived type to an array of a less derived type. But this operation is not type safe, as shown in the following code example.
         */
        object[] array = new String[10];  
        // The following statement produces a run-time exception.  
        // array[0] = 10;  
    }

    public static void Run2()
    {
        /*
         * Covariance and contravariance support for method groups allows for
         * matching method signatures with delegate types.
         * This enables you to assign to delegates not only methods
         * that have matching signatures, but also methods that return
         * more derived types (covariance) or that accept parameters that have
         * less derived types (contravariance) than that specified by the delegate type.
         */

        static object GetObject()
        {
            return null;
        }

        static void SetObject(object obj)
        {
        }

        static string GetString()
        {
            return "";
        }

        static void SetString(string str)
        {
        }

        static void Test()
        {
            // Covariance. A delegate specifies a return type as object,  
            // but you can assign a method that returns a string.  
            Func<object> del = GetString;

            // Contravariance. A delegate specifies a parameter type as string,  
            // but you can assign a method that takes an object.  
            Action<string> del2 = SetObject;

            /*
             * In .NET Framework 4 and later versions, C# supports covariance and
             * contravariance in generic interfaces and delegates and allows for
             * implicit conversion of generic type parameters.
             *A generic interface or delegate is called variant if its generic parameters
             * are declared covariant or contravariant.
             * C# enables you to create your own variant interfaces and delegates.
             */
            IEnumerable<String> strings = new List<String>();
            IEnumerable<Object> objects = strings;
        }
    }
}

        
//Declaring Variant Generic Interfaces
/*
 * You can declare a generic type parameter covariant by using the out keyword.
 * The covariant type must satisfy the following conditions:
 * The type is used only as a return type of interface methods
 * and not used as a type of method arguments.
 * This is illustrated in the following example, in which the type R is declared covariant.
 *
 * There is one exception to this rule. If you have a contravariant generic delegate
 * as a method parameter, you can use the type as a generic type parameter for the delegate.
 * This is illustrated by the type R in the following example. 
 */
interface ICovariant<out R>
{
    R GetSomething();
    // The following statement generates a compiler error.
    // void SetSomething(R sampleArg);
    void DoSomething(Action<R> callback);
}

/*
 *The type is not used as a generic constraint for the interface methods.
 * This is illustrated in the following code. 
*/
interface ICovariant3<out R>
{
    // The following statement generates a compiler error
    // because you can use only contravariant or invariant types
    // in generic constraints.
    // void DoSomething<T>() where T : R;
}

/*
 * You can declare a generic type parameter contravariant by using the in keyword.
 * The contravariant type can be used only as a type of method arguments
 * and not as a return type of interface methods.
 * The contravariant type can also be used for generic constraints.
 * The following code shows how to declare a contravariant interface and use a
 * generic constraint for one of its methods.
*/
interface IContravariant<in A>
{
    void SetSomething(A sampleArg);
    void DoSomething<T>() where T : A;
    // The following statement generates a compiler error.
    // A GetSomething();
}

/*
 * It is also possible to support both covariance and contravariance
 * in the same interface, but for different type parameters,
 * as shown in the following code example.
*/
interface IVariant<out R, in A>
{
    R GetSomething();
    void SetSomething(A sampleArg);
    R GetSetSomethings(A sampleArg);
}

//You implement variant generic interfaces in classes by using the same syntax that is used for invariant interfaces.
//The following code example shows how to implement a covariant interface in a generic class.
interface ICovariant4<out R>
{
    R GetSomething();
}

//Classes that implement variant interfaces are invariant.
class SampleImplementation<R> : ICovariant4<R>
{
    public R GetSomething()
    {
        // Some code.
        return default(R);
    }
}

public class Example4{

    public static void Run()
    {
        // The interface is covariant.
        ICovariant4<string> ibutton = new SampleImplementation<string>();
        ICovariant4<Object> iobj = ibutton;

        // The class is invariant.
        SampleImplementation<string> button = new SampleImplementation<string>();
        // The following statement generates a compiler error
        // because classes are invariant.
        // SampleImplementation<Object> obj = button;
    }
    
}

