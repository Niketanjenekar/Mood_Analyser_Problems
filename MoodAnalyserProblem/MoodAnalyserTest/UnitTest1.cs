using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void AnalyseAndRespond()
        {
            MoodAnalyser analyse = new MoodAnalyser("I am Sad Mood");

            string result = analyse.AnalyseMood();

            Assert.AreEqual(result, "Sad");
        }

        
        
        
    }
}