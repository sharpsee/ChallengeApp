namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";
        public EmployeeInFile()
        { }

        public EmployeeInFile(string firstName, string familyName) 
            : base(firstName, familyName)
        { }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.Write(grade);
            }

            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }

        public override void AddGrade(int grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                this.AddGrade(result);
            else
                throw new Exception("Grade value is not float!");
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100.0f); break;
                case 'B':
                case 'b':
                    this.AddGrade(80.0f); break;
                case 'C':
                case 'c':
                    this.AddGrade(60.0f); break;
                case 'D':
                case 'd':
                    this.AddGrade(40.0f); break;
                case 'E':
                case 'e':
                    this.AddGrade(20.0f); break;
                default:
                    throw new Exception("Wrong letter!");
            }
        }

        public override void AddGrade(long grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                var value = (float)grade;
                this.AddGrade(value);
            }
            else
                throw new Exception("Grade value can not be converted to float!");
        }

        public override void AddGrade(double grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                var value = (float)grade;
                this.AddGrade(value);
            }
            else
                throw new Exception("Grade value can not be converted to float!");
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int count = 0;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (float.TryParse(line, out float result))
                        {
                            statistics.Max = Math.Max(statistics.Max, result);
                            statistics.Min = Math.Min(statistics.Min, result);
                            statistics.Average += result;
                            count++;
                        }
                        line = reader.ReadLine();
                    }
                }
                if (count > 0)
                {
                    statistics.Average /= count;

                    switch (statistics.Average)
                    {
                        case var average when average >= 80:
                            statistics.AverageLetter = 'A';
                            break;
                        case var average when average >= 60:
                            statistics.AverageLetter = 'B';
                            break;
                        case var average when average >= 40:
                            statistics.AverageLetter = 'C';
                            break;
                        case var average when average >= 20:
                            statistics.AverageLetter = 'D';
                            break;
                        default:
                            statistics.AverageLetter = 'E';
                            break;
                    }
                }
            }
            return statistics;
        }
    }
}
