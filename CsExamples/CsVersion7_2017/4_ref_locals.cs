namespace CsExamples.CsVersion7_2017;

/*
 * 
 */

public class Examples4 {

    private static int[] numbers = { 0, 1, 2, 3, 4, 5 };

    // Method that returns a reference to the element at the specified index
    public static ref int FindNumber(int index)
    {
        if (index >= 0 && index < numbers.Length)
        {
            return ref numbers[index]; // return a reference to the array element
        }
        throw new IndexOutOfRangeException("Index out of range");
    }
    
    public static void Run()
    {
        //Ref returns
        ref int numRef = ref FindNumber(2); // numRef is a reference to numbers[2]
        Console.WriteLine(numRef); // Output: 2

        numRef = 10; // Modify the array element through the reference
        Console.WriteLine(numbers[2]); // Output: 10
        
        //Ref locals
        int[] numbers2 = { 0, 1, 2, 3, 4, 5 };

        ref int numRef2 = ref numbers2[2]; // numRef is a reference to numbers[2]
        Console.WriteLine(numRef); // Output: 2

        numRef2 = 10; // Modify the array element through the reference
        Console.WriteLine(numbers2[2]); // Output: 10
    }
    
}