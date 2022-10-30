using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Mood
    {
        public string msg;
        public Mood()
        {

        }
        public Mood(string msg)
        {
            this.msg=msg;
        }


        public string Analyser()
        {
            if (msg == "i am in sad mood")
                return "SAD";
            else if (msg == "i am in any mood")
                return "HAPPY";
            else
                return "INVALID";
        }
    }
}
