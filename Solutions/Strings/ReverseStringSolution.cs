namespace Datastructures_and_Algorithms_in_C_.Solutions.Strings
{
    internal class ReverseStringSolution : ISolution
    {

        public void Solve()
        {
            string value1 = Standart("Google");
            string value2 = Linq("abvgd");
            string value3 = Recursion("123456789");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);

        }

        public static string Recursion(string key)
        {
            if (key.Length == 1)
            {
                return key;
            }

            return key.Last() + Recursion(key.Substring(0, key.Length - 1));
        }


        private static string Linq(string x)
        {
            return new string(x.Reverse().ToArray());
        }

        public static string Standart(string s)
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
