namespace CsExamples.CsVersion6_2015;

public class Student
{
    public string? Name { get; set; }
    public List<string> Courses { get; set; }
    public Student(string name, List<string> courses)
    {
        Name = name;
        Courses = courses;
    }
    public void Enroll(string course)
    {
        Courses.Add(course);
    }
}

public class Examples3 {

    public static void Run()
    {
        Student? student = null;
        if (student != null)
        {
            Console.WriteLine($"Student name is: {student.Name}");
            if (student.Courses != null)
            {
                Console.WriteLine($"First enrolled course is: {student.Courses[2]}");
            }
        }
        
        //Safe nagivation operators
        Console.WriteLine($"Student name is: {student?.Name}");
        Console.WriteLine($"First enrolled course is: {student?.Courses?[2]}");
        
        //Null-coalescing operator
        Console.WriteLine($"Student name is: {student?.Name ?? "No student"}");
        
        //Null-conditional assignment
        student.Name ??= "John";
        
        //Null-conditional invocation
        if (student != null)
        {
            student.Enroll("Math");
        }
        student?.Enroll("Math");
    }
}

public class Student2
{
    public const int MaxNumberOfCourses = 10;
    public string? Name { get; set; }
    public List<string> Courses { get; set; }
    public event EventHandler MaxNumberOfCoursesReached;
    public Student2(string name, List<string> courses)
    {
        Name = name;
        Courses = courses;
    }
    // public void Enroll(string course)
    // {
    //     Courses.Add(course);
    //     if (Courses.Count >= MaxNumberOfCourses)
    //     {
    //         if (MaxNumberOfCoursesReached != null)
    //         {
    //             MaxNumberOfCoursesReached.Invoke(this, EventArgs.Empty);
    //         } 
    //     }
    // }       
    public void Enroll(string course)
    {
        Courses.Add(course);
        if (Courses.Count >= MaxNumberOfCourses)
        {
            //Save invocation
            MaxNumberOfCoursesReached?.Invoke(this, EventArgs.Empty);
        }
    }
}