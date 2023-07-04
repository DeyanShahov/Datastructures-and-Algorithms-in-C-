namespace Datastructures_and_Algorithms_in_C_
{
    public class Menu
    {
        private List<Question> questions;

        public Menu()
        {
            questions = new List<Question>();
            InitializeQuestions();
        }

        private void InitializeQuestions()
        {
            questions.Add(new Question("How to Print duplicate characters in a String?", "Solution"));
            questions.Add(new Question("How to check if two Strings are anagrams of each other?", "Solution2"));
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu: ");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i].Title}");
            }
        }

        public void DisplayQuestionAndSolution(int questionNumber)
        {
            if (questionNumber >= 1 && questionNumber <= questions.Count)
            {
                Question selectQuestion = questions[questionNumber - 1];
                Console.WriteLine($"Question: {selectQuestion.Title}");
                Console.WriteLine($"Solution: {selectQuestion.Solution}");
            }
            else
            {
                Console.WriteLine("Invalid question number!");
            }
        }
    }
}
