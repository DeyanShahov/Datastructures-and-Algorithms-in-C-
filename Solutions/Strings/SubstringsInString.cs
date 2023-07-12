namespace Datastructures_and_Algorithms_in_C_.Solutions.Strings
{
    internal class SubstringsInString : ISolution
    {
        public void Solve()
        {
            string value = "rstuvwxyz";
        
            for (int length = 1; length < value.Length; length++)
            {
               
                for (int start = 0; start <= value.Length - length; start++)
                {
                    string substring = value.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
