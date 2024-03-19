using System.Collections;

namespace CsExamples.CsVersion2;

/*
 * Iterators in C# are a powerful feature that allows for a simple and clear way to enumerate
 * over a collection of objects.
 *
 * They are used to perform custom iteration over a container, such as a list or an array,
 * without the need to create a separate collection class.
 * 
 * Iterators make it easy to implement and use the IEnumerable and IEnumerator interfaces,
 * which are fundamental to the iteration over collections in .NET.
 * 
 */

//1. Enumerator done manually
public class SampleCustomCollection<T> : IEnumerable<T>, IEnumerator<T>
{
    public T[] items;
    
    public SampleCustomCollection(T[] items)
    {
        if (items == null)
        {
            throw new System.ArgumentNullException(nameof(items));
        }

        this.items = items;
        this.CurrentIndex = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        if(this.CurrentIndex+1<this.items.Length)
        {
            this.CurrentIndex++;
            return true;
        }
        
        return false;
    }

    public void Reset()
    {
        this.CurrentIndex = 0;
    }

    private int CurrentIndex = 0;
    public T Current { get; }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        
    }
}

public class CustomCollectionClient
{
    public void UseCustomCollection()
    {
        var collection = new SampleCustomCollection<int>(new int[] {1, 2, 3, 4, 5});
        foreach (var item in collection)
        {
            System.Console.WriteLine(item);
        }
    }
}

/*
 * Iterators are implemented using the yield return statement to return each
 * element one at a time and the yield break statement to end the iteration.
 *
 * When a yield return statement is reached, the current location in code is remembered.
 * Execution is restarted from that location the next time the iterator function is called.
 * 
 */

//2. Enumerator done with yield
public class SampleCustomCollection2<T> : IEnumerable<T>
{
    public T[] items;
    
    public SampleCustomCollection2(T[] items)
    {
        if (items == null)
        {
            throw new System.ArgumentNullException(nameof(items));
        }

        this.items = items;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in this.items)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}