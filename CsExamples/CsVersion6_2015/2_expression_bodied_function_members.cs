namespace CsExamples.CsVersion6_2015;

/*
 * Expression-bodied function members in C# are a syntactic feature that allows for a more
 * concise way to define members of a class, struct, or interface that consist
 * of a single statement or expression.
 *
 * Introduced in C# 6.0, this feature was initially available for methods and read-only properties.
 * Subsequent versions of C# have expanded its applicability to constructors, setters,
 * and other function members.
 *
 * Expression bodied function members:
 * Methods
   Properties
   Constructor
   Destructor
   Getters
   Setters
   Indexers
 */
public class Employee
{
    private string FirstName;
    private string LastName;

    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    //The following GetFullName() Method contains a single statement
    //public string GetFullName()
    //{
    //    return $"{FirstName} {LastName}";
    //}
    //The above GetFullName() Method can be rewritten using Expression Bodied Method as follows
    public string GetFullName() => $"{FirstName} {LastName}";
}