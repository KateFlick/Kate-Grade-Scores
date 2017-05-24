using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GradeScores.Tests.MockObjects;

namespace GradeScores.Tests
{
    [TestClass]
    public class OutputFileWriterUnitTest
    {
        [TestMethod]
        public void TestWriteLine()
        {
            TestOutputWriter writer = new TestOutputWriter();
            List<string> values = new List<string>();
            values.Add("Test Line");

            writer.OutputToFile("Anything.txt", values);
            Assert.AreEqual(1, writer.WriteCount);
            Assert.AreEqual("Test Line\r\n", writer.GetOutput());
        }

        [TestMethod]
        public void TestWriteMultipleLines()
        {
            TestOutputWriter writer = new TestOutputWriter();
            List<string> values = new List<string>();
            values.Add("Line 1");
            values.Add("Line 2");
            values.Add("Line 3");

            writer.OutputToFile("Anything.txt", values);
            Assert.AreEqual(3, writer.WriteCount);
            Assert.AreEqual("Line 1\r\nLine 2\r\nLine 3\r\n", writer.GetOutput());
        }
    }
}
