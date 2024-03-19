namespace CsExamples.CsVersion8_2019;

public class Examples4 {

    //Can be used with arrays, Span<T> and indexable collections
    public static void Run()
    {
        //Using ranges
        {
            string[] names = { "John", "Jane", "Judy", "Jenna" };

            // Get elements from the second to the third (inclusive)
            var subArray1 = names[1..3];
            Console.WriteLine(string.Join(", ", subArray1)); // Outputs "Jane, Judy"

            // Get all elements up to the third (exclusive)
            var subArray2 = names[..3];
            Console.WriteLine(string.Join(", ", subArray2)); // Outputs "John, Jane, Judy"

            // Get all elements from the second to the end
            var subArray3 = names[1..];
            Console.WriteLine(string.Join(", ", subArray3)); // Outputs "Jane, Judy, Jenna"

            // Get all elements using a range
            var all = names[..];
            Console.WriteLine(string.Join(", ", all)); // Outputs "John, Jane, Judy, Jenna"
        }

        //Using indices
        {
            string[] names2 = { "John", "Jane", "Judy", "Jenna" };

            Console.WriteLine(names2[^1]); // Outputs "Jenna" - the last element
            Console.WriteLine(names2[^2]); // Outputs "Judy" - the second-to-last element
        }

        //Combining ranges and indices
        {
            string[] names = { "John", "Jane", "Judy", "Jenna" };

            // Get the last two elements
            var lastTwo = names[^2..];
            Console.WriteLine(string.Join(", ", lastTwo)); // Outputs "Judy, Jenna"

            // Get elements from the second-to-last up to (but not including) the last
            var middleTwo = names[1..^1];
            Console.WriteLine(string.Join(", ", middleTwo)); // Outputs "Jane, Judy"
        }
    }
    
}