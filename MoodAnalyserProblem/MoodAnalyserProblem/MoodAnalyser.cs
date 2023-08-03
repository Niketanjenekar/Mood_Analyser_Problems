using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyserProblem.Mood_Analyser_Custom_Exception;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    { private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else if (message.Contains("Null"))
                {
                    return "Happy";
                }
                else
                {
                    return "Null";
                }
            }
            catch(NullReferenceException)
            {
                //return "Happy";
                throw new Mood_Analyser_Custom_Exception("Message Should Not be Null", Mood_Analyser_ExceptionType.NULL_MOOD);
            }
        }
    }
}
