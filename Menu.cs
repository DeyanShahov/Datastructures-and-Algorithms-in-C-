using Datastructures_and_Algorithms_in_C_.Solutions.Strings;

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
            questions.Add(new Question("How to Print duplicate characters in a String?", new DuplicateCharactersSolutions()));
            questions.Add(new Question("How to check if two Strings are anagrams of each other?", new TwoWordsAnagramsSolutions()));
            questions.Add(new Question("How to reverse String using Iteration and Recursion?", new ReverseStringSolution()));
            questions.Add(new Question("How to count number of words in a String?", new NumberOfWordsSolution()));
            questions.Add(new Question("How to check if String is Palindrome?", new StringPalindromicSolution()));
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu: ");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i].Title}");
            }
        }

        public void ExecuteSolution(int questionNumber)
        {
            if (questionNumber >= 1 && questionNumber <= questions.Count)
            {
                Question selectQuestion = questions[questionNumber - 1];
                selectQuestion.ExecuteSolution();
            }
            else
            {
                Console.WriteLine("Invalid question number!");
            }
        }
    }
}
