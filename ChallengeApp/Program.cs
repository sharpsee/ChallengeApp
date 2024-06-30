using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine("");

var employee = new EmployeeInFile();
employee.AddGrade(0.5f);

var statistics = employee.GetStatistics();
Console.WriteLine(employee.FirstName + " " + employee.FamilyName);
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

/*
Supervisor supervisor = new Supervisor();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
        break;
    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wyjątek przechwycony: {ex.Message}");
    }
}

var statistics = supervisor.GetStatistics();

Console.WriteLine(supervisor.FirstName + " " + supervisor.FamilyName);
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
*/