using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeScores
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Application expects one parameter.");
                return;
            }

            try
            {
                StudentScoreGrader grader = new StudentScoreGrader(new StudentScoreReader(), new StudentScoreWriter());
                grader.GradeStudents(args[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
