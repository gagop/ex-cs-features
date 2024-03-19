namespace CsExamples.CsVersion9_2020;

public class Employee2
{
    public string Name { get; init; }
    public string Department { get; init; }
    public decimal Salary { get; init; }
}

public class Examples2 {

    public static void Run()
    {
        var employee = new Employee2
        {
            Name = "John",
            Department = "IT",
            Salary = 1000
        };
        //employee.Name = "John"; //Error CS8852  Init - only property or indexer 'Employee.Name' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.
    }
    
}