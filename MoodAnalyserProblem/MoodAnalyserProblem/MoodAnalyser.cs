using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
                else if (message.Contains("Happy"))
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
                return "Happy";
            }
        }
    }
}
