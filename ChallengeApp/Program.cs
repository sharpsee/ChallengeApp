using ChallengeApp;

Employee employee1 = new Employee("Adam", "Abacki");
Employee employee2 = new Employee("Kazik", "Babacki");
Employee employee3 = new Employee("Tomek", "Cabacki");

employee1.AddGrade((float)4.8);
employee1.AddGrade((float)7.1);
employee1.AddGrade((float)6.3);
employee1.AddGrade((float)15.7);
employee1.AddGrade((float)8.5);
employee1.AddGrade(long.MaxValue);

employee2.AddGrade(6);
employee2.AddGrade(9);
employee2.AddGrade(2);
employee2.AddGrade(9);
employee2.AddGrade(6);
employee2.AddGrade((double)float.MaxValue * 100);

employee3.AddGrade(1);
employee3.AddGrade(8);
employee3.AddGrade(2);
employee3.AddGrade(10);
employee3.AddGrade(7);
employee3.AddGrade("15");

List<Employee> employees = new List<Employee>
    { employee1, employee2, employee3};

foreach (var employee in employees)
{
    var statistics = employee.GetStatistics();

    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
}
