namespace SchoolRegisterExercise
{
    internal partial class Program
    {
        public class App
        {
            private List<Person> Register { get; set; }
            private bool RunApp { get; set; }

            public App()
            {
                Register = new List<Person>();
                RunApp = true;
            }

            private void QuitApp()
            {
                RunApp = false;
            }

            public void Run()
            {

                while (RunApp)
                {
                    string userChoice = "";

                    while (userChoice != "0")
                    {
                        Menu.PrintMenu();

                        userChoice = Console.ReadLine()!;

                        switch (userChoice)
                        {
                            case "1":
                                var teacher = Teacher.NewTeacher();
                                Register.Add(teacher);
                                break;
                            case "2":
                                var student = Student.NewStudent();
                                Register.Add(student);
                                break;
                            case "3":
                                Teacher.PrintTeachers(Register);
                                break;
                            case "4":
                                Student.PrintStudents(Register);
                                break;
                            case "0":
                                Console.WriteLine("\nDu har valt att avsluta." +
                                    "\nVälkommen åter!");
                                QuitApp();
                                break;
                            default:
                                Console.Write("\nFel input! Tryck \"ENTER\" och försök igen.");
                                Console.ReadKey();
                                break;
                        }
                    }
                }
            }
        }

    }
}