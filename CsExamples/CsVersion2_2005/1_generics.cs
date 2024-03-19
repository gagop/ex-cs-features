using System.Collections;

namespace CsExamples.CsVersion2;

/*
 * Generics in C# are used to create classes, structures, interfaces, and methods with a placeholder for the type of data they store or manipulate.
 * This allows for writing flexible, reusable, and type-safe code by enabling the same class or method to work with any data type without
 * the need for casting or the risk of runtime type errors.
 *
 * 
 * 
 */

public class Examples {
    
    public static void Run() {
        
        //Non-generic version of the collection
        var list = new ArrayList();
        list.Add(1);
        list.Add("Ala");
        //Stack, Queue, BitArray, Hashtable, SortedList
        
        //Examples of generic collections
        var list2 = new List<int>();
        list2.Add(1);
        
        var dict = new Dictionary<string, int>();
        dict.Add("Ala", 1);
        
        var set = new HashSet<int>();
        set.Add(1);
        
        var queue = new Queue<int>();
        queue.Enqueue(1);
        
        var stack = new Stack<int>();
        stack.Push(1);
        
        var sortedList = new SortedList<string, int>();
        sortedList.Add("Ala", 1);
        
        var bitArray = new BitArray(10);
        bitArray[0] = true;
    }
}

//2. Generic type used in class declaration
// We can also use generic types in struct, interface, delegate, method.
public class Repozytorium<T>
{
    public T[] items;
    
    public void Add(T item) {
        //...
    }
}

//3. Generic class with multiple parameters
public class Repozytorium2<T, U>
{
    public T[] items;
    public U[] items2;
    
    public void Add(T item) {
        //...
    }
}

//4. Generic class with parameter and constraint (T has to be a reference type)
public class Repozytorium3<T> where T : class
{
    public T[] items;
    
    public void Add(T item) {
        //...
    }
}

//5. Generic class with parameter and constraint (T has to be a struct)
public class Repozytorium4<T> where T : struct
{
    public T[] items;
    
    public void Add(T item) {
        //...
    }
}

//6. Generic class with parameter and constraint (T must have default parameterless constructor)
public class Repozytorium5<T> where T : new()
{
    public T[] items;
    
    public void Add(T item) {
        //...
    }
}

//7. Generic class with parameter and constraint (T must implement interface IComparable)
public class Repozytorium6<T> where T : IComparable
{
    public T[] items;
    
    public void Add(T item) {
        //...
    }
}

//8. Generic class with parameter and constraint (T must implement interface IComparable<T>)
public class Repozytorium7<T> where T : IComparable<T>
{
    public T[] items;
    
    public void Add(T item) {
        //...
    }
}

//9. Generic class with parameter and multiple constraints
public class Repozytorium8<T> where T : IComparable<T>, new()
{
    public T[] items;
    
    public void Add(T item) {
        //...
    }
}
