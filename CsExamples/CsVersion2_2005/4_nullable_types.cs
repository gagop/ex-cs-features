namespace CsExamples.CsVersion2;

public class Examples2 {

    /*
     * Nullable types in C# are a feature that allows value types to hold an additional null value.
     *
     * In C#, value types such as int, double, bool, etc., cannot normally hold null because they
     * directly contain values.
     *
     * Nullable types solve this problem by wrapping value types in a special structure
     * that permits them to represent both their normal range of values and a null value,
     * indicating the absence of a value.
     * 
     */
    public static void Run()
    {
        //Nullable types
        int? nullableInt = null;
        int? nullableInt2 = 5;
        Nullable<int> nullableInt3 = null;
        int nonNullableInt = 5;
        
        //Nullable types can be used with the null coalescing operator
        int result = nullableInt ?? 0;
        int result2 = nullableInt2 ?? 0;
        //int result3 = nonNullableInt ?? 0; //Error: Operator '??' cannot be applied to operands of type 'int' and 'int'
        
        //Nullable types can be used with the null conditional operator
        int?[] nullableInts = new int?[] {null, 1, 2, null, 3};
        int? firstNonNull = nullableInts?[0];
        int? secondNonNull = nullableInts?[1];
        int? thirdNonNull = nullableInts?[2];
        int? fourthNonNull = nullableInts?[3];
        int? fifthNonNull = nullableInts?[4];
        
        //Nullable types can be used with the null conditional operator and the null coalescing operator
        int result4 = nullableInts?[0] ?? 0;
        int result5 = nullableInts?[1] ?? 0;
        int result6 = nullableInts?[2] ?? 0;
        int result7 = nullableInts?[3] ?? 0;
        int result8 = nullableInts?[4] ?? 0;
    }
}