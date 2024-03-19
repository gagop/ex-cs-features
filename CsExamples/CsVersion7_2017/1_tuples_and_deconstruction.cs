namespace CsExamples.CsVersion7_2017;

//Tuple - reference type
//ValueTuple - value type
public class Examples7
{
    public static (int, string) SomeMethod()
    {
        return (10, "John");
    }
    
    public void Run()
    {
        //Tuples and deconstruction
        var (age, name) = SomeMethod();
        var t1 = new Tuple<int, int>(10, 20);
    }
}