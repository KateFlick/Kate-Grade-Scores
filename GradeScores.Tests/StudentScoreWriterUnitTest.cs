using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GradeScores.Tests.MockObjects;

namespace GradeScores.Tests
{
    [TestClass]
    public class StudentScoreWriterUnitTest
    {
        [TestMethod]
        public void TestGetLine()
        {
            StudentScore score = new StudentScore("Jim", "Jones", 91);

            StudentScoreWriter writer = new StudentScoreWriter();
            Assert.AreEqual("Jones, Jim, 91", writer.GetLine(score));
        }

        [TestMethod]
        public void TestWriteScores()
        {
            TestStudentScoreWriter writer = new TestStudentScoreWriter();

            List<StudentScore> scores = new List<StudentScore>();
            scores.Add(new StudentScore("Jim", "Jones", 91));
            scores.Add(new StudentScore("Simone", "Smith", 87));

            writer.OutputToFile("anything.txt", scores);
            Assert.AreEqual("Jones, Jim, 91\r\nSmith, Simone, 87\r\n", writer.GetOutput());
        }
    }
}
