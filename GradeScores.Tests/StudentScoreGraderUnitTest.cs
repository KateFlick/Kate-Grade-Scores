using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeScores.Tests.MockObjects;

namespace GradeScores.Tests
{
    [TestClass]
    public class StudentScoreGraderUnitTest
    {
        [TestMethod]
        public void TestBasic()
        {
            TestStudentScoreWriter writer = new TestStudentScoreWriter();
            StudentScoreGrader grader = new StudentScoreGrader(new StudentScoreReader(), writer);
            grader.GradeStudents("Input\\TestScores.txt");

            Assert.AreEqual("BUNDY, TED, 88\r\nSMITH, ALLAN, 85\r\nSMITH, FRANCIS, 85\r\nKING, MADISON, 83\r\n", writer.GetOutput());
        }
    }
}
