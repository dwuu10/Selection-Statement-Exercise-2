namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite school subject?");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("I like Math as well");
                    break;
                case "english":
                    Console.WriteLine("I like English");
                    break;
                case "social studies":
                    Console.WriteLine("I like Social Studies");
                    break;
                case "history":
                    Console.WriteLine("I like History");
                    break;
                case "physical exercise":
                    Console.WriteLine("I like PE");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;

            }
        }
    }
}