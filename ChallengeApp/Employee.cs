namespace ChallengeApp
{
    public class Employee
    {
        private List<int> points = new List<int>();
        public string FirstName { get; private set; }
        public string FamilyName { get; private set; }
        public int Age { get; private set; }
        public int TotalScore
        {
            get 
            { 
                return this.points.Sum(); 
            }
        }
        public Employee(string firstName, string familyName, int age)
        {
            this.FirstName = firstName;
            this.FamilyName = familyName;
            this.Age = age;
        }
        public void addScore(int point)
        {
            this.points.Add(point);
        }
    }
}
