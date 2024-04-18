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
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int i = 0;
            while ( i < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
                i++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int i = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
                i++;
            } while (i < this.grades.Count);
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
            if (grade >= 0 && grade <= 100)
                this.grades.Add(grade);
            else
                Console.WriteLine("Grade value exceeds the allowable range!");
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                this.AddGrade(result);
            else
                Console.WriteLine("Grade value is not float!");
        }

        public void AddGrade(int grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(long grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                var value = (float)grade;
                this.AddGrade(value);
            }
            else
                Console.WriteLine("Grade value can not be converted to float!");
        }

        public void AddGrade(double grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                var value = (float)grade;
                this.AddGrade(value);
            }
            else
                Console.WriteLine("Grade value can not be converted to float!");
        }
    }
}
