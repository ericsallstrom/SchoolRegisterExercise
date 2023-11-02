namespace SchoolRegisterExercise
{
    internal partial class Program
    {
        public class Menu
        {
            public static void PrintMenu()
            {                
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();

                Console.WriteLine("* Välkommen till skolregistret *" +
                                "\n********************************" +
                                "\n* [1] Lägg till lärare         *" +
                                "\n* [2] Lägg till elev           *" +
                                "\n* [3] Visa registrerade lärare *" +
                                "\n* [4] Visa registerade elever  *" +
                                "\n*------------------------------*" +
                                "\n* [0] Avsluta" +
                                "\n********************************\n");

                Console.Write("Ditt val: ");
            }
        }
    }
}