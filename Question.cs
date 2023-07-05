namespace Datastructures_and_Algorithms_in_C_
{
    public class Question
    {
        public string Title { get; set; }
        public ISolution Solution { get; set; }

        public Question( string title, ISolution solution)
        {
            Title = title;
            Solution = solution;
        }

        public void ExecuteSolution()
        {
            Console.WriteLine($"Executing solution for question: {Title}");
            Solution.Solve();
        }
    }
}
