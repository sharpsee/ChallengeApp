
namespace ChallengeApp
{
    public interface IEmployee
    {
        public string FirstName { get; }
        public string FamilyName { get; }

        public void AddGrade(float grade);

        public void AddGrade(string grade);

        public void AddGrade(char grade);

        public void AddGrade(long grade);

        public void AddGrade(double grade);

        public Statistics GetStatistics();
    }
}
