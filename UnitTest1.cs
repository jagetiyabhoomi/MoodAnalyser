using MoodAnalyzer;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mood mood1 = new Mood("i am in sad mood");
            Mood mood2 = new Mood("i am in any mood");
            String expectedOutput1 = "SAD";
            string expectedOutput2 = "HAPPY";

            string actualoutput = mood1.Analyser();
            string actualoutput2 = mood2.Analyser();
            
            Assert.AreEqual(expectedOutput1, actualoutput);
            Assert.AreEqual(expectedOutput2, actualoutput2);
        }
    }
}