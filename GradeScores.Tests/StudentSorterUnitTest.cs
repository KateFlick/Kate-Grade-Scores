using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GradeScores.Tests
{
    [TestClass]
    public class StudentSorterUnitTest
    {
        [TestMethod]
        public void TestSortScoreDescending()
        {
            List<StudentScore> scores = new List<StudentScore>();
            scores.Add(new StudentScore("Jim", "Jones", 86));
            scores.Add(new StudentScore("Kim", "King", 93));
            scores.Add(new StudentScore("Sam", "Silly", 72));

            StudentSorter sorter = new StudentSorter();
            scores = sorter.Sort(scores);
            Assert.AreEqual(3, scores.Count);
            Assert.AreEqual("Kim", scores[0].FirstName);
            Assert.AreEqual("Jim", scores[1].FirstName);
            Assert.AreEqual("Sam", scores[2].FirstName);
        }

        [TestMethod]
        public void TestSortScoreThenSurname()
        {
            List<StudentScore> scores = new List<StudentScore>();
            scores.Add(new StudentScore("Jim", "Jones", 72));
            scores.Add(new StudentScore("Kim", "King", 65));
            scores.Add(new StudentScore("Sam", "Silly", 72));

            StudentSorter sorter = new StudentSorter();
            scores = sorter.Sort(scores);
            Assert.AreEqual(3, scores.Count);
            Assert.AreEqual("Jim", scores[0].FirstName);
            Assert.AreEqual("Sam", scores[1].FirstName);
            Assert.AreEqual("Kim", scores[2].FirstName);
        }

        [TestMethod]
        public void TestSortScoreThenSurnameCaseInsensitive()
        {
            List<StudentScore> scores = new List<StudentScore>();
            scores.Add(new StudentScore("Jim", "Jones", 72));
            scores.Add(new StudentScore("Kim", "King", 65));
            scores.Add(new StudentScore("Steve", "jObs", 72));

            StudentSorter sorter = new StudentSorter();
            scores = sorter.Sort(scores);
            Assert.AreEqual(3, scores.Count);
            Assert.AreEqual("Steve", scores[0].FirstName);
            Assert.AreEqual("Jim", scores[1].FirstName);
            Assert.AreEqual("Kim", scores[2].FirstName);
        }

        [TestMethod]
        public void TestSortScoreThenSurnameThenFirstName()
        {
            List<StudentScore> scores = new List<StudentScore>();
            scores.Add(new StudentScore("Jim", "Jones", 72));
            scores.Add(new StudentScore("Fred", "Jones", 72));
            scores.Add(new StudentScore("Adam", "Silly", 72));

            StudentSorter sorter = new StudentSorter();
            scores = sorter.Sort(scores);
            Assert.AreEqual(3, scores.Count);
            Assert.AreEqual("Fred", scores[0].FirstName);
            Assert.AreEqual("Jim", scores[1].FirstName);
            Assert.AreEqual("Adam", scores[2].FirstName);
        }

        [TestMethod]
        public void TestSortScoreThenSurnameThenFirstNameCaseInsensitive()
        {
            List<StudentScore> scores = new List<StudentScore>();
            scores.Add(new StudentScore("finn", "Jones", 72));
            scores.Add(new StudentScore("Fred", "Jones", 72));
            scores.Add(new StudentScore("Adam", "Silly", 72));

            StudentSorter sorter = new StudentSorter();
            scores = sorter.Sort(scores);
            Assert.AreEqual(3, scores.Count);
            Assert.AreEqual("finn", scores[0].FirstName);
            Assert.AreEqual("Fred", scores[1].FirstName);
            Assert.AreEqual("Adam", scores[2].FirstName);
        }
    }
}
