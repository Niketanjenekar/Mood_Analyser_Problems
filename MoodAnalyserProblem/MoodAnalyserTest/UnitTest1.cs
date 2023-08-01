using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyser analyse = new MoodAnalyser();

        [Test]
        public void AnalyseAndRespond()
        {
            string result = analyse.AnalyseMood("I am Sad");

            Assert.AreEqual(result, "Sad");
        }

        
        
    }
}