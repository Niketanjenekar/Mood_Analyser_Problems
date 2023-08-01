using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {        
        public void AnalyseMood(string message)
        {
            if (message.Contains("Happy"))
            {
                Console.WriteLine("Your Mood is HAPPY");
            }
            else
            {
                Console.WriteLine("Your Mood is SAD");
            }
        }
    }
}
