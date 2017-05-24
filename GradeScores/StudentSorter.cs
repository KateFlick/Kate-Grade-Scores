using System.Collections.Generic;
using System.Linq;

namespace GradeScores
{
    public class StudentSorter
    {
        public List<StudentScore> Sort(List<StudentScore> students)
        {
            return students.ToArray().OrderByDescending(x => x.Score) // sort by score descending
                .ThenBy(x => x.Surname) // sort by surname case-insensitive
                .ThenBy(x => x.FirstName).ToList(); // sort by first name case-insensitive
        }
    }
}
