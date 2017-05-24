using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GradeScores.Tests.MockObjects;

namespace GradeScores.Tests
{
    [TestClass]
    public class InputFileReaderUnitTest
    {
        [TestMethod]
        public void TestFileNotFound()
        {
            TestInputReader reader = new TestInputReader();
            List<string> output = new List<string>();            

            try
            {
                reader.Read("DummyFile.txt", output);
                Assert.Fail("Invalid file exception expected.");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("An invalid input file has been specified: DummyFile.txt", ex.Message);
            }
        }

        [TestMethod]
        public void TestNoLines()
        {
            TestInputReader reader = new TestInputReader();
            List<string> output = new List<string>();

            reader.Read("Input\\Empty.txt", output);
            Assert.AreEqual(0, reader.ReadCount);
        }

        [TestMethod]
        public void TestReadLines()
        {
            TestInputReader reader = new TestInputReader();
            List<string> output = new List<string>();

            reader.Read("Input\\TestScores.txt", output);
            Assert.AreEqual(4, reader.ReadCount);
        }
    }
}
