namespace CsExamples.CsVersion11_2022;

public class Examples3 {

    public static void Run()
    {
        {
            int maxInt = int.MaxValue;

            try
            {
                // This will cause OverflowException
                int overflow = checked(maxInt + 1);
                Console.WriteLine(overflow);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow detected.");
            }
        }

        {
            int maxInt = int.MaxValue;

            // This will not cause OverflowException, result is wrapped
            int overflow = unchecked(maxInt + 1);
            Console.WriteLine(overflow); // Outputs: -2147483648 (which is int.MinValue)
        }
    }
    
}