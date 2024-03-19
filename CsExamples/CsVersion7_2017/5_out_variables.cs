namespace CsExamples.CsVersion7_2017;

public class Examples5 {

    public static void Run()
    {
        int result;
        if (int.TryParse("123", out result))
        {
            Console.WriteLine(result); // Output: 123
        }
        
        //Simplified version
        if (int.TryParse("123", out int result2))
        {
            Console.WriteLine(result2); // Output: 123
        }
        
        //Version with discard
        if (int.TryParse("123", out int result3) && int.TryParse("456", out _))
        {
            Console.WriteLine(result3); // Output: 123
            // The second out variable is discarded and not used.
        }
    }
    
}