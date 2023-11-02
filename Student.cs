namespace SchoolRegisterExercise
{
    public class Student : Person
    {
        public string Course { get; set; }

        public Student(string firstName, string lastName, string personalNumber, string course)
            : base(firstName, lastName, personalNumber)
        {
            Role = Role.Student;
            Course = course;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Förnamn: {FirstName} Efternamn: {LastName} Personnummer: {PersonalNumber} Roll: {Role}  Kurs: {Course}");
        }

        public static Person NewStudent()
        {
            Console.Clear();

            Console.WriteLine("*** Registrera en ny elev ***");

            Console.Write("Förnamn: ");
            string firstName = Console.ReadLine()!;

            Console.Write("Efternamn: ");
            string lastName = Console.ReadLine()!;

            Console.Write("Personnummer: ");
            string personalNumber = Console.ReadLine()!;

            Console.Write("Kurs: ");
            string course = Console.ReadLine()!;

            Console.Write("\nEn ny elev har registrerats. Tack!" +
                "\nTryck \"ENTER\" för att återgå till huvudmenyn.");

            Console.ReadKey();

            return new Student(firstName, lastName, personalNumber, course);
        }

        public static void PrintStudents(List<Person> Register)
        {
            Console.Clear();

            if (Register.Count == 0)
            {
                Console.WriteLine("Det finns inga registrerade elever i registret.");
            }
            else
            {
                Console.WriteLine("*** Registrerade elever ***\n");
                foreach (Student student in Register)
                {
                    student.PrintInfo();
                    Console.WriteLine();
                }
            }

            Console.Write("\nTryck \"ENTER\" för att återgå till huvudmenyn.");

            Console.ReadKey();
        }
    }
}