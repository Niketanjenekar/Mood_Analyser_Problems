using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class Mood_Analyser_Custom_Exception:Exception
    {
        public enum Mood_Analyser_ExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD,
        }
        public Mood_Analyser_ExceptionType type;

        public Mood_Analyser_Custom_Exception(string message,   Mood_Analyser_ExceptionType type) : base(message)
        {
            this.type = type;
        }
    }
}
