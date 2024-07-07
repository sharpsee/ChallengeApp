using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine("");

var employee = new EmployeeInFile();

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employee.GradeAdded += EmployeeGradeAdded;

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
        break;
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wyjątek przechwycony: {ex.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine(employee.FirstName + " " + employee.FamilyName);
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
