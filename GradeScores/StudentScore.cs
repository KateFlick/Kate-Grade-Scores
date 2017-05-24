
namespace GradeScores
{
    public class StudentScore
    {
        public StudentScore(string strFirstName, string strSurname, double dblScore)
        {
            FirstName = strFirstName;
            Surname = strSurname;            
            Score = dblScore;
        }

        public string Surname { get; set; }

        public string FirstName { get; set; }

        public double Score { get; set; }
    }
}
