namespace SchoolRegisterExercise
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string firstName, string lastName, string personalNumber, string subject)
            : base(firstName, lastName, personalNumber)
        {
            Role = Role.Teacher;
            Subject = subject;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Förnamn: {FirstName} Efternamn: {LastName} Personnummer: {PersonalNumber} Roll: {Role}  Undervisningsämne: {Subject}");
        }

        public static Person NewTeacher()
        {
            Console.Clear();

            Console.WriteLine("*** Registrera en ny lärare ***");

            Console.Write("Förnamn: ");
            string firstName = Console.ReadLine()!;

            Console.Write("Efternamn: ");
            string lastName = Console.ReadLine()!;

            Console.Write("Personnummer: ");
            string personalNumber = Console.ReadLine()!;

            Console.Write("Huvudämne: ");
            string subject = Console.ReadLine()!;

            Console.Write("\nEn ny lärare har registrerats. Tack!" +
                "\nTryck \"ENTER\" för att återgå till huvudmenyn.");

            Console.ReadKey();

            return new Teacher(firstName, lastName, personalNumber, subject);
        }

        public static void PrintTeachers(List<Person> Register)
        {
            Console.Clear();

            if (Register.Count == 0)
            {
                Console.WriteLine("Det finns inga registrerade lärare i registret.");
            }
            else
            {
                Console.WriteLine("*** Registrerade lärare ***\n");
                foreach (Teacher teacher in Register)
                {
                    teacher.PrintInfo();
                    Console.WriteLine();
                }
            }

            Console.Write("\nTryck \"ENTER\" för att återgå till huvudmenyn.");

            Console.ReadKey();
        }
    }
}