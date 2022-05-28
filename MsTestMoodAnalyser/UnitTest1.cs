using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProject;

namespace MsTestMoodAnalyser
{
    [TestClass]
    public class MoodAnalyser
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expexted = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyzer moodA = new MoodAnalyzer(message);//Parameterized constructor

            //Act
            string actual = moodA.AnalyzeMood();


            //Assert
            Assert.AreEqual(expexted, actual);
        }
        [TestMethod]
        public void SadMoodTest()  //Refactor TC 1.1 SAD mood testing
        {
            //Arrange
            string expexted = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyzer moodA = new MoodAnalyzer(message);//Parameterized constructor

            //Act
            string actual = moodA.AnalyzeMood();


            //Assert
            Assert.AreEqual(expexted, actual);
        }
    }
}
