namespace Datastructures_and_Algorithms_in_C_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.DisplayMenu();

            Console.WriteLine("Enter the question number to view the question and solution: ");
            int questionNumber = int.Parse(Console.ReadLine());

            menu.ExecuteSolution(questionNumber);

            Console.ReadLine();

        }
    }
}