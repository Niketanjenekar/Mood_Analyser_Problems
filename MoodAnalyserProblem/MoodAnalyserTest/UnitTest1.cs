using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void AnalyseAndRespond()
        {
            MoodAnalyser analyse = new MoodAnalyser("I am Null Mood");

            string result = analyse.AnalyseMood();

            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void ThrowCustomException()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                string result = moodAnalyser.AnalyseMood();
            }
            catch(Mood_Analyser_Custom_Exception ex)
            {
                Assert.AreEqual(ex.Message, "Message Should Not be Null");
            }
        }

        [Test]
        public void ThrowCustomEmptyException()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser(" ");
                string result = moodAnalyser.AnalyseMood();
            }
            catch (Mood_Analyser_Custom_Exception ex)
            {
                Assert.AreEqual(ex.Message, "Message Should Not be Empty");
            }
        }



    }
}