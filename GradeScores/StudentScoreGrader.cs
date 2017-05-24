using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace GradeScores
{
    public class StudentScoreGrader
    {
        public StudentScoreGrader(StudentScoreReader reader, StudentScoreWriter writer)
        {
            mReader = reader;
            mWriter = writer;
            mSorter = new StudentSorter();
        }

        public void GradeStudents(string strInputFile)
        {
            if (mReader == null || mWriter == null)
            {
                throw new Exception("Unitialised");
            }

            List<StudentScore> scores = new List<StudentScore>();

            // Read the scores
            mReader.Read(strInputFile, scores);

            // Sort the scores
            scores = mSorter.Sort(scores);

            // Output the files
            string strOutputFile = GenerateOutputFile(strInputFile);
            mWriter.OutputToFile(strOutputFile, scores);
        }

        protected virtual string GenerateOutputFile(string strInputFile)
        {
            string strExt = Path.GetExtension(strInputFile);
            if (string.IsNullOrEmpty(strExt))
            {
                strExt = "txt";
            }

            string strFileName = Path.GetFileNameWithoutExtension(strInputFile) + "-graded" + strExt;
            return Path.Combine(Path.GetDirectoryName(strInputFile), strFileName);
        }

        private StudentScoreReader mReader;
        private StudentScoreWriter mWriter;
        private StudentSorter mSorter;
    }
}
