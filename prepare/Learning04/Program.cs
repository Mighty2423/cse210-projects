using System;

class Program
{
    static void Main()
    {
        // Test Assignment Class
        Assignment assignment = new Assignment("Assignemt class area","Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.classname());
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        // Test MathAssignment Class
        MathAssignment mathAssignment = new MathAssignment("Math class","Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.classname());
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        // Test WritingAssignment Class
        WritingAssignment writingAssignment = new WritingAssignment("Writing class","Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.classname());
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();

        // Test poertyAssignment Class
        PoetryAssignment poetryAssignment = new PoetryAssignment("Poerty class","John Doe", "Poetry", "The Raven", "Edgar Allen Poe");
        Console.WriteLine(poetryAssignment.classname());
        Console.WriteLine(poetryAssignment.GetSummary());
        Console.WriteLine(poetryAssignment.GetPoetryInformation());
        Console.WriteLine();

        // Test powerAssignment Class
        PowerAssignment powerAssignment = new PowerAssignment("Power class","Jane powel", "welder", "Begginger", "MIG");
        Console.WriteLine(powerAssignment.classname());
        Console.WriteLine(powerAssignment.GetSummary());
        Console.WriteLine(powerAssignment.GetPowerInformation());
        Console.WriteLine();

        // Test campingAssignment Class
        CampingAssignment campingAssignment = new CampingAssignment("Camping class","John Smith", "Camping", "Yellowstone", "Tent, Sleeping Bag, Flashlight");
        CampingAssignment campingAssignment2 = new CampingAssignment("Camping class","Blan ranger", "Camping survival", "Newyork", "box tent, Blanket, Flashlight");
        Console.WriteLine(campingAssignment.classname());
        Console.WriteLine(campingAssignment.GetSummary());
        Console.WriteLine(campingAssignment.GetCampingInformation());
        Console.WriteLine(campingAssignment2.classname());
        Console.WriteLine(campingAssignment2.GetSummary());
        Console.WriteLine(campingAssignment2.GetCampingInformation());
        Console.WriteLine();

        // Test Studentname Class
        StudentName studentName = new StudentName(new List<string> { assignment.GetStudentName(),
        "\n"+ mathAssignment.GetStudentName(), "\n"+ writingAssignment.GetStudentName(), "\n"+ poetryAssignment.GetStudentName(), "\n"+ 
        powerAssignment.GetStudentName(), "\n"+ campingAssignment.GetStudentName(), "\n"+ campingAssignment2.GetStudentName() });
        StudentName classes = new StudentName(new List<string> { assignment.GetClassName()});
        Console.WriteLine(studentName.GetAllStudentNames());
        Console.WriteLine(classes.GetClassName());
        Console.WriteLine();

    }
}
