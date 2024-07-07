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
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.Write(grade);
                    writer.Write('\n');
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Grade value exceeds the allowable range!");
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

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (float.TryParse(line, out float result))
                        {
                            statistics.AddGrade(result);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }
    }
}
