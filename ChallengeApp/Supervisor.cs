namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor() : this("nieznane imię", "nieznane nazwisko")
        {  }

        public Supervisor(string firstName, string familyName)
        {  
            this.FirstName = firstName;
            this.FamilyName = familyName;
         }

        public string FirstName { get; private set; }

        public string FamilyName { get; private set; }

        event EmployeeBase.GradeAddedDelegate IEmployee.GradeAdded
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
                this.grades.Add(grade);
            else
                throw new Exception("Grade value exceeds the allowable range!");
        }

        public void AddGrade(string grade)
        {
            string digit = "";
            float fgrade = 0.0f;
            float modify = 5.0f;
            int pos = 0;

            if (grade.Contains("+"))
                pos = grade.IndexOf('+');

            if (grade.Contains("-"))
            {
                modify = -5.0f;
                pos = grade.IndexOf('-');
            }

            if (pos > 0)
                digit = grade.Substring(0, pos);
            else
                digit = grade.Substring(1, grade.Length - 1);

            switch (digit)
            {
                case "1": fgrade =   0.0f; break;
                case "2": fgrade =  20.0f; break;
                case "3": fgrade =  40.0f; break;
                case "4": fgrade =  60.0f; break;
                case "5": fgrade =  80.0f; break;
                case "6": fgrade = 100.0f; break;
            }

            fgrade += modify;
            this.AddGrade(fgrade);
        }

        public void AddGrade(int grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(char grade)
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

        public void AddGrade(long grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                var value = (float)grade;
                this.AddGrade(value);
            }
            else
                throw new Exception("Grade value can not be converted to float!");
        }

        public void AddGrade(double grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                var value = (float)grade;
                this.AddGrade(value);
            }
            else
                throw new Exception("Grade value can not be converted to float!");
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}    
