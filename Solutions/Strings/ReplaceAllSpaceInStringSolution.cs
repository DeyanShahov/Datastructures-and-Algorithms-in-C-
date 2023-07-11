namespace Datastructures_and_Algorithms_in_C_.Solutions.Strings
{
    internal class ReplaceAllSpaceInStringSolution : ISolution
    {
        public void Solve()
        {
            string value = "Wsdsad sdasda sdadsa";

            string result = Replace(value);
            Console.WriteLine($"Input : {value}\n");
            Console.WriteLine(result);
        }

        public static string Replace(string s)
        {
            s = s.Trim();
            s = s.Replace(" ", "%20");
            return s;
        }
    }
}
