using System;
using System.Collections.Generic;

namespace GradeScores
{ 
    public class StudentScoreReader : InputFileReader<StudentScore>
    {
        public override void ReadLine(string strLine, List<StudentScore> output)
        {
            string[] values = strLine.Split(',');
            if (values.Length != 3)
            {
                string strError = string.Format("An invalid line has been found: {0}", strLine);
                throw new Exception(strError);
            }

            string strFirstName = values[0].Trim();
            string strSurname = values[1].Trim();

            double dblScore;
            if (!double.TryParse(values[2], out dblScore))
            {
                string strError = string.Format("An invalid score has been found in line: {0}", strLine);
                throw new Exception(strError);
            }

            output.Add(new StudentScore(strFirstName, strSurname, dblScore));
        }
    }
}
