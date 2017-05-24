using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GradeScores.Tests
{
    [TestClass]
    public class StudentScoreReaderUnitTest
    {
        [TestMethod]
        public void TestInvalidNumberOfTokens()
        {
            StudentScoreReader reader = new StudentScoreReader();
            List<StudentScore> output = new List<StudentScore>();

            try
            {
                reader.ReadLine("blah", output);
                Assert.Fail("Invalid line exception expected.");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "An invalid line has been found: blah");
            }
        }

        [TestMethod]
        public void TestInvalidScore()
        {
            StudentScoreReader reader = new StudentScoreReader();
            List<StudentScore> output = new List<StudentScore>();

            try
            {
                reader.ReadLine("John,Smith,Pass", output);
                Assert.Fail("Invalid line exception expected.");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("An invalid score has been found in line: John,Smith,Pass", ex.Message);
            }
        }

        [TestMethod]
        public void TestSimpleLine()
        {
            StudentScoreReader reader = new StudentScoreReader();
            List<StudentScore> output = new List<StudentScore>();

            // Make sure a score is added to the list
            reader.ReadLine("John,Smith,78", output);
            Assert.AreEqual(1, output.Count);

            // Check that it has the expected values
            StudentScore score = output[0];
            Assert.AreEqual("John", score.FirstName);
            Assert.AreEqual("Smith", score.Surname);
            Assert.AreEqual(78, score.Score);
        }

        [TestMethod]
        public void TestWhiteSpace()
        {
            StudentScoreReader reader = new StudentScoreReader();
            List<StudentScore> output = new List<StudentScore>();

            // Make sure a score is added to the list
            reader.ReadLine(" John , Smith , 78 ", output);
            Assert.AreEqual(1, output.Count);

            // Check that it has the expected values
            StudentScore score = output[0];
            Assert.AreEqual("John", score.FirstName);
            Assert.AreEqual("Smith", score.Surname);
            Assert.AreEqual(78, score.Score);
        }

        [TestMethod]
        public void TestReadFile()
        {
            StudentScoreReader reader = new StudentScoreReader();
            List<StudentScore> output = new List<StudentScore>();

            reader.Read("Input\\TestScores.txt", output);

            Assert.AreEqual(4, output.Count);
            Assert.AreEqual("TED", output[0].FirstName);
            Assert.AreEqual("BUNDY", output[0].Surname);
            Assert.AreEqual(88, output[0].Score);
            Assert.AreEqual("ALLAN", output[1].FirstName);
            Assert.AreEqual("SMITH", output[1].Surname);
            Assert.AreEqual(85, output[1].Score);
            Assert.AreEqual("MADISON", output[2].FirstName);
            Assert.AreEqual("KING", output[2].Surname);
            Assert.AreEqual(83, output[2].Score);
            Assert.AreEqual("FRANCIS", output[3].FirstName);
            Assert.AreEqual("SMITH", output[3].Surname);
            Assert.AreEqual(85, output[3].Score);
        }
    }
}
