namespace CsExamples.CsVersion4_2010;

/*
 * In C#, dynamic variables are defined using the dynamic keyword.
 * This feature was introduced in C# 4.0 to facilitate interoperation with COM APIs,
 * dynamically typed languages, and to simplify some scenarios that involve reflection.
 *
 * When a variable is declared as dynamic, the resolution of its type, members,
 * and operations is deferred until runtime.
 * This is in contrast to statically typed variables, where the type is known at compile time.
 * 
 */
public class Examples1 {
    public void Run()
    {
        //Dynamic example
        dynamic customVariable = "John";
        customVariable = 10;
    }
}