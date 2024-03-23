using ChallengeApp;

Employee employee1 = new Employee("Adam", "Abacki", 23);
Employee employee2 = new Employee("Kazik", "Babacki", 37);
Employee employee3 = new Employee("Tomek", "Cabacki", 33);

employee1.addScore(10);
employee1.addScore(7);
employee1.addScore(6);
employee1.addScore(5);
employee1.addScore(2);

employee2.addScore(6);
employee2.addScore(9);
employee2.addScore(2);
employee2.addScore(9);
employee2.addScore(6);

employee3.addScore(1);
employee3.addScore(8);
employee3.addScore(2);
employee3.addScore(10);
employee3.addScore(7);

List<Employee> employees = new List<Employee>
    { employee1, employee2, employee3};

Employee employeeWithMaxResult = employee1;
int maxResult = employee1.TotalScore;

foreach (var employee in employees)
{
    if (maxResult < employee.TotalScore)
    { 
        maxResult = employee.TotalScore;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Odnaleziono: " 
    + employeeWithMaxResult.FirstName + " "
    + employeeWithMaxResult.FamilyName + " z wynikiem "
    + employeeWithMaxResult.TotalScore);
