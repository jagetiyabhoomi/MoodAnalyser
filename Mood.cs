using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Mood
    {

        public string Analyser()
        {
            Console.WriteLine("Enter you Mood: ");
            string str =Console.ReadLine();
            if (str == "i am in sad mood")
                return "SAD";
            else if (str == "i am in any mood")
                return "HAPPY";
            else
                return "INVALID";
        }
    }
}
