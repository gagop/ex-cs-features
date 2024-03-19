namespace CsExamples.CsVersion8_2019;


//IAsyncEnumerable<T>
public class Example2 {

    public static async IAsyncEnumerable<int> GenerateSequenceAsync(int count)
    {
        for (int i = 0; i < count; i++)
        {
            // Simulate an asynchronous operation
            await Task.Delay(100); // Wait 100ms
            yield return i; // Yield the value asynchronously
        }
    }
    
    public static async void Run()
    {
        await foreach (var number in GenerateSequenceAsync(5))
        {
            Console.WriteLine(number);
        }
    }
    
}