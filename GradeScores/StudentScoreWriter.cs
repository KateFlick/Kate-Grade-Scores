using System;
using System.Collections.Generic;
namespace GradeScores
{
    public class StudentScoreWriter : OutputFileWriter<StudentScore>
    {
        public override string GetLine(StudentScore value)
        {
            return string.Format("{0}, {1}, {2}", value.Surname, value.FirstName, value.Score.ToString());
        }
    }
}
