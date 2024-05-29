namespace ChallengeApp
{
    public abstract class Person
    {
        public string FirstName { get; private set; }
        public string FamilyName { get; private set; }

        public Person()
        {
            this.FirstName = string.Empty;
            this.FamilyName = string.Empty;
        }
        public Person(string firstName, string familyName)
        {
            this.FirstName = firstName;
            this.FamilyName = familyName;
        }
    }
}
