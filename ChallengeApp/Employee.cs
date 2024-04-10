namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public string FirstName { get; private set; }
        public string FamilyName { get; private set; }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Employee(string firstName, string familyName)
        {
            this.FirstName = firstName;
            this.FamilyName = familyName;
        }
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }
        public void SubstractGrade(float grade)
        {
            this.grades.Add(-1 * grade);
        }
    }
}
