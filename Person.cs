namespace SchoolRegisterExercise
{
    public enum Role
    {
        Teacher,
        Student,
        Undefined
    }

    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }        
        public string PersonalNumber { get; set; }

        public Person(string firstName, string lastName, string personalNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Undefined;
            PersonalNumber = personalNumber;
        }

        public abstract void PrintInfo();
    }
}