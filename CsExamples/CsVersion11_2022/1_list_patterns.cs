namespace CsExamples.CsVersion11_2022;

public class Examples1 {

    public static void Run()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        if (numbers is [1, 2, ..])
        {
            Console.WriteLine("The array starts with 1, 2.");
        }
        
        int[] moreNumbers = { 1, 2, 3, 4, 5 };

        if (moreNumbers is [1, 2, .., 4, 5])
        {
            Console.WriteLine("The array starts with 1, 2 and ends with 4, 5.");
        }
        
        int[] exactNumbers = { 1, 2, 3 };

        if (exactNumbers is [1, 2, 3])
        {
            Console.WriteLine("The array matches the sequence 1, 2, 3 exactly.");
        }
    }
    
}