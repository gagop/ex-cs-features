namespace CsExamples.CsVersion6_2015;

public class Employee2 {
    public string Name { get; }
    public string Surname { get; }
    public string FullName => $"{Name} {Surname}";

    public Employee2(string name, string surname) {
        Name = name;
        Surname = surname;
        Console.WriteLine(nameof(Name)+" has been set to "+Name);
        Console.WriteLine(nameof(Surname)+" has been set to "+Surname);
    }
}