namespace MoodAnalyzer
{
    class Program
    {
        public static void Main(string[] args)
        {
            Mood mood = new Mood();
            string M= mood.Analyser();
            Console.WriteLine(M);
        }
    }
}
