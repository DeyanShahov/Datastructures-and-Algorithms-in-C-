namespace Datastructures_and_Algorithms_in_C_.Solutions.Strings
{
    internal class StringPalindromicSolution : ISolution
    {
        public void Solve()
        {
            string[] array = {"civic","deleveled","Hannah","kayak","level","examiron","racecar","radar",
                                "refer","reviver","easywcf","rotator","rotor","sagas","solos","stats","tenet","Csharpstar"};

            foreach (string value in array)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            }
        }

        public static bool IsPalindrome(string word)
        {
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
