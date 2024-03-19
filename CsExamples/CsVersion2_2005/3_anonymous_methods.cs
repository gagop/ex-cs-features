namespace CsExamples.CsVersion2;

public class AnonymousMethodsExamples
{
    public void Run()
    {
        /*
         * Anonymous method
         * 
         * An anonymous method in C# provides a way to define an inline, unnamed method body that
         * can be used wherever a delegate is expected.
         *
         * Before the introduction of lambda expressions in C# 3.0,
         * anonymous methods were a common way to instantiate delegate types with blocks of code
         * that did not need to be named.
         * 
         * Even though lambda expressions are now preferred for their brevity and clarity,
         * understanding anonymous methods is still useful for comprehending older C# codebases.
         */
        Func<int, int, int> add = delegate(int a, int b) { return a + b; };
    }
}