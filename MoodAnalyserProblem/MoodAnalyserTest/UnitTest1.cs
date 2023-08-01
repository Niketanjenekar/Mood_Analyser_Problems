using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyser analyse = new MoodAnalyser();

        [Test]
        public void AnalyseAndRespond()
        {
            analyse.AnalyseMood("I am Happy");
        }

        
        
    }
}