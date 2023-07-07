namespace Datastructures_and_Algorithms_in_C_.Solutions
{
    internal class ReverseStringSolution : ISolution
    {
        
        public void Solve()
        {
            string value1 = Reverse("Google");

            Console.WriteLine(value1);

            string value2 = new string("abvgd".Reverse().ToArray());

            Console.WriteLine(value2);

        }

        //Reverse a string
        public static string Reverse(string s)
        {
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            return result;
        }
    }
}
