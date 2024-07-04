namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;

        public string FirstName { get; private set; }
        public string FamilyName { get; private set; }

        public EmployeeBase()
        {
            this.FirstName = string.Empty;
            this.FamilyName = string.Empty;
        }
        public EmployeeBase(string firstName, string familyName)
        {
            this.FirstName = firstName;
            this.FamilyName = familyName;
        }

        public abstract void AddGrade(int grade);
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(long grade);
        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();
    }
}
