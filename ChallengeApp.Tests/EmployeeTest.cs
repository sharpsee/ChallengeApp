using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void WhenEmployeeAddTwoPoints_ShouldReturnCorrectTotalScore()
        {
            var employee1 = new Employee("Teofil", "Dabacki", 44);
            employee1.AddScore(5);
            employee1.AddScore(6);
            var result = employee1.TotalScore;
            Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenEmployeeAddAndSubstractsTheSamePoints_ShouldReturnZero()
        {
            var employee1 = new Employee("Teofil", "Dabacki", 44);
            employee1.AddScore(3);
            employee1.AddScore(4);
            employee1.SubstractScore(7);
            var result = employee1.TotalScore;
            Assert.Zero(result);
        }

        [Test]
        public void WhenEmployeeAddPointsAndSubstractsMore_ShouldReturnLessThanZero()
        {
            var employee1 = new Employee("Teofil", "Dabacki", 44);
            employee1.AddScore(1);
            employee1.AddScore(2);
            employee1.SubstractScore(7);
            var result = employee1.TotalScore;
            Assert.Less(result, 0);
        }
    }
}