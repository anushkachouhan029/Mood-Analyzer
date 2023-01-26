using MoodAnalyzerProg;

namespace MoodAnalyserNunitTest
{
    [TestClass]
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [TestMethod]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyser();
        }
        /// <summary>
        /// TC1.1 Given �I am in Sad Mood� message Should Return SAD
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenSad_ShouldReturnSadParameterLess_Constructor()
        {
            //Arrange
            moodAnalyser = new MoodAnalyser();
            string msg = "I am in SAD mood";
            //Act
            string message = moodAnalyser.AnalyseMoodWithoutConstructor(msg);
            //Assert
            Assert.AreEqual("SAD", message);
        }
        /// <summary>
        /// TC1.2 Given �I am in Any Mood� message Should Return HAPPY
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenAnyMood_ShouldReturnHappyParameterLess_Constructor()
        {
            moodAnalyser = new MoodAnalyser();
            string msg = "I am in Any mood";
            string message = moodAnalyser.AnalyseMoodWithoutConstructor(msg);
            Assert.AreEqual("HAPPY", message);
        }
        /// <summary>
        /// TC1.1 Given �I am in Sad Mood� message in Constructor Should Return SAD
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenSad_ShouldReturnSad()
        {
            moodAnalyser = new MoodAnalyser("I am in Sad mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("SAD", message);
        }
        /// <summary>
        /// TC1.2 Given �I am in Happy Mood� message in Constructor Should Return SAD
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenHappy_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser("I am in Happy mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", message);
        }
    }
}