using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void WhenGetEmployees_ShouldReturnDifferentObjects()
        {
            var employee1 = new Employee("Adam", "Borecki");
            var employee2 = new Employee("Adam", "Borecki");
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void WhenEmployeeAddsFiveGrades_ShouldReturnCorrectAverage()
        {
            var employee1 = new Employee();
            employee1.AddGrade((float)4.8);
            employee1.AddGrade((float)7.1);
            employee1.AddGrade((float)6.3);
            employee1.AddGrade((float)15.7);
            employee1.AddGrade((float)8.5);
            var statistics = employee1.GetStatistics();
            Assert.AreEqual((float)8.4800005, statistics.Average);
        }

        [Test]
        public void WhenEmployeeAddsFiveGrades_ShouldReturnCorrectMinimum()
        {
            var employee1 = new Employee();
            employee1.AddGrade((float)4.8);
            employee1.AddGrade((float)7.1);
            employee1.AddGrade((float)6.3);
            employee1.AddGrade((float)15.7);
            employee1.AddGrade((float)8.5);
            var statistics = employee1.GetStatistics();
            Assert.AreEqual((float)4.8, statistics.Min);
        }

        [Test]
        public void WhenEmployeeAddsFiveGrades_ShouldReturnCorrectMaximum()
        {
            var employee1 = new Employee();
            employee1.AddGrade((float)4.8);
            employee1.AddGrade((float)7.1);
            employee1.AddGrade((float)6.3);
            employee1.AddGrade((float)15.7);
            employee1.AddGrade((float)8.5);
            var statistics = employee1.GetStatistics();
            Assert.AreEqual((float)15.7, statistics.Max);
        }

        [Test]
        public void WhenEmployeeAddsFiveGrades_ShouldReturnCorrectAverageLetter()
        {
            var employee1 = new Employee();
            employee1.AddGrade((float)4.8);
            employee1.AddGrade((float)7.1);
            employee1.AddGrade((float)6.3);
            employee1.AddGrade('C');
            employee1.AddGrade((float)8.5);
            var statistics = employee1.GetStatistics();
            Assert.AreEqual('E', statistics.AverageLetter);
        }
    }
}